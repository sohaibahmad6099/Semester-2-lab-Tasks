#include <iostream>
#include <windows.h>
using namespace std;
void maze();
char getCharAtxy(short int x, short int y);
void gotoxy(int x, int y);
void movePlayerDown();
void movePlayerUp();
void movePlayerRight();
void movePlayerLeft();
void moveEnemy(string direction);
string changeDirection(string direction);
void moveEnemy_2(string direction);
string changeDirection_2(string direction);
int eX = 128;
int eY = 3;
int pX = 3;
int pY = 3;
int eX_2 = 100;
int eY_2 = 6;

int main()
{

    string enemyDirection_enemey_2 = "right";
    string enemyDirection = "up";
    system("cls");
    maze();
    gotoxy(3, 3);
    cout << 'P';
    while (true)
    {
        if (GetAsyncKeyState(VK_LEFT))
        {
            movePlayerLeft();
        }
        if (GetAsyncKeyState(VK_RIGHT))
        {
            movePlayerRight();
        }
        if (GetAsyncKeyState(VK_UP))
        {
            movePlayerUp();
        }
        if (GetAsyncKeyState(VK_DOWN))
        {
            movePlayerDown();
        }

        moveEnemy(enemyDirection);
        enemyDirection = changeDirection(enemyDirection);
        moveEnemy_2(enemyDirection_enemey_2);
        enemyDirection_enemey_2 = changeDirection_2(enemyDirection_enemey_2);
        Sleep(300);
    }
    return 0;
}
void maze()
{
    cout << "########################################################################################################################################" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "#                                                                                                                                      #" << endl;
    cout << "########################################################################################################################################" << endl;
}
void movePlayerLeft()
{
    if (getCharAtxy(pX - 1, pY) == ' ' && getCharAtxy(pX - 1, pY) != '#')
    {
        gotoxy(pX, pY);
        cout << " ";
        pX = pX - 1;
        gotoxy(pX, pY);
        cout << "P";
    }
}

void movePlayerRight()
{
    if (getCharAtxy(pX + 1, pY) == ' ' && getCharAtxy(pX + 1, pY) != '#')
    {
        gotoxy(pX, pY);
        cout << " ";
        pX = pX + 1;
        gotoxy(pX, pY);
        cout << "P";
    }
}

void movePlayerUp()
{
    if (getCharAtxy(pX, pY - 1) == ' ' && getCharAtxy(pX, pY - 1) != '#')
    {
        gotoxy(pX, pY);
        cout << " ";
        pY = pY - 1;
        gotoxy(pX, pY);
        cout << "P";
    }
}

void movePlayerDown()
{
    if (getCharAtxy(pX, pY + 1) == ' ' && getCharAtxy(pX, pY + 1) != '#')
    {
        gotoxy(pX, pY);
        cout << " ";
        pY = pY + 1;
        gotoxy(pX, pY);
        cout << "P";
    }
}

char getCharAtxy(short int x, short int y)
{
    CHAR_INFO ci;
    COORD xy = {0, 0};
    SMALL_RECT rect = {x, y, x, y};
    COORD coordBufSize;
    coordBufSize.X = 1;
    coordBufSize.Y = 1;
    return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), &ci, coordBufSize, xy, &rect) ? ci.Char.AsciiChar : ' ';
}

void gotoxy(int x, int y)
{
    COORD coordinate;
    coordinate.X = x;
    coordinate.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinate);
}

void moveEnemy(string direction)
{
    gotoxy(eX, eY);
    cout << " ";
    if (direction == "up" && getCharAtxy(eX, eY - 1) != '#')
    {
        eY = eY - 1;
    }
    if (direction == "down" && getCharAtxy(eX, eY + 1) != '#')
    {
        eY = eY + 1;
    }
    gotoxy(eX, eY);
    cout << "Q";
}

string changeDirection(string direction)
{
    if (direction == "up" && eY <= 1)
    {
        direction = "down";
    }
    if (direction == "down" && eY >= 30)
    {
        direction = "up";
    }
    return direction;
}

void moveEnemy_2(string direction)
{
    gotoxy(eX_2, eY_2);
    cout << " ";
    if (direction == "right" && getCharAtxy(eX_2 + 1, eY_2) != '#')
    {
        eX_2 = eX_2 + 1;
    }
    if (direction == "left" && getCharAtxy(eX_2 - 1, eY_2) != '#')
    {
        eX_2 = eX_2 - 1;
    }
    gotoxy(eX_2, eY_2);
    cout << "Q";
}

string changeDirection_2(string direction)
{
    if (direction == "right" && eX_2 >= 134)
    {
        direction = "left";
    }
    if (direction == "left" && eX_2 <= 2)
    {
        direction = "right";
    }
    return direction;
}