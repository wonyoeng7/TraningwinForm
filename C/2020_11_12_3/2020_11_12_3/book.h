
typedef struct _book
{
	char Name[50];
	int Price;
	char Date[20];
	struct _book* Next;

}Book;

void FreeBook(Book* Head);
void printBook(Book* Head);
void printBookList(Book* Head);
Book* NodeBook(char*, int);
void insertBook(Book**, Book*);