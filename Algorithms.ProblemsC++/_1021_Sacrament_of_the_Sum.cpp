//#include <iostream>
//using namespace std;
//
//long i, j, k, x, n1, n2;
//long a[50001];
//int search();
//void quicksort();
///******************************************************************************/
//void quicksort(long l, long r, long n, long* b)
//{
//    int i, j, x, w;
//    i = l; j = r;
//    x = b[(l + r) / 2];
//    do
//    {
//        while (b[i] < x)
//            i++;
//        while (x < b[j])
//            j--;
//        if (i <= j)
//        {
//            w = b[i];
//            b[i] = b[j];
//            b[j] = w;
//            i = i + 1;
//            j = j - 1;
//        }
//    } while (i <= j);
//    if (l < j) quicksort(l, j, n, b);
//    if (i < r) quicksort(i, r, n, b);
//}
///******************************************************************************/
//int search(long beg, long end, long y)
//{
//    int midd;
//    if ((end - beg) == 1)
//    {
//        if ((y == a[beg]) || (y == a[end]))
//            return 1;
//        else
//            return 0;
//    }
//    else
//    {
//        midd = (beg + end) / 2;
//        if ((y >= a[beg]) && (y <= a[midd]))
//        {
//            end = midd;
//            midd = beg;
//        }
//        if (search(midd, end, y))
//            return 1;
//        else
//            return 0;
//    }
//}
///******************************************************************************/
//int _main()
//{
//    cin >> n1;
//    for (i = 1; i <= n1; i++)
//    {
//        cin >> a[i];
//        a[i] = 10000 - a[i];
//    }
//    quicksort(1, n1, n1, a);
//    /******************************************************************************/
//    /*for(i=1;i<=n1;i++)
//       cout<<a[i]<<" ";  */
//       /******************************************************************************/
//    cin >> n2;
//    for (i = 1; i <= n2; i++)
//    {
//        cin >> x;
//        if ((x >= a[1]) && (x <= a[n1]))
//            if (search(1, n1, x))
//            {
//                cout << "YES";
//                return 0;
//            }
//    }
//    cout << "NO";
//    /******************************************************************************/
//    /*for(i=1;i<=n1;i++)
//       cout<<a[i]<<" ";  */
//
//    return 0;
//}