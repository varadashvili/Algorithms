//#include <stdio.h>
//#include <math.h>
//
//long n, hn, v[100];
//long double r;
//
//
//int _main()
//{
//	int i, j;
//
//	scanf_s("%d", &n);
//	for (i = 0; i < n; i++)
//		scanf_s("%ld", &v[i]);
//	for (i = 0; i < n; i++)
//		for (j = i + 1; j < n; j++)
//			if (v[i] < v[j])
//				hn = v[i], v[i] = v[j], v[j] = hn;
//
//	r = 2 * sqrtl(v[0] * v[1]);
//	for (i = 2; i < n; i++)
//		r = 2 * sqrtl(r * v[i]);
//	if (n == 1) r = v[0];
//	printf("%.3Lf\n", r);
//
//	return 0;
//}