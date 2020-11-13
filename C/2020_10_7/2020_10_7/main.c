#include<stdio.h>
#pragma warning(disable: 4996)

int main(void)
{
	goto TEST2;
	
TEST1:
	printf("1\n");
TEST2:
	printf("2\n");
	goto TEST1;


	return 0;
}