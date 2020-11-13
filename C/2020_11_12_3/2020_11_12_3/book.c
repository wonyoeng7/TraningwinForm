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
    printf("å �̸� : [%s]\n", Head->Name);
    printf("å ���� : [%d]\n", Head->Price);
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
    if (0 == *Head)	//���Ḯ��Ʈ �ϳ��� ���� ���
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


