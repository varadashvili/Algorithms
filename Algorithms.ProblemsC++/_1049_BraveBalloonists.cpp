//#include <iostream>
//using namespace std;
//
//long a[2000][2];
//long i, j, k, x, h, b, maxn, m, ans;
//int _main()
//{
//    a[1][0] = 2; a[2][0] = 3; a[3][0] = 5; a[4][0] = 7; a[5][0] = 11; a[6][0] = 13;
//    m = 6;
//    for (i = 17; i <= 9973; i = i + 2)
//    {
//        h = 1;
//        for (j = 1; j <= m; j++)
//            if (i % a[j][0] == 0)
//                h = 0;
//        if (h)
//        {
//            m = m + 1;
//            a[m][0] = i;
//        }
//    }
//    for (i = 1; i <= 10; i++)
//    {
//        cin >> b;
//        if (b > 1)
//        {
//            x = b / 2;
//            for (j = 1; a[j][0] <= x; j++)
//                while (b % a[j][0] == 0)
//                {
//                    if (maxn < j)
//                        maxn = j;
//                    b = b / a[j][0];
//                    a[j][1] = a[j][1] + 1;
//                }
//            if (b != 1)
//            {
//                while (a[j][0] != b)
//                    j = j + 1;
//                a[j][1] = a[j][1] + 1;
//                if (maxn < j)
//                    maxn = j;
//            }
//        }
//    }
//    ans = 1;
//    for (i = 1; i <= maxn; i++)
//    {
//        ans = ans * (a[i][1] + 1);
//        ans = ans % 10;
//    }
//    cout << ans;
//
//    return 0;
//}