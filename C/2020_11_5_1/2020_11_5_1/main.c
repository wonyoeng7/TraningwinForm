#include<stdio.h>

struct Test
{
	int a;
	int b;
};


int main()
{

	struct Test		aTest;
	struct Test*	pTest;

	aTest.a = 100;
	aTest.b = 200;
	pTest = &aTest;

	printf("aTest.a : %d\n",aTest.a);
	printf("aTest.b : %d\n",aTest.b);

	printf("pTest->a : %d\n", pTest->a);
	printf("pTest->b : %d\n", pTest->b);

	printf("aTest Size : %d\n", sizeof(aTest));
	printf("pTest Size : %d\n", sizeof(pTest));

	return 0;
}


