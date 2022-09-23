//#include <iostream>
//using namespace std;
//
//int n, m, i, j, k;
//char a[34][34];
//long ans = -4;
//struct coordinate
//{
//	int x;
//	int y;
//};
//void rec();
///*****************************************************************************/
//void rec(int ax, int by)
//{
//	coordinate co[5];
//	a[by][ax] = 'z';
//	//cout<<"ax=="<<ax<<" by=="<<by<<endl;
//	co[1].x = ax;    co[1].y = by - 1;
//	co[2].x = ax + 1;  co[2].y = by;
//	co[3].x = ax;    co[3].y = by + 1;
//	co[4].x = ax - 1;  co[4].y = by;
//	//for(m=1;m<=4;m++)
//	   //a[co[m].y][co[m].x]='z';
//	if ((co[1].y < 1) || (a[co[1].y][co[1].x] == '#'))
//		ans = ans + 1;
//	else
//		if (a[co[1].y][co[1].x] == '.')
//			rec(co[1].x, co[1].y);
//	if ((co[2].x > n) || (a[co[2].y][co[2].x] == '#'))
//		ans = ans + 1;
//	else
//		if (a[co[2].y][co[2].x] == '.')
//			rec(co[2].x, co[2].y);
//	if ((co[3].y > n) || (a[co[3].y][co[3].x] == '#'))
//		ans = ans + 1;
//	else
//		if (a[co[3].y][co[3].x] == '.')
//			rec(co[3].x, co[3].y);
//	if ((co[4].x < 1) || (a[co[4].y][co[4].x] == '#'))
//		ans = ans + 1;
//	else
//		if (a[co[4].y][co[4].x] == '.')
//			rec(co[4].x, co[4].y);
//}
///*****************************************************************************/
//int _main()
//{
//	cin >> n;
//	for (i = 1; i <= n; i++)
//		for (j = 1; j <= n; j++)
//			cin >> a[i][j];
//	rec(1, 1);
//	if (a[n][n] == '.')
//		rec(n, n);
//	cout << (ans * 9);
//	/*****************************************************************************/
//	/*for(i=1;i<=n;i++)
//	{
//	   for(j=1;j<=n;j++)
//		  cout<<a[i][j];
//	   cout<<"\n";
//	}*/
//
//	return 0;
//}