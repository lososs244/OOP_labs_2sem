#include <iostream>
#include <cmath>
#include <string>;
using namespace std;

class Expression
{
private:
	double a, c, d;
	double rez;
public:
	Expression(double a, double c, double d)     
	{
		this->a = a;
		this->c = c;
		this->d = d;
	}
	Expression() {};

	double solve()
	{

		double rez1 = 2 * c - d / 23;    
		double rez2 = log(1 - a / 4);    

		if (1 - a / 4 <= 0)
		{
			throw "Logarythmic function value error";    
		}
		if (rez2 == 0)
		{
			throw "Dividing by zero error";   
		}
		return rez = rez1 / rez2;
	}
};


int main()
{
	setlocale(LC_ALL, "rus");

	cout << "Group IS-92\nMinyailov Oleg" << endl;

	Expression expressions[4];
	expressions[0] = Expression(2, 4, 3);
	expressions[1] = Expression(0, 0.5, 23);  //ex
	expressions[2] = Expression(4, 3, 5);  //ex
	expressions[3] = Expression(1, 1, 1);
	int i = 0;
	for (Expression element : expressions)
	{
		i++;
		try
		{
			cout << "expression № " << i << ":  " << element.solve() << endl; 
		}
		catch (const char* mes)
		{
			cout << mes << endl;   
		}

	}

}
