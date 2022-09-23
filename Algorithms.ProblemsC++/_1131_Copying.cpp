//#include <iostream>
//using namespace std;
//
//long n, k, i, j, x, dro;
//
//int _main()
//{
//    cin >> n >> k;
//    if (n == 1)
//    {
//        cout << 0;
//        return 0;
//    }
//    if (k == 1)
//    {
//        cout << (n - 1);
//        return 0;
//    }
//    x = 1;
//    while ((x < k) && (x < n))
//    {
//        x = x + x;
//        dro = dro + 1;
//    }
//    if (x < n)
//    {
//        n = n - x;
//        if (n % k == 0)
//            dro = dro + n / k;
//        else
//            dro = dro + n / k + 1;
//    }
//    cout << dro;
//
//    return 0;
//}