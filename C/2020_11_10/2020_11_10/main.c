#include<stdio.h>
#pragma warning(disable: 4996)

int Add(int, int);
int Input(void);
void PrintResult(int);
void Intro(void);

int main(void)
{
	int a, b;
	int ret;

	Intro();
	a = Input();
	b = Input();

	ret = Add(a, b);
	PrintResult(ret);
	return 0;

}
int Add(int a, int b)
{
	return a + b;
}

int Input(void)
{
	int input;
	scanf("%d", &input);
	return input;
}

void PrintResult(int val)
{
	printf("������ ���� ��� : %d\n", val);
	printf("*********** END ************\n");
}

void Intro(void)
{
	printf("*********** START ************\n");
	printf("�� ���� ���� �Է� : \n");
	
}