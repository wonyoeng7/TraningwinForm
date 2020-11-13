#include<stdio.h>


int main(void)
{
	int num;
	char ch;
	float fnum;

	printf("세 개의 값을 입력하시오 : [정수][문자][실수]\n");

	scanf("%d %c %f", &num, &ch, &fnum);

	printf("입력에 대한 출력 : [정수 = %d ] [문자 = %5c][실수 = f]\n", num, ch, fnum);
	
	return 0;
}
