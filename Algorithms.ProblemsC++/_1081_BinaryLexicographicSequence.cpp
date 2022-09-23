//#include <iostream>
//using namespace std;
//
//unsigned long k, a[44], m;
//int  n, i, j;
/////////////////////////////////////////////
/////////////////////////////////////////////
//int f(long x)
//{
//    for (i = 1; i < 44; i++)
//        if (x <= a[i]) return i;
//}
/////////////////////////////////////////////
/////////////////////////////////////////////
//int _main()
//{
//    cin >> n >> k;
//    a[1] = 2; a[2] = 3;
//    for (i = 3; i <= n; i++)
//        a[i] = a[i - 1] + a[i - 2];
//    if (k > a[n])
//    {
//        cout << -1;
//        return 0;
//    }
//    for (i = f(k); i < n; i++)
//        cout << 0;
//    while (f(k) > 1)
//    {
//        cout << 1;
//        m = k - a[f(k) - 1];
//        j = f(k) - f(m);
//        for (i = 1; i < j; i++)
//            cout << 0;
//        k = m;
//    }
//    if (k == 1) cout << 0;
//    else
//        if (k == 2)cout << 1;
//
//    return 0;
//}