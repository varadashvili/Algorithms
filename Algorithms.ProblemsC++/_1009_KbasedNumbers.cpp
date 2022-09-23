//#include <iostream>
//using namespace std;
//
//int X, Y, n, k;
//int solve();
//
//int solve(int nMax, int k)
//{
//    if (nMax > 1)
//        X = (k - 1) * (solve(nMax - 1, k) + solve(nMax - 2, k));
//    else
//        if (nMax == 1)
//            X = k - 1;
//        else
//            if (nMax == 0)X = 1;
//    return X;
//}
//
//
//int _main()
//{
//    cin >> n >> k;
//    Y = solve(n, k);
//    cout << Y;
//
//    return 0;
//}