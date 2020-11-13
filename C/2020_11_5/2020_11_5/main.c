#include<stdio.h>
#include<string.h>
#pragma warning(disable: 4996)

#define MAX_NAME 20

struct STUDENT
{
	char m_name[MAX_NAME];
	int m_eng;
	int m_math;
	float m_average;
};

int main()
{
	struct STUDENT std;
	int iTemp;

	printf("Please enter student name :");
	//scanf("%19s",std.m_name);
	//gets(std.m_name, MAX_NAME, stdin);
	fgets(std.m_name, MAX_NAME,stdin);
	iTemp = strlen(std.m_name);
	//std.m_name[iTemp - 1] = 0;
	std.m_name[strlen(std.m_name) - 1] = 0;


	printf("Please enter english score :");
	fflush(stdin);
	scanf_s("%d", &std.m_eng);

	printf("Please enter math score :");
	fflush(stdin);
	scanf_s("%d", &std.m_math);

	std.m_average = (float)(std.m_eng + std.m_math) / 2;

	printf("stdent name : %s\n", std.m_name);
	printf("average : %6.3f\n", std.m_average);

	return 0;
}
