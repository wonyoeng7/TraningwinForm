#include<stdio.h>

// typedef �õ�Ÿ�� ��Ÿ��;
typedef unsigned int aaaa;

struct test 
{
	int a;
	int b;

};

typedef struct test TEST;

struct test1{int a; int b;};

typedef struct test1 { int a; int b; } test TEST1;

int main()
{
	struct test atest;
	TEST bTest;

	atest.a = 100;
	atest.b = 200;
	
	atest = bTest;

	return 0;
}





int main1()
{
	aaaa num = 100;		// unsigned int num = 100;
	printf("%d\n", num);

	return 0;

}