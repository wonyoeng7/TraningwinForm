#include<stdio.h>


int main(void)
{
	int num;
	char ch;
	float fnum;

	printf("�� ���� ���� �Է��Ͻÿ� : [����][����][�Ǽ�]\n");

	scanf("%d %c %f", &num, &ch, &fnum);

	printf("�Է¿� ���� ��� : [���� = %d ] [���� = %5c][�Ǽ� = f]\n", num, ch, fnum);
	
	return 0;
}
