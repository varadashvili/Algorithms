//#include <iostream>
//#include <stdio.h>
//#include <math.h>
//using namespace std;
//
//float a[100][2], length, r;
//int n;
//int i, j;
//float pi2 = 6.283185307179586476925286766559;
//
//int _main()
//{
//    cin >> n >> r;
//    for (i = 0; i < n; i++)
//        for (j = 0; j < 2; j++)
//            cin >> a[i][j];
//    if (n == 1) { length = r * pi2;  printf("%.2f", length);  return 0; }
//
//
//    for (i = 0; i < n - 1; i++)
//        length = length + sqrt((a[i][1] - a[i + 1][1]) * (a[i][1] - a[i + 1][1]) + (a[i][0] - a[i + 1][0]) * (a[i][0] - a[i + 1][0]));
//    if (n - 1) length = length + sqrt((a[0][1] - a[n - 1][1]) * (a[0][1] - a[n - 1][1]) + (a[0][0] - a[n - 1][0]) * (a[0][0] - a[n - 1][0]));
//
//    length = length + r * pi2;
//    printf("%.2f", length);
//
//    return 0;
//}