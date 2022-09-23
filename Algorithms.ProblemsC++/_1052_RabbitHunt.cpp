//#include <iostream>
//#include <math.h>
//using namespace std;
//
//long int n, i, j, k, ans, c[201][3], m, temp;
//double a, b, result;
//
///******************************************************************************/
//int _main()
//{
//    cin >> n;
//    m = temp = 0;
//    int g = 0;
//    for (i = 1; i <= n; i++)
//        cin >> c[i][1] >> c[i][2];
//    for (i = 1; i < n; i++)
//        for (j = i + 1; j <= n; j++)
//        {
//            if ((c[i][2] - c[j][2]) == 0)
//                g = 2;
//            else
//                if ((c[i][1] - c[j][1]) == 0)
//                    g = 1;
//                else
//                    g = 0;
//            if (g == 0)
//            {
//                a = (double)(c[i][2] - c[j][2]) / (double)(c[i][1] - c[j][1]);
//                b = c[j][2] - a * c[j][1];
//            }
//
//            temp = 0;
//            for (k = i; k <= n; k++)
//            {
//                if (g == 0)
//                {
//                    result = abs((double)a * c[k][1] + b - (double)c[k][2]);
//                    //cout<<"result"<<k<<"="<<result<<endl<<"\n";
//
//                    if (result < 0.000000000001)
//                        temp = temp + 1;
//                }
//                else
//                    if (g == 2)
//                    {
//                        if (c[k][2] == c[i][2])
//                            temp = temp + 1;
//                    }
//                    else
//                    {
//                        if (c[k][1] == c[i][1])
//                            temp = temp + 1;
//                    }
//            }
//            if (temp > m)
//                m = temp;
//        }
//    cout << m;
//    /******************************************************************************/
//
//    return 0;
//}