#include<stdio.h>
#pragma warning(disable: 4996)


int main()
{
	int idx;
	char ch;			//�������ϴ� ����, �ӽ� ����� ������
	char str[9] = { "Rotation" };

	printf("-- ���� �� ���ڿ� --\n");
	printf("%s\n", str);

	for (idx = 0; idx != 9; idx++)
	{
		printf("%c | ", str[idx]);
	}
	for (idx = 0; idx != 4; idx++)
	{
		ch = str[7 - idx];
		str[7 - idx] = str[idx];
		str[idx] = ch;
	}

	printf("\n-- ���� �� ���ڿ� --\n");
	printf("%s\n", str);
	return 0;
}
