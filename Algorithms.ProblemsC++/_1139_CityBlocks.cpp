//#include <iostream>
//using namespace std;
//
//int n, m;
//int x, y, z;
//
//int _main()
//{
//    cin >> n >> m;
//    n = n - 1;
//    m = m - 1;
//    if (n == m)
//        cout << n;
//    else
//    {
//        if (m > n)
//        {
//            x = m;
//            y = n;
//        }
//        else
//        {
//            x = n;
//            y = m;
//        }
//        while (x != y)
//        {
//            while (x > y)
//                x = x - y;
//            z = x;
//            x = y;
//            y = z;
//        }
//        cout << (n + m - x);
//    }
//
//    return 0;
//}