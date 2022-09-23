//#include <stdio.h>
//long a[10002];
//int j, i, k;
//long n, p;
//__int64 nashti;
//int _main()
//{
//    j = 1;
//    scanf_s("%ld%ld", &n, &p);
//    while (n * p)
//    {
//        if (p > n)
//        {
//            nashti = 1;
//            for (k = 1; k <= n; k++)
//            {
//                nashti = nashti * k;
//                if (nashti >= p)
//                    nashti = nashti % p;
//            }
//            a[j] = nashti;
//        }
//        else
//            a[j] = 0;
//        j = j + 1;
//        scanf_s("%ld%ld", &n, &p);
//    }
//    for (i = 1; i < j; i++)
//        printf("%ld\n", a[i]);
//
//    return 0;
//}