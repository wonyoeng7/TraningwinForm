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

	printf("문자열 입력:");
	scanf("%s", str);

	for (idx = 0; str[idx] != '\n'; idx++)
	{
		if (big_ch < str[idx])
			big_ch = str[idx];
	}
	printf("입력된 문자열 : %s\n", str);
	printf("아스키 코드값이 가장 큰 문자 : %c\n", big_ch);

	return 0;
}

int main1()
{

	int numbers[5] = { 10,20,30,40,50 };

	int* pNum = numbers;	//배열이 이름이 주소이다.

	printf("%d\n", *pNum);

	printf("%d\n", *(++pNum));		//포인터를 이동시키면서 출력하는 방법
	printf("%d\n", *(++pNum));		//포인터에 더해서 출력하는 방법
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