//#include<iostream>
//using namespace std;
//
//long n, i, n1, n2, x;
//long a[1001], b[1001];
//
//long umc_saert_jeradi(int a, int b)
//{
//	long z;
//	if (a < b)
//	{
//		a = a ^ b;
//		b = a ^ b;
//		a = b ^ a;
//	}
//	while (b)
//	{
//		z = a % b;
//		a = b;
//		b = z;
//	}
//	return a;
//}
//
//int _main()
//{
//	cin >> n;
//	for (i = 1; i <= n; i++)
//		cin >> a[i];
//	n1 = n2 = 1;
//	for (i = 1; i <= n; i++)
//	{
//		x = a[i];
//		n2 = 1;
//		while (x != i)
//		{
//			x = a[x];
//			n2 = n2 + 1;
//		}
//		n1 = (n1 / umc_saert_jeradi(n1, n2)) * n2;
//	}
//
//
//	cout << n1;
//
//	return 0;
//}