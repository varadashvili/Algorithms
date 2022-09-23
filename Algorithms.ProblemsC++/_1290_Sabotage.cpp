//#include "iostream"
//using namespace std;
//
//int _main()
//{
//	int n, temp;
//	short arr[25001] = { 0 };
//	std::cin >> n;
//	for (int i = 1; i <= n; i++)
//	{
//		std::cin >> temp;
//		arr[temp] += 1;
//	}
//
//	for (int i = 25000; i >= 1; i--)
//		if (arr[i] > 0)
//			for (int j = 1; j <= arr[i]; j++)
//				std::cout << i << endl;
//
//	return 0;
//}