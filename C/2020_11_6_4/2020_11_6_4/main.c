//공용체 예제
#include<stdio.h>

typedef union MyUnion
{
	int a;
	short b;
	char c;
	char d = d[4];
}MyUnion;

int main()
{
	MyUnion aMyUnion;
	aMyUnion.a = 0x12345678;
	//aMyUnion.b = 0x3333;
	//aMyUnion.c = 0x22;

	printf("aMyUnion.a : [%p]\n", aMyUnion.a);
	printf("aMyUnion.a : [%p]\n", aMyUnion.b);
	printf("aMyUnion.a : [%p]\n", aMyUnion.c);
	printf("aMyUnion.d[0] : [%p]\n", aMyUnion.d);
	printf("aMyUnion.d[1] : [%p]\n", aMyUnion.d);
	printf("aMyUnion.d[2] : [%p]\n", aMyUnion.d);
	printf("aMyUnion.d[3] : [%p]\n", aMyUnion.d);

	return 0;
}