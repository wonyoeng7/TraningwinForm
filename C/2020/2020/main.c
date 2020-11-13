#include <stdio.h>

int Add(int, int);
int Input(void);
void PrintResult(int);
void Intro(void);

int main(void)
{
	int a, b;
	int ret;

	Intro();
	a = Input();
	b = Input();

	ret = Add(a, b);
	PrintResult(ret);
	return 0;
}
