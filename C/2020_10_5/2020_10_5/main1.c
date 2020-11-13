#include<stdio.h>
#pragma warning(disable: 4996)
int main()
{	
	int a = 0, b = 0;

	++a;
	b++;
	printf("a = %d, b = %d \n", a, b);

	b = a++;
	printf("a = %d, b = %d \n", a, b);

	b = ++a;
	printf("a = %d, b = %d \n", a, b);

	printf("a = %d, b = %d \n", a++, b++);
	printf("a = %d, b = %d \n", a, b);


	return 0;
}