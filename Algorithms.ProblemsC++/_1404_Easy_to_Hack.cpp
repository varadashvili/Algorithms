//#include "iostream"
//using namespace std;
//
//
//int _main()
//{
//	char arr[2][102];
//	short mas[2][102];
//	cin >> arr[1];
//	int i = 0; int n;
//	while ((arr[1][i] >= 97) && (arr[1][i] <= 122))
//	{
//		mas[1][i] = arr[1][i];
//		i++;
//	}
//	n = i;
//
//	for (int j = 1; j < n; j++)
//		while (mas[1][j] < mas[1][j - 1])
//		{
//			mas[1][j] += 26;
//		}
//
//	mas[0][0] = mas[1][0] - 5; if (mas[0][0] < 97) mas[0][0] += 26; arr[0][0] = mas[0][0];
//
//
//
//	for (int j = 1; j < n; j++)
//	{
//		mas[0][j] = mas[1][j] - mas[1][j - 1];
//		arr[0][j] = mas[0][j] + 97;
//	}
//
//	for (int j = 0; j < n; j++) cout << arr[0][j];
//
//	cin >> arr[1];
//
//	return 0;
//}