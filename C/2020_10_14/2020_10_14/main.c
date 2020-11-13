#include<stdio.h>

int main()
{
	
	int x = 10;
	int* xptr = &x;

	printf("Address of x : %p\n", &x);
	printf("Value of x : %d\n", x);

	printf("Address of xptr :%p\n", &xptr);
	printf("Value of xptr : %p\n", xptr);
	printf("Value of *xptr : %d\n", *xptr);


	printf("--------------------------\n");

	int iNum  = 100;
	int** p = &iNum;

	printf("iNum Value : %d\n", iNum);
	printf("iNum Address  : %p\n", &iNum);
	;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;.
	printf("p Value : %d\n", p);
	printf("p Address  : %p\n", &p);
	printf("p Address  : %d\n", *p);

	////////////////////////////////////////////////////////////

	printf("iNum Value : %d\n", iNum);
	printf("*&iNum  : %d\n", *&iNum);

	printf("*p Value : %d\n", *p);
	printf("iNum : %d\n", iNum);
	printf("*&iNum  : %d\n", *&iNum);
	printf("p  : %p\n", p);
	printf("*&p  : %p\n", *&p);

	return 0;
}