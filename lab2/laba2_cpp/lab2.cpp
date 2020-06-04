#include <iostream>
#include <vector>
#include <string>
#include "String.h"
#include "Text.h"

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	Text text;

	string line;
	int n, num;
	cout << "������ ���������� ������: ";
	cin >> n;

	for (int i = 0; i <= n; i++) {

		if (i != 0)
			cout << "������� " << i << "-�� �����: ";
		char* str;
		getline(cin, line);
		str = new char[line.length() + 1];
		strcpy_s(str, line.length() + 1, line.c_str());
		if (i != 0)
			text.add_line(str);
		line = "";
	}

	cout << "�����: " << endl;
	text.output_text();

	cout << "������� ������� ����i� : " << text.middle_length() << endl;
	cout << "������� �������� ����: " << text.vitsotok_holosnyh() << endl;

	cout << "������� ����� ������ ��� �������� : ";
	cin >> num;
	text.delete_line(num);
	cout << "�����: " << endl;
	text.output_text();

	text.clearing();

	cout << "����� ���������:" << endl;
	text.output_text();

	return 0;
}