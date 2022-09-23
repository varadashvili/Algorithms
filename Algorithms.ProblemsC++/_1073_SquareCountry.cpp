//#include "iostream"
//using namespace std;
//
//int _main()
//{
//	int n;
//	std::cin >> n;
//	for (int i = 1; (i * i) <= n; i++)
//		if (i * i == n)
//		{
//			std::cout << 1;
//			return 0;
//		}
//
//	for (int i = 1; (i * i) < n; i++)
//		for (int j = i; (j * j + i * i) <= n; j++)
//			if ((j * j + i * i) == n)
//			{
//				std::cout << 2;
//				return 0;
//			}
//
//	for (int i = 1; (i * i) < n; i++)
//		for (int j = i; (j * j + i * i) <= n; j++)
//			for (int k = j; (j * j + i * i + k * k) <= n; k++)
//				if ((j * j + i * i + k * k) == n)
//				{
//					std::cout << 3;
//					return 0;
//				}
//
//	std::cout << 4;
//
//	return 0;
//}