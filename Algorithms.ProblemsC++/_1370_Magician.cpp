//#include "iostream"
//using namespace std;
//
//
//int _main()
//{
//	int n, m;
//	int arr[1001] = { 0 };
//
//	cin >> n >> m;
//	for (int i = 1; i <= n; i++)
//		cin >> arr[i];
//
//	if (m >= n) m = m % n;
//
//	int start = m + 1;
//	int stop = start + 9;
//
//	if (stop <= n)
//		for (int i = start; i <= stop; i++)
//			cout << arr[i];
//	else
//	{
//		for (int i = start; i <= n; i++)
//			cout << arr[i];
//		for (int i = 1; i <= (stop - n); i++)
//			cout << arr[i];
//	}
//
//	cin >> n;
//	
//	return 0;
//}