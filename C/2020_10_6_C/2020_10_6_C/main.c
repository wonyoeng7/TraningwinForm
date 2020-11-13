#include<stdio.h>
#pragma warning(disable: 4996)

int main()
{
	unsigned char A = 1;
	unsigned int B = A;
	printf("A = %d\n", A);		//1바이트 1이고
	printf("B = %d\n", B);		//4바이트 1이다.

}
