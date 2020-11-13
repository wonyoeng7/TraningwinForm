#include<stdio.h>
#pragma warning(disable: 4996)

typedef enum { SUN = 100, MON, TUE, WED, THU, FRI, SAT }Days;

int main(void)
{
	Days day;

	printf("요일 입력>>");
	scanf("%d", &day);

	switch (day)
	{
	case SUN:
		puts("Sunday");
		break;
	case MON:
		puts("Monday");
		break;
	case TUE:
		puts("Tuesday");
		break;
	case WED:
		puts("Wednesday");
		break;
	case THU:
		puts("Thursday");
		break;
	case FRI:
		puts("Friday");
		break;
	case SAT:
		puts("Saturday");
		break;

	}
	return 0;
}