//#include "iostream"
//using namespace std;
//
//char arr[1][2003];
//int n, cnt;
//
//
//void PrintSalary(int nn)
//{
//	for (int j = 0; j < nn; j++)
//		cout << arr[0][j];
//	if (cnt % 2 != 0)
//		cout << arr[0][nn];
//	for (int j = nn - 1; j >= 0; j--)
//		cout << arr[0][j];
//	cout << endl;
//}
//
//bool RightSalary()
//{
//	for (int j = n - 1; j >= 0; j--)
//		if (arr[0][cnt - j - 1] > arr[0][j]) return false;
//		else if (arr[0][cnt - j - 1] < arr[0][j]) return true;
//	return true;
//}
//
//void IncreaseSalary(int k)
//{
//	int i = k;
//	while (arr[0][i] == '9')
//		i--;
//	arr[0][i]++;
//	for (int j = i + 1; j <= k; j++)
//		arr[0][j] = '0';
//}
//
//int _main()
//{
//	cin >> arr[0];
//
//	for (cnt = 0; cnt < 2003; cnt++)
//		if ((arr[0][cnt] < 48) || (arr[0][cnt] > 57)) break;
//	n = cnt / 2;
//
//	int ndx = (cnt % 2 == 0 ? n - 1 : n);
//
//	if (RightSalary())
//	{
//		PrintSalary(n);
//	}
//	else
//	{
//		IncreaseSalary(ndx);
//		PrintSalary(n);
//	}
//
//	return 0;
//}