#include<stdio.h>
#pragma warning(disable: 4996)

int main3()
{
	int arry[5] = { 10,20,30,40,50 };
	int* ap = arry;
	int iCount;


	for (int iCount = 0; iCount < sizeof(arry)/sizeof(int); iCount++)
	{
		printf("%d \t", arry[iCount]);
	}
	printf("\n");

	for (int iCount = 0; iCount < 5; iCount++)
	{
		printf("%d \t", *(ap + iCount));
	}
	printf("\n");

	for (int iCount = 0; iCount < 5; iCount++)
	{
		printf("%d \t", ap[iCount]);
	}


	return 0;
}

int main2()
{
	char str[100];
	int nLen = 0, idx;
	char big_ch = 0;

	printf("���ڿ� �Է�:");
	scanf("%s", str);

	for (idx = 0; str[idx] != '\n'; idx++)
	{
		if (big_ch < str[idx])
			big_ch = str[idx];
	}
	printf("�Էµ� ���ڿ� : %s\n", str);
	printf("�ƽ�Ű �ڵ尪�� ���� ū ���� : %c\n", big_ch);

	return 0;
}

int main1()
{

	int numbers[5] = { 10,20,30,40,50 };

	int* pNum = numbers;	//�迭�� �̸��� �ּ��̴�.

	printf("%d\n", *pNum);

	printf("%d\n", *(++pNum));		//�����͸� �̵���Ű�鼭 ����ϴ� ���
	printf("%d\n", *(++pNum));		//�����Ϳ� ���ؼ� ����ϴ� ���
	printf("%d\n", *(pNum + 1));
	printf("%d\n", *(pNum + 2));

	return 0;
}

int main()
{
	char buffer[] = "tusyeabb  earyac kuxoey";
	char* p;
	p = buffer + sizeof(buffer) - 2;
	printf("%d", p);
	
	while (buffer <= p)
	{
		printf("%c", *p);
		p -= 2;

	}
	
	printf('\n');
	return 0;

}