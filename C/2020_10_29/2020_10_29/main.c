#include<stdio.h>
#define MAX_STD 5		//MAX_STD을 5로 정의 한다.
#define NAME_LEN 25		//NAME_LEN을 25로 정의 한다.

int main2()
{
	int arr1[2][4] = { 1,2,3,4,5,6,7,8 };
	int arr2[4][2];
	int idx, jdx;

	for (idx =  0; idx != 2; idx++)
	{
		for (jdx = 0 ; jdx != 4; jdx++)
		{
			arr2[jdx][idx] = arr1[idx][idx];
		}
	}
	
	for (idx = 0; idx != 4 ; idx++)
	{
		for (jdx = 0; jdx != 2  ; jdx++)
		{
			printf("%4d", arr2[idx][jdx]);
		}
		printf("\n");

	}

	return 0;

}


int main()
{
	char* season[4] = { "Spring","Summer","Fall","Winter" };
	int idx;

	for (idx = 0; idx != 4; idx++)
	{
		printf("%s\n", season[idx]);

	}
	return 0;
}
/*
int main1()
{
	char stdbuf[MAX_STD][NAME_LEN] = { 0, };	//문자열 배열
	char* strptr[MAX_STD];		// char형을 가리키는 포인터 배열
	char* temp = NULL;

	int idx = 0, jdx;

	puts("학생 이름 입력 : ");		//문자열만 출력하는 기능만 가지고 있다.

	while (idx != MAX_STD)
	{
		fflush(stdin);
		fgets(stdbuf[idx], sizeof(stdbuf[idx], stdin));
		gets(stdbuf[idx]);
		strptr[idx++] = stdbuf[idx];
	}
	//* 문자열 오름차순 정렬 */
/*
	for (idx = 0; idx < MAX_STD - 1; idx++)
	{
		for(jdx =idx + 1; jdx < MAX_STD ; jdx++)
		{
			if (strcmp(strptr[idx], strptr[jdx] > 0))
			{
				temp = strptr[jdx];
				strptr[jdx] = strptr[idx];
				strptr[idx] = temp;
			}
		}

		puts("--학생 리스트 --");
		for(idx = 0; idx != MAX_STD ;idx++)
		{
			printf("[%d] %s\n", idx + 1, strptr[idx]);
		}
		return 0;
	}
	
}
*/