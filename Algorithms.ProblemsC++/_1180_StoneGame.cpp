//#include <stdio.h>
//
//int _main()
//{
//    char ch;
//    int sumall = 0;
//    while (!feof(stdin))
//    {
//        scanf("%c", &ch);
//        if (feof(stdin))
//            break;
//        if (ch >= '0' && ch <= '9')
//            sumall += (ch - '0');
//    }
//    sumall = sumall % 3;
//    printf("%d", ((sumall == 0) + 1));
//    if (sumall)
//        printf("\n%d", sumall);
//
//    return 0;
//}