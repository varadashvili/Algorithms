//#include<iostream>
//using namespace std;
//
//
//int n, m;
//int k[51] = { 0 };
//short ans[10001] = { 0 };
//
//int find(int num)
//{
//	int ret = 0; int tmp;
//	for (int j = 1; j <= m; j++)
//	{
//		tmp = num - k[j];
//		if (tmp == 0) ret = 2;
//		if ((tmp > 0) && (ans[tmp] > 0))
//			if (ans[tmp] == 2)
//				return 1;
//			else ret = 2;
//	}
//	return ret;
//}
//
//int _main()
//{
//	int ret;
//	std::cin >> n; std::cin >> m;
//	for (int i = 1; i <= m; i++)
//		std::cin >> k[i];
//
//	for (int i = 1; i <= n; i++)
//	{
//		ans[i] = find(i);
//	}
//
//	std::cout << ans[n];
//	std::cin >> n;
//
//	return 0;
//}