//#include <iostream>
//using namespace std;
//long int n;
//long int nn[10];
//long int i, j, k;
//long int m, nmax = 0;
//int _main()
//{
//    long int a[100000];
//    j = i = 0;
//    while (cin >> n, n) {
//        nn[j] = n;
//        j++;
//        if (nmax < n) nmax = n;
//    }
//    for (i = 0; i <= nmax; i++) a[i] = 0;
//    a[0] = 0; a[1] = 1;
//    for (i = 2; i <= nmax; i++) {
//        a[i] = a[i / 2];
//        i++;
//        a[i] = a[i / 2] + a[(i / 2) + 1];
//    }
//    for (i = 0; i < j; i++)
//    {
//        m = 0;
//        for (k = 0; k <= nn[i]; k++)
//            if (m < a[k]) m = a[k];
//        cout << m << endl;
//    }
//
//    return 0;
//}