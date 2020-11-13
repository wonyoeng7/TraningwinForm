#include <stdio.h>

int test(int i1, int i2)
{
	return i1 + i2;
}

int main()
{
	int t1 = 100;
	int t2 = 200;
	char* p = "[%d][%d]\n";

	t1 = test(5, 6);
	t2 = 5 + 3;
	printf(p, t1, t2);
	printf("[%d][%d]\n", t1, t2);

	return 0;
}