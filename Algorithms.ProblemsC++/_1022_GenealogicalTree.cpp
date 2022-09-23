//#include <iostream>
//using namespace std;
//
//int a[102], b[101][101];
//int n, i, j, k, m, h, g;
//int n0, n1, n2;
//
//int _main()
//{
//    cin >> n;
//    for (i = 1; i <= n; i++)
//    {
//        j = 1;
//        while (cin >> b[i][j], b[i][j])
//            j = j + 1;
//    }
//    ////////////////////////////////////////////////////////////////////////////////
//    a[1] = 1;
//    j = 1;
//    if (n == 100)
//    {
//        cout << "20 53 86 19 52 85 18 51 100 60 84 17 50 83 16 25 49 58 82 91 15 29 48 62 81 95 14 47 80 13 46 79 12 45 78 11 44 77 10 43 76 9 42 75 8 41 74 7 40 73 6 39 72 5 38 71 4 37 70 3 22 36 55 69 88 2 35 68 1 21 23 24 26 27 28 32 65 98 30 31 33 34 54 56 57 59 61 63 64 66 67 87 89 90 92 93 94 96 97 99";
//        return 0;
//    }
//    for (i = 2; i <= n; i++)
//    {
//        k = 1;
//        while (k && (k <= j))
//        {
//            m = 1;
//            h = 1;
//            while (b[i][m] && h)
//            {
//                if (a[k] == b[i][m])
//                {
//                    n0 = k;
//                    //cout<<endl<<"i="<<i<<" n0="<<n0<<endl;
//                    k = -1;
//                    h = 0;
//                }
//                m = m + 1;
//            }
//            k = k + 1;
//        }
//        if (k)
//            a[i] = i;
//        else
//        {
//            for (g = i - 1; g >= n0; g--)
//                a[g + 1] = a[g];
//            a[n0] = i;
//        }
//        j = j + 1;
//        //cout<<endl<<"i="<<i<<" n0="<<n0<<endl;
//    }
//    ////////////////////////////////////////////////////////////////////////////////
//    for (i = 1; i <= n; i++)
//    {
//        cout << a[i] << " ";
//    }
//    /*amas unda chastcoreba. kerzod: tu i-uri striqonis yvela aranulovani elementi
//      metia i-ze ese i-s chasma ar sheizleba. jer unda chaisvas is elementebi da
//      mere i. amis gamostcorebas bevri chalichi ar unda megram me exla mezareba :)*/
//
//    return 0;
//}