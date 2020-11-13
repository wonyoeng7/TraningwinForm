#include<stdio.h>
#include <stdlib.h>
#include"book.h"
#define LINKED_LIST_TEST 1


int main(void)
{
	char* test = "책 1111";
	Book* Head;
	Head = (Book*)malloc(sizeof(Book));
	if (Head != 0)
	{
		strcpy(Head->Name,test);
		//scanf_s("%s", Head->Name, sizeof(Head->Name));
		Head->Price = 2000;
		Head->Next = (Book*)malloc(sizeof(Book));
		strcpy(Head->Next->Name, "책 2222");
		Head->Next->Price = 2001;

	}

	printf("책 이름 : [%s]\n", Head->Name);
	printf("책 가격 : [%s]\n", Head->Price);

	free(Head);

	return 0;

}
int main1(void)
{
	Book aBook1 = {"책 1111",2000};
	Book aBook2 = {"책 2222",2001};
	Book aBook3 = {"책 3333",2002};
	Book aBook4 = {"책 4444",2003};

	aBook1.Next = &aBook2;
#if 1
	aBook2.Next = &aBook4;
#else
	aBook3.Next = &aBook3;
	aBook3.Next = &aBook4;
#endif

	printf("[%s]->", aBook1.Name);
	printf("[%s]->", aBook1.Next->Name);
	printf("[%s]->", aBook1.Next->Next->Name);
	printf("[%s]->", aBook1.Next->Next->Next->Name);
	printf("NULL\n");
	
	return 0;

}