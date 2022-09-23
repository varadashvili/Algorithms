//#include <iostream>
//using namespace std;
//
//long int n, a[37], mina, maxa, sum;
//int i, j, x;
//long int ans;
//#include<stdlib.h>
//div_t y;
//
//int _main()
//{
//	mina = maxa = 1;
//	cin >> n;
//	n = n / 2;
//
//	for (i = 1; i < n; i++)
//		mina = mina * 10;
//
//	maxa = mina * 10 - 1;
//
//
//	for (i = 0; i <= maxa; i++)
//	{
//		x = i;
//
//		sum = 0;
//		for (j = 0; j < n; j++)
//		{
//			y = div(x, 10);
//			sum = sum + y.rem;
//			x = y.quot;
//		}
//
//		a[sum] = a[sum] + 1;
//		sum = 0;
//	}
//
//	for (i = 0; i <= 9 * n; i++) ans = ans + a[i] * a[i];
//
//	cout << ans;
//
//	return 0;
//}