//#include <iostream>
//using namespace std;
//
//struct Tree
//{
//	int key;
//	Tree* left;
//	Tree* right;
//};
//long i, j, n, a[3001];
//Tree* p;
//void Build(Tree* ptr, long x)
//{
//	if (x > ptr->key)
//		if (ptr->right != NULL)
//			Build(ptr->right, x);
//		else
//		{
//			Tree* q;
//			q = new Tree();
//			q->key = x;
//			q->left = q->right = NULL;
//			ptr->right = q;
//		}
//	else
//		if (ptr->left != NULL)
//			Build(ptr->left, x);
//		else
//		{
//			Tree* q;
//			q = new Tree();
//			q->key = x;
//			q->left = q->right = NULL;
//			ptr->left = q;
//		}
//}
//void Print(Tree* ptr)
//{
//	if (ptr->right != NULL)
//		Print(ptr->right);
//	if (ptr->left != NULL)
//		Print(ptr->left);
//	cout << ptr->key << " ";
//}
//int _main()
//{
//	cin >> n;
//	for (i = 1; i <= n; i++)
//		cin >> a[i];
//	p = new Tree();
//	p->key = a[n];
//	p->left = p->right = NULL;
//	for (i = n - 1; i > 0; i--)
//		Build(p, a[i]);
//	Print(p);
//
//	return 0;
//}