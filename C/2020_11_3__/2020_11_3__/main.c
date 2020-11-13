#include <stdio.h>

int main()
{
    char Original[5][6] = {
      "apple",
      "Apple",
      "APple",
      "APPLe",
      "APPLE"
    };
    char* Pointer[5];
    char* Temp;

    int iCount1;
    int iCount2;

    for (iCount1 = 0; iCount1 < 5; ++iCount1)
    {
        Pointer[iCount1] = Original[iCount1];
        printf("[%s]\n", Pointer[iCount1]);
    }

    for (iCount1 = 0; iCount1 < 4; ++iCount1)
    {
        for (iCount2 = iCount1 + 1; iCount2 < 5; ++iCount2)
        {
            if (strcmp(Pointer[iCount1], Pointer[iCount2]) > 0)
            {
                Temp = Pointer[iCount2];
                Pointer[iCount2] = Pointer[iCount1];
                Pointer[iCount1] = Temp;
            }
        }
    }

    for (iCount1 = 0; iCount1 < 5; ++iCount1)
    {
        printf("[%s]\n", Pointer[iCount1]);
    }
    for (iCount1 = 0; iCount1 < 5; ++iCount1)
    {
        printf("[%s]\n", Original[iCount1]);
    }

    return 0;
}