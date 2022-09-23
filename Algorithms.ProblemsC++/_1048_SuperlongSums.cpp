//#include <iostream>
//using namespace std;
//
//unsigned long n, buff, num, i, j;
//int a, b;
//
//int _main()
//{
//    cin >> n;
//    cin >> a >> b;
//    if (n == 1)
//    {
//        cout << (a + b); return 0;
//    }
//    num = 0;
//    buff = a + b;
//    for (i = 2; i <= n; i++)
//    {
//        cin >> a >> b;
//        if (a + b != 9)
//        {
//            if (a + b < 9)
//            {
//                cout << buff;
//                for (j = 1; j <= num; j++)
//                    cout << 9;
//            }
//            else
//            {
//                cout << buff + 1;
//                for (j = 1; j <= num; j++)
//                    cout << 0;
//            }
//            num = 0;
//            buff = (a + b) % 10;
//        }
//        else
//            num = num + 1;
//        if (i == n)
//        {
//            cout << buff;
//            for (j = 1; j <= num; j++)
//                cout << 9;
//        }
//    }
//
//    return 0;
//}