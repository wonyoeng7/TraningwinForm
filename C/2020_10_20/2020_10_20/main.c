#include<stdio.h>

int main()
{

	int  iNum = 0x12345678;
	short* sp = &iNum;
	char* cp = &iNum;
	int* ip = &iNum;;

	printf("%08X\n", *sp);
	printf("%08X\n", *cp);
	printf("%08X\n", *ip);
	
	//sp·Î 3456Ãâ·Â

	sp = (short*)((char*)&iNum + 1);
	printf("%08X\n", *sp);

	//char* p = &iNum;
	//
	//printf("%02X\n", *p);
	//printf("%02X\n", *p+1);

	//
	//printf("%02X\n", *p + 0);
	//printf("%02X\n", *(p + 1));
	//printf("%02X\n", *(p + 2));
	//printf("%02X\n", *(p + 3));
	//printf("--------------------\n");
	//printf("%02X\n", *p++);
	//printf("%02X\n", *p++);
	//printf("%02X\n", *p++);
	//printf("%02X\n", *p++);
	//printf("--------------------\n");


	return 0;
}