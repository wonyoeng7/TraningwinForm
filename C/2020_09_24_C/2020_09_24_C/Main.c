#include<stdio.h>

int main(void)
{
	int input, change;		//input�� ���Ծ�,change�� �ܵ��� ������ ����
	int w500, w100, w50, w10;		//�� ������ ������ ������ ����
	printf("���� �Է��ϼ���:");
	scanf("%d", &input);
	change = input - 150;		//Ŀ�ǰ��� 150���� �� �ܵ� ���
	w500 = change / 500;		//500�� ������ ����
	change = change % 500;		//���� �������� ���� ���� �ܵ�
	w100 = change / 100;
	change = change % 100;
	w50 = change / 50;
	change = change % 50;
	w10 = change / 10;
	printf("500��¥�� ���� %d��\n", w500);
	printf("100��¥�� ���� %d��\n", w100);
	printf("50��¥�� ���� %d��\n", w50);
	printf("10��¥�� ���� %d��\n", w10);

}