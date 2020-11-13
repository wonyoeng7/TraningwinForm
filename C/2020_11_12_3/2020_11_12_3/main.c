#include <stdio.h>
#include <stdlib.h>  // malloc
#include "book.h"
#define LINKED_LIST_TEST 1

void ttttt(Book** Head, Book* Item)
{
	Book* Pre = Head;
	Book* Back = Head;

	if (0 == Head)
	{
		return;
	}
	if (0 == Item)
	{
		return;
	}
	if (0 == *Head)	//연결리스트 하나도 없는 경우
	{
		*Head = Item;		//1111
		return;
	}

	// 검색 루프 //슈도 코드
	while (0 != Pre)
	{
		if (strcmp(Pre->Name,Item->Name))	//위치 찾았으면
		{
			break;
		}
		Back = Pre;
		Pre = Pre->Next;
	}
	// 삽입 코드 //
	if (Back == Pre)
	{
		Item->Next = Pre;
		*Head = Item;
	}
	Item->Next = Pre;
	Back->Next = Item;
}

int main(void)
{
  Book* Head = 0;
  Book* Temp;

  Temp = NodeBook("책 1111", 2000);
  ttttt(&Head, Temp);
  Temp = NodeBook("책 2222", 2001);
  insertBook(&Head, Temp);
  Temp = NodeBook("책 4444", 2003);
  insertBook(&Head, Temp);
  
  printBookList(Head);

  Temp = NodeBook("책 3333", 2002);
  ttttt(&Head, Temp);

  printBookList(Head);
  FreeBook(Head);

 
  return 0;
}

int main1(void)
{
  Book aBook1 = { "책 1111", 2000 };
  Book aBook2 = { "책 2222", 2001 };
  Book aBook3 = { "책 3333", 2002 };
  Book aBook4 = { "책 4444", 2003 };

  aBook1.Next = &aBook2;
#if LINKED_LIST_TEST
  aBook2.Next = &aBook4;
#else
  aBook2.Next = &aBook3;
  aBook3.Next = &aBook4;
#endif

  printf("[%s]->", aBook1.Name);
  printf("[%s]->", aBook1.Next->Name);
  printf("[%s]->", aBook1.Next->Next->Name);
#if !LINKED_LIST_TEST
  printf("[%s]->", aBook1.Next->Next->Next->Name);
#endif
  printf("NULL\n");

  return 0;
}