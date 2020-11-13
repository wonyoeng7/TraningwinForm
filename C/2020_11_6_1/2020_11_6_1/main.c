#include<stdio.h>
#define MAX_INFO 3

struct PlMS
{
	char m_name[20];
	char m_tel[20];
};

int main()
{
	struct PIMS pArray[MAX_INFO];
	int idx;

	for (idx = 0; idx != MAX_INFO ;idx++)
	{
		printf("이름, 전화번호 순으로 입력: \n");
		scanf("%19s %19s", pArray[idx].m_name, pArray[idx].m_tel);
	}

	for (idx = 0; idx != MAX_INFO ; idx++)
	{
		printf("이름 : %-19s,전화순으로 입력: \n");
		scanf("%19s %19s", pArray[idx].m_name, pArray[idx].m_tel);
	}
}