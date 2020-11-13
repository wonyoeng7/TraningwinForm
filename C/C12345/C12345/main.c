#include<stdio.h>

#define CALL 24		//출력할 소수점 자리수 - 1

int count;			//binaryConvert2() 호출 횟수

double f;                    //귀찮아서 이렇게 선언....



//입력한 10진수의 정수 부분을 2진수로 변환하는 함수

void binaryConvert(int data) {

	if (data == 1) {

		printf("1");

	}

	else if (data == 0) {

		printf("0");

	}

	else {

		binaryConvert(data / 2);

		printf("%d", data % 2);

	}

}



//입력한 10진수의 소수 부분을 2진수로 변환하는 함수

void binaryConvert2(double data) {

	count++;

	if (count == CALL) {

		return;

	}

	else {

		if (data < f) {

			f /= 2;

			printf("0");

			binaryConvert2(data);

		}

		else if (data > f) {

			data -= f;

			f /= 2;

			printf("1");

			binaryConvert2(data);

		}

		else {

			printf("1");

		}



	}

}

int main(void) {

	double inputData;

	int intData;

	double doubleData;

	while (1) {

		count = 0;

		f = 0.5;

		printf("\nDecimal Number => ");

		scanf_s("%lf", &inputData, sizeof(double));

		if (inputData == 0) {

			break;

		}

		intData = (int)inputData;

		doubleData = inputData - intData;

		printf("Binary Number  => ");

		binaryConvert(intData);

		printf(".");

		binaryConvert2(doubleData);

		printf("\n==================================================\n");

	}

}

