// InchesToCentimeters.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;


int main()
{
	double inches;

	cin >> inches;

	double cm = inches * 2.54;

	cout << cm << endl;

    return 0;
}

