//#include <iostream>
//using namespace std;
//
//long i, j, k, a[100001], c[101], n;
//void quicksort();
//char* l = "###";
//
///******************************************************************************/
//void quicksort(long l, long r, long n, long* b)
//{
//	int i, j, x, w;
//	i = l; j = r;
//	x = b[(l + r) / 2];
//
//	do
//	{
//		while (b[i] < x)
//			i++;
//		while (x < b[j])
//			j--;
//		if (i <= j)
//		{
//			w = b[i];
//			b[i] = b[j];
//			b[j] = w;
//			i = i + 1;
//			j = j - 1;
//		}
//	} while (i <= j);
//	if (l < j) quicksort(l, j, n, b);
//	if (i < r) quicksort(i, r, n, b);
//}
//
///******************************************************************************/
//int _main()
//{
//	cin >> n;
//	for (i = 1; i <= n; i++)
//		cin >> a[i];
//	cin >> l;
//	cin >> k;
//	quicksort(1, n, n, a);
//	for (i = 1; i <= k; i++)
//		cin >> c[i];
//	for (i = 1; i <= k; i++)
//		cout << a[c[i]] << endl;
//
//	return 0;
//	/******************************************************************************/
//}