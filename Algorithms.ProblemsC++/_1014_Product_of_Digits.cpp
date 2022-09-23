//#include <iostream>
//using namespace std;
//
//int a[28];
//int i, k, j;
//int x, y;
//long int num;
//int n2, n3, n4, n5, n6, n7, n8, n9;
//long int z1, z2;
//
//int _main()
//{
//    cin >> num;
//    if (!num) { cout << "10"; return 0;; }
//    if (num == 1) { cout << "1"; return 0; }
//    x = 1;
//    k = 0;
//    n2 = n3 = n5 = n7 = n8 = n9 = n4 = n6 = 0;
//
//    for (i = 2; num % i == 0; k = k + 1) { num = num / i; a[k] = i; }
//    for (i = 3; num % i == 0; k = k + 1) { num = num / i; a[k] = i; }
//    for (i = 5; num % i == 0; k = k + 1) { num = num / i; a[k] = i; }
//    for (i = 7; num % i == 0; k = k + 1) { num = num / i; a[k] = i; }
//    k = k - 1;
//    if (num > 1) { cout << "-1"; return 0; }
//    for (i = 0; i <= k; i++)
//        if (a[i] == 2) n2 = n2 + 1;
//    for (i = 0; i <= k; i++)
//        if (a[i] == 3) n3 = n3 + 1;
//    for (i = 0; i <= k; i++)
//        if (a[i] == 5) n5 = n5 + 1;
//    for (i = 0; i <= k; i++)
//        if (a[i] == 7) n7 = n7 + 1;
//    n8 = (n2 - n2 % 3) / 3;
//    n2 = n2 % 3;
//    n9 = (n3 - n3 % 2) / 2;
//    n3 = n3 % 2;
//    if ((n3 == 1) && (n2 == 2)) { x = 2; y = 6; }
//    else
//    {
//        i = j = 0;
//        i = n3 * 3;
//        j = n2 * 2;
//        if (i * j) y = i * j;
//        if (i * (!j)) y = i;
//        if (j * (!i)) y = j;
//    }
//    if (x == 2) { n2 = 1; n6 = 1; n3 = 0; }
//    else
//        switch (y) {
//        case 2: n2 = 1; n3 = 0; break;
//        case 3: n2 = 0; n3 = 1; break;
//        case 4: n2 = 0; n3 = 0; n4 = 1; break;
//        case 6: n2 = 0; n3 = 0; n6 = 1; break;
//        }
//    for (i = 0; i <= 27; i++) a[i] = 0;
//
//    k = j = i = 0;
//
//    z1 = z2 = 0;
//    if (n2) for (i = k = j; i < n2 + k; i++, j++) { a[i] = 2; }
//
//    if (n3) for (i = k = j; i < n3 + k; i++, j++) { a[i] = 3; }
//
//    if (n4) for (i = k = j; i < n4 + k; i++, j++) { a[i] = 4; }
//
//    if (n5) for (i = k = j; i < n5 + k; i++, j++) { a[i] = 5; }
//
//    if (n6) for (i = k = j; i < n6 + k; i++, j++) { a[i] = 6; }
//
//    if (n7) for (i = k = j; i < n7 + k; i++, j++) { a[i] = 7; }
//
//    if (n8) for (i = k = j; i < n8 + k; i++, j++) { a[i] = 8; }
//
//    if (n9) for (i = k = j; i < n9 + k; i++, j++) { a[i] = 9; }
//    for (i = 0; a[i]; i++) k = i;
//    if (k > 8) {
//        for (i = 0; i <= k - 4; i++) z1 = z1 * 10 + a[i];
//        for (i = k - 3; i <= k; i++) z2 = z2 * 10 + a[i];
//        cout << z1 << z2;
//    }
//    else
//    {
//        for (i = 0; i <= k; i++) z1 = z1 * 10 + a[i];
//        cout << z1;
//    }
//
//    return 0;
//}