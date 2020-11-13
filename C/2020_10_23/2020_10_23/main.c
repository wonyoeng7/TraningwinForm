#include<stdio.h>

int main()
{
	char* str = "ABCDEFG";		//포인터
	char arr[] = "ABCDEFG";		//배열
	
	printf("%c\n",str[0]);
	printf("%c\n",arr[0]);
	//str[0] = 'Z';
	arr[0] = 'Z';
	printf("str [%s]\n", str);
	printf("arr [%s]\n", arr);
	return 0;

}
// 변하지 않는거면 포인터로 만든다.100
// 변하는것이람녀 배열로 만드는 것이다.












int main2()
{
	int A = 100;
	int B = 200;
	int* p = &A;
	int iArray[2];


	printf("%d\n", *p);
	printf("%d\n", *(p + 0));
	printf("%d\n", p[0]);

	printf("-------------------------\n");
	p = &B;
	printf("%d\n", p[0]);

	return 0;
}










int main3()
{
	int A = 0X12345678;
	int iArray[5] = {100,101,102,103,104};
	int B = 0XABCDEF12;

	printf("%d\n", *(iArray + 0));
	printf("%d\n", *(iArray + 1));
	printf("%d\n", *(iArray + 2));
	printf("%d\n", *(iArray + 3));
	printf("%d\n", *(iArray + 4));
	printf("%p\n",iArray);

	return 0;

}

// 아스키코드로 한글을 만들수 없다.
// 배열의 이름을 적는것은 배열의 주소를 적는거다
// 변수는 스택구조에 영향을 받지만 배열은 스택구조의 영향을 받지 않는다.
// 배열의 이름은 주소 상수이다. (바꿀수 없다는 뜻이다.)
// 포인터 변수은 주소 변수이다.( 바뀐다는 의미이다.)ㄴ