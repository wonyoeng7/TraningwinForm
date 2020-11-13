#include<stdio.h>
#pragma warning(disable: 4996)


int main()
{
	int idx;
	char ch;			//스와핑하는 변수, 임시 저장소 같은곳
	char str[9] = { "Rotation" };

	printf("-- 변경 전 문자열 --\n");
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

	printf("\n-- 변경 후 문자열 --\n");
	printf("%s\n", str);
	return 0;
}
