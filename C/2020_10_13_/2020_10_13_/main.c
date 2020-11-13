#include<stdio.h>
#pragma warning(disable: 4996)

int main(void)
{
	int iNum = 100;
	char cNum = 100;
	short sNum = 100;
	iNum = 200;
	*((int*)0x0019FEDC) = 300;			//*()안에 넣어라
	printf("%d\n", iNum);

	



	return 0;
}

	
	

