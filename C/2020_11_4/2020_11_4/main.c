#include<stdio.h>
#include<string.h>

int b1 = 101;       //DATA에 존재 
int b2;             //BSS에 존재   
int b3 = 103;       
int b4;             //B
int b5 = 105;
//char TTTT[1024 * 1024] = { 'a' };
//파일 크기에 영향을 미친다. 전역변수는 컴파일할때 만든다. 그래서 파일에 저장된다. 그래서 전역변수는 되도록 쓰지 않는다.
//

int main()
{
    int a1 = 101;
    int a2 = 102;
    int a3 = 103;
    int a4 = 104;
    int a5 = 105;

    printf("Stack Address : %p\n", &a1);
    printf("Stack Address : %p\n", &a2);
    printf("Stack Address : %p\n", &a3);
    printf("Stack Address : %p\n", &a4);
    printf("Stack Address : %p\n", &a5);

    printf("=========================\n");

    printf("Code Address : %p\n", main);
    printf("Code Address : %p\n", printf);
    printf("Code Address : %p\n", "ABC");

    printf("=========================\n");

    printf("Data Address : %p\n", &b1);
    printf("Data Address : %p\n", &b2);
    printf("Data Address : %p\n", &b3);
    printf("Data Address : %p\n", &b4);
    printf("Data Address : %p\n", &b5);




    return 0;
}













