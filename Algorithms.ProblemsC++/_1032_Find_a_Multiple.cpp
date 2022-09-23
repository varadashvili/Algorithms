//#include<iostream>
//using namespace std;
//
//long a[10004], b[10004], c[10004];
//long i, j, k, m, n, x;
//
//int _main()
//{
//	cin >> n;
//	k = 1;
//	for (i = 1; i <= n; i++)
//	{
//		cin >> a[i];
//		if (k)
//		{
//			if (a[i] % n == 0) { k = 0; m = i; }
//			b[i] = a[i] % n;
//		}
//	}
//	if (k == 0)
//	{
//		cout << 1 << endl << a[m];
//		return 0;
//	}
//	for (i = 1; i <= n; i++)
//		for (j = 1; j <= i; j++)
//			c[i] = c[i] + b[j];
//	for (i = 1; i <= n; i++)
//		c[i] = c[i] % n;
//	for (i = 1; i <= n; i++)
//		if (c[i] == 0)
//		{
//			m = i;
//			cout << (m) << endl;
//			for (j = 1; j <= m; j++)
//				cout << a[j] << endl;
//			return 0;
//		}
//	for (i = 1; i < n; i++)
//		for (j = i + 1; j <= n; j++)
//			if (c[i] == c[j])
//			{
//				cout << (j - i) << endl;
//				for (k = i + 1; k <= j; k++)
//					cout << a[k] << endl;
//				return 0;
//			}
//}