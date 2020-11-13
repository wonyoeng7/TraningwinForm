#include<stdio.h>

int main()
{
	/*
	char ch, * pch;
	int inum, * pinum;
	float fnum, * pfnum;

	ch = 'a';
	inum = 0x1314;
	fnum = 25.3;

	pch = &ch;
	pinum = &inum;
	pfnum = &fnum;

	printf("ch : %5c,		*pch : %c\n", ch, *pch);
	printf("inum : %5x,		*pfnum : %5x\n", inum, *pinum);
	printf("fnum : %5.2f,		*pfnum : %5.2f\n", fnum, *pfnum);
	pch = (char*)pinum;
	printf("pch : %p,		*pch : %x\n", pch, *pch);
	pch++;
	printf("pch : %p,		*pch : %x\n", pch, *pch);
	*/

	/*printf("Pointer Size : %d\n", sizeof(char	*));
	printf("Pointer Size : %d\n", sizeof(int	*));
	printf("Pointer Size : %d\n", sizeof(double *));*/

	//메모리를 어떻게 해석할 것인가??
	int iNum = 0x123456AB;
	char* cp; 
	short* sp;
	int* ip;
	cp = (char*)&iNum;
	sp = (short*)&iNum;
	ip = &iNum;

	return 0;


}