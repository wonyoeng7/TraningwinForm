#include<stdio.h>

int main()
{

	float fnum1 = 3.125f;
	float fnum2 = 5.0625f;
	float fnum3 = 523.6;
	char* P = (char*)&fnum3;

	printf("%f\n", fnum1);
	printf("%f\n", fnum2);
	printf("%f\n", fnum3);

	*P = 0X00;
	++P;
	*P = 0X00;
	++P;
	*P = 0X48;
	++P;
	*P = 0X40;

	printf("%f\n", fnum3);
	return 0;

}