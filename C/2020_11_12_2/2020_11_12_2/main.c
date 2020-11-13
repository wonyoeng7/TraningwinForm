#include <stdio.h>
#pragma warning(disable: 4996)

#define PI 3.141592
#define SQUARE(x) ((x)*(x))

int main(void)
{
  double radius;
  printf("반지름을 입력하세요 : \n");
  scanf("%lf", &radius);
  printf("원의 면적은 : %.2lf\n", PI * SQUARE(radius));
  
  return 0;
}