// SquareOfStars.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;


int main()
{
	int inputParameter;

	cin >> inputParameter;

	for (int i = 0; i < inputParameter; i++)
	{
		cout << "*";
	}
	cout << endl;

	for (int i = 0; i < inputParameter-2; i++)
	{
		cout << "*";

		for (int i = 0; i < inputParameter-2; i++)
		{
			cout << " ";
		}

		cout << "*" << endl;
	}

	for (int i = 0; i < inputParameter; i++)
	{
		cout << "*";
	}
	cout << endl;

    return 0;
}

