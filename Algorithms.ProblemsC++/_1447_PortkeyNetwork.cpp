
#include<cstdio>


int n, m;
double leftside = 0.0, rightside = 1000000;
double curvalue = 1000000.0;
double MSTweight = 0;
double precision;

int length[1001][1001];
int price[1001][1001];
double weight[1001][1001];
int visitrank[1001];
double dist[1001];

void MST_Prim(int rank)
{
	int nodeidx = -1;

	for (int i = 1; i <= n; i++)
		dist[i] = 2147483647;

	for (int i = 1; i <= n; i++)
		for (int j = i; j <= n; j++)
			if (length[i][j] != -1)
				weight[i][j] = weight[j][i] = price[i][j] - curvalue * length[i][j];

	dist[1] = 0;

	for (int cnt = 1; cnt <= n; cnt++)
	{
		nodeidx = -1;
		for (int i = 1; i <= n; i++)
		{
			if (visitrank[i] != rank && (nodeidx == -1 || dist[i] < dist[nodeidx]))
			{
				nodeidx = i;
			}
		}

		visitrank[nodeidx] = rank;
		MSTweight += dist[nodeidx];

		for (int i = 1; i <= n; i++)
		{
			if (visitrank[i] != rank && length[i][nodeidx] != -1 && weight[i][nodeidx] < dist[i])
				dist[i] = weight[i][nodeidx];
		}
	}

}


int _main()
{
	precision = 0.00000001;

	scanf_s("%d %d", &n, &m);

	for (int i = 1; i <= n; i++)
	{
		visitrank[i] = -1;
		for (int j = 1; j <= n; j++)
			length[i][j] = -1;
	}

	int st, fn, len, prc;
	for (int i = 1; i <= m; i++)
	{
		scanf_s("%d %d %d %d", &st, &fn, &len, &prc);

		length[st][fn] = length[fn][st] = len;
		price[st][fn] = price[fn][st] = prc;
	}

	int rank = 0;
	while (rightside - leftside > precision)
	{
		rank++;
		MSTweight = 0;
		curvalue = (leftside + rightside) / 2;

		MST_Prim(rank);

		if (MSTweight > 0)
			leftside = curvalue;
		else if (MSTweight < 0)
			rightside = curvalue;
		else
			break;
	}

	printf("%.8lf\n", curvalue);

	return 0;
}

