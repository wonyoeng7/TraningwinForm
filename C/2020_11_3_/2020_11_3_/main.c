#include<stdio.h>
#define MAX_STD 5		//MAX_STD�� 5�� ���� �Ѵ�.
#define NAME_LEN 25		//NAME_LEN�� 25�� ���� �Ѵ�.


int main1()
{
	char stdbuf[MAX_STD][NAME_LEN] = { 0, };	//���ڿ� �迭
	char* strptr[MAX_STD];		// char���� ����Ű�� ������ �迭
	char* temp = NULL;

	int idx = 0, jdx;

	puts("�л� �̸� �Է� : ");		//���ڿ��� ����ϴ� ��ɸ� ������ �ִ�.

	while (idx != MAX_STD)
	{
		fflush(stdin);
		fgets(stdbuf[idx], sizeof(stdbuf[idx], stdin);
		gets(stdbuf[idx]);
		strptr[idx++] = stdbuf[idx];
	}
	//* ���ڿ� �������� ���� *
	for (idx = 0; idx < MAX_STD - 1; idx++)
	{
		for (jdx = idx + 1; jdx < MAX_STD; jdx++)
		{
			if (strcmp(strptr[idx], strptr[jdx] > 0))
			{
				temp = strptr[jdx];
				strptr[jdx] = strptr[idx];
				strptr[idx] = temp;
			}
		}

		puts("--�л� ����Ʈ --");
		for (idx = 0; idx != MAX_STD; idx++)
		{
			printf("[%d] %s\n", idx + 1, strptr[idx]);
		}
		return 0;
	}
}
