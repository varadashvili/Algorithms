//#include <iostream>
//using namespace std;
//
//long n, i, j, k, x, l, c;
//long a[15001], b[15001];
//
//int _main()
//{
//    cin >> n;
//    c = 1;
//    for (i = 1; i <= n; i++)
//    {
//        cin >> b[i];
//        if (c < b[i])
//            c = b[i];
//    }
//    j = 1;
//    a[j] = 2;
//    a[j + 1] = 3;
//    a[j + 2] = 5;
//    j = j + 2;
//    for (i = 7; j < c; i = i + 2)
//    {
//        x = i / 2;
//        l = 1;
//        for (k = 2; (a[k] < x) && l; k++)
//            if (i % a[k] == 0)
//                l = 0;
//        if (l)
//        {
//            j = j + 1;
//            a[j] = i;
//        }
//    }
//
//    for (i = 1; i <= n; i++)
//        cout << a[b[i]] << endl;
//    /*for(i=1;i<=c+10;i++)
//    cout<<a[i]<<endl;*/
//
//    return 0;
//}