//#include<iostream>
//using namespace std;
//
//long N, M, i, j, k, n, m, a[6200][2], x, p, l;
//long ans;
//
//int _main()
//{
//
//    cin >> N >> M;
//    n = N;
//    if ((N - M) > M)
//    {
//        k = M;
//        m = N - M;
//    }
//    else
//    {
//        k = N - M;
//        m = M;
//    }
//    a[1][0] = 2; a[1][1] = 0; a[2][0] = 3; a[2][1] = 0; p = 0;
//
//    for (i = 2; i <= k; i++)
//    {
//        x = i;
//        for (j = 1; a[j][0] <= i / 2; j++)
//        {
//            while (x % a[j][0] == 0)
//            {
//                x = x / a[j][0];
//                a[j][1] = a[j][1] - 1;
//            }
//        }
//        if (x != 1)
//        {
//            p = p + 1;
//            a[p][0] = x;
//            a[p][1] = -1;
//        }
//    }
//
//    if ((k + 1) % 2 == 0)
//        k = k + 2;
//    else
//        k = k + 1;
//    int t;
//    for (i = k; i <= m; i = i + 2)
//    {
//        x = i;
//        t = true;
//        for (j = 1; (a[j][0] <= i / 2) && t; j++)
//        {
//            if (x % a[j][0] == 0)
//                t = false;
//        }
//
//        if (t)
//        {
//            p = p + 1;
//            a[p][0] = x;
//        }
//    }
//
//    for (i = m + 1; i <= n; i++)
//    {
//        x = i;
//        for (j = 1; a[j][0] <= i / 2; j++)
//        {
//            while (x % a[j][0] == 0)
//            {
//                x = x / a[j][0];
//                a[j][1] = a[j][1] + 1;
//            }
//        }
//        if (x != 1)
//        {
//            p = p + 1;
//            a[p][0] = x;
//            a[p][1] = 1;
//        }
//    }
//    for (i = 1; i <= p; i++)
//        if (a[i][1] != 0)
//            ans = ans + 1;
//    cout << ans << endl;
//
//    return 0;
//}