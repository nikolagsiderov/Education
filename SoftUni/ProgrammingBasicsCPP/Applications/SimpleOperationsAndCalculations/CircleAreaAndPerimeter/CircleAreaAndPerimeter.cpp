// CircleAreaAndPerimeter.cpp : Defines the entry point for the console application.
//

#define _USE_MATH_DEFINES

#include "stdafx.h"
#include <iostream>
#include <string>
#include <math.h>

using namespace std;


int main()
{
	double radius;

	cin >> radius;

	double perimeter = 2 * M_PI * radius;
	double area = M_PI * radius * radius;

	cout << area << endl << perimeter << endl;

    return 0;
}

