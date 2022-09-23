//#include <iostream>
//using namespace std;
//
//int n, k, j, h, rem, z;
//long a0, a1, x;
//int a[4000], b[4000], c[4000];
//long m, i;
//
//int _main()
//{
//    cin >> n >> k;
//    for (i = 1; i <= 4000; i++)
//        a[i] = b[i] = c[i] = -1;
//    a[1] = 1;
//    b[1] = k - 1;
//    /*a1=k-1;
//    a0=1;*/
//    for (i = 1; i < n; i++)
//    {
//        /*cout<<endl<<"a ";
//        for(z=10;z>0;z--)
//           cout<<a[z]<<"  ";
//        cout<<endl<<"b ";
//        for(z=10;z>0;z--)
//           cout<<b[z]<<"  ";*/
//
//        j = 1;
//        rem = 0;
//        while (a[j] >= 0)
//        {
//            x = b[j] + a[j] + rem;
//            a[j] = x % 10;
//            rem = x / 10;
//            j = j + 1;
//        }
//        if (b[j] >= 0)
//            rem = rem + b[j];
//        if (rem)
//        {
//            if (rem > 9)
//            {
//                a[j] = rem % 10;
//                a[j + 1] = rem / 10;
//                j = j + 1;
//            }
//            else
//                a[j] = rem;
//        }
//        else
//            j = j - 1;
//        /*cout<<endl<<"j ";
//        for(z=10;z>0;z--)
//           cout<<a[z]<<"  ";*/
//           ////////////////////////////////////////////////////////////////////////////////
//        rem = 0;
//        for (h = 1; h <= j; h++)
//        {
//            x = a[h] * (k - 1) + rem;
//            c[h] = x % 10;
//            rem = x / 10;
//        }
//        if (rem)
//        {
//            c[j + 1] = rem;
//            j = j + 1;
//        }
//        /*cout<<endl<<"namr ";
//        for(z=10;z>0;z--)
//           cout<<c[z]<<"  "; */
//        m = 1;
//        while (b[m] >= 0)
//        {
//            a[m] = b[m];
//            b[m] = c[m];
//            m = m + 1;
//        }
//        b[j] = c[j];
//        a[m] = -1;
//    }
//    m = 1;
//    while (c[m] >= 0)
//        m = m + 1;
//    for (i = m - 1; i > 0; i--)
//        cout << c[i];
//
//    return 0;
//}