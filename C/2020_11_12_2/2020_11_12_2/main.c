#include <stdio.h>
#pragma warning(disable: 4996)

#define PI 3.141592
#define SQUARE(x) ((x)*(x))

int main(void)
{
  double radius;
  printf("�������� �Է��ϼ��� : \n");
  scanf("%lf", &radius);
  printf("���� ������ : %.2lf\n", PI * SQUARE(radius));
  
  return 0;
}