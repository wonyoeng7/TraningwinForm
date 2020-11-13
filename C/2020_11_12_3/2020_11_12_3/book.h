
typedef struct _book
{
	char Name[50];
	int Price;
	char Date[20];
	struct _book* Next;

}Book;