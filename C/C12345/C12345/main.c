#include<stdio.h>

#define CALL 24		//����� �Ҽ��� �ڸ��� - 1

int count;			//binaryConvert2() ȣ�� Ƚ��

double f;                    //�����Ƽ� �̷��� ����....



//�Է��� 10������ ���� �κ��� 2������ ��ȯ�ϴ� �Լ�

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



//�Է��� 10������ �Ҽ� �κ��� 2������ ��ȯ�ϴ� �Լ�

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

