#include<stdio.h>

int main()
{
	char* str = "ABCDEFG";		//������
	char arr[] = "ABCDEFG";		//�迭
	
	printf("%c\n",str[0]);
	printf("%c\n",arr[0]);
	//str[0] = 'Z';
	arr[0] = 'Z';
	printf("str [%s]\n", str);
	printf("arr [%s]\n", arr);
	return 0;

}
// ������ �ʴ°Ÿ� �����ͷ� �����.100
// ���ϴ°��̶��� �迭�� ����� ���̴�.












int main2()
{
	int A = 100;
	int B = 200;
	int* p = &A;
	int iArray[2];


	printf("%d\n", *p);
	printf("%d\n", *(p + 0));
	printf("%d\n", p[0]);

	printf("-------------------------\n");
	p = &B;
	printf("%d\n", p[0]);

	return 0;
}










int main3()
{
	int A = 0X12345678;
	int iArray[5] = {100,101,102,103,104};
	int B = 0XABCDEF12;

	printf("%d\n", *(iArray + 0));
	printf("%d\n", *(iArray + 1));
	printf("%d\n", *(iArray + 2));
	printf("%d\n", *(iArray + 3));
	printf("%d\n", *(iArray + 4));
	printf("%p\n",iArray);

	return 0;

}

// �ƽ�Ű�ڵ�� �ѱ��� ����� ����.
// �迭�� �̸��� ���°��� �迭�� �ּҸ� ���°Ŵ�
// ������ ���ñ����� ������ ������ �迭�� ���ñ����� ������ ���� �ʴ´�.
// �迭�� �̸��� �ּ� ����̴�. (�ٲܼ� ���ٴ� ���̴�.)
// ������ ������ �ּ� �����̴�.( �ٲ�ٴ� �ǹ��̴�.)��