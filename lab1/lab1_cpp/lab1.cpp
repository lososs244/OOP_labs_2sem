#include <iostream>
#include <string>

using namespace std;

int inc(int num);
void inc_self(int &num);
bool ifmore(int, int);
void ifmore1(int, int);

int main(int argc, const char* argv[]) {
    
    int x = 63, c = -18, v = 92;
    int x1 = 88, x2 = 88, c1 = 34, c2 = 2, v1 = 23, v2 = 52;

    inc(x);
    cout << "\n";
    inc_self(x);
    cout << x;
    
    inc(c);
    cout << "\n";
    inc_self(c);
    cout << c;

    inc(v);
    cout << "\n";
    inc_self(v);
    cout << v << endl;

    ifmore(x1, x2);
    ifmore1(x1, x2);

    ifmore(c1, c2);
    ifmore1(c1, c2);

    ifmore(v1, v2);
    ifmore1(v1, v2);


    

    system("pause");
}



int inc(int num)
{
    int bit_mask = 1;
    while (num & bit_mask) {
        num = num ^ bit_mask;
        bit_mask <<= 1;
    }
    num = num | bit_mask;
    return num;
}

void inc_self(int &num)
{
    int bit_mask = 1;
    while (num & bit_mask) {
        num = num ^ bit_mask;
        bit_mask <<= 1;
    }
    num = num | bit_mask;
}

bool ifmore(int a, int b)
{
    int f = 0, z = 1;
    while (a)
    {
        if ((a & z) && !(b & z))
        {
            f = 1;
        }
        else if (!(a & z) && (b & z))
        {
            f = 0;
        }
        a = a >> 1;
        b = b >> 1;

    }
    if (!b && (f & 1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

void ifmore1(int a, int b)
{
    int f = 0, z = 1;
    while (a) 
    {
        if ((a & z) && !(b & z)) 
        {
            f = 1;
        }
        else if (!(a & z) && (b & z)) 
        {
            f = 0;
        }
        a = a >> 1;
        b = b >> 1;
        
    }
    if (!b && (f & 1))
    {
        cout << "true\n";
    }
    else
    {
        cout << "false\n";
    }
}