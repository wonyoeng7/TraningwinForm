#include<stdio.h>

int main(void)
{
	int input, change;		//input은 투입액,change는 잔돈을 저장할 변수
	int w500, w100, w50, w10;		//각 동전의 개수를 저장할 변수
	printf("돈을 입력하세요:");
	scanf("%d", &input);
	change = input - 150;		//커피값이 150원일 때 잔돈 계산
	w500 = change / 500;		//500원 동전의 개수
	change = change % 500;		//아직 지급하지 못한 남은 잔돈
	w100 = change / 100;
	change = change % 100;
	w50 = change / 50;
	change = change % 50;
	w10 = change / 10;
	printf("500원짜리 동전 %d개\n", w500);
	printf("100원짜리 동전 %d개\n", w100);
	printf("50원짜리 동전 %d개\n", w50);
	printf("10원짜리 동전 %d개\n", w10);

}