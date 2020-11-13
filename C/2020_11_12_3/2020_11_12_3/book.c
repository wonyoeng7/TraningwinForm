#include "book.h"


void FreeBook(Book* Head)
{
    Book* Temp = Head;
    while (0 != Head)
    {
        Temp = Head->Next;
        free(Head);
        Head = Temp;
    }

}

void printBook(Book* Head)
{
    printf("책 이름 : [%s]\n", Head->Name);
    printf("책 가격 : [%d]\n", Head->Price);
}
void printBookList(Book* Head)
{
    while (0 != Head)
    {
        printBook(Head);
        Head = Head->Next;
    }
}


Book* NodeBook(char* Name, int Price)
{
    Book* Temp = malloc(sizeof(Book));
    if (0 != Temp)
    {
        return;
    }
    strcpy(Temp->Name, Name);
    Temp->Price = Price;
    Temp->Next = 0;
}

void insertBook(Book** Head, Book* Item)
{
    Book* bTemp = *Head;

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
    while (0 != bTemp->Next)
    {
        bTemp = bTemp->Next;
    }
    bTemp->Next = Item;
}


