#include "pch.h" // use stdafx.h in Visual Studio 2017 and earlier
#include <utility>
#include <limits.h>
#include "MathLib.h"

int Sum(int a, int b) {
	return a + b;
}


int Diff(int a, int b) {
	return a - b;
}

int Composition(int a, int b) {
	return a * b;
}

int Division(int a, int b) {
	return a / b;
}
int Fact(int a) {
	if (a < 0) return 0;
	else if (a == 0) return 1;
	else return a * Fact(a - 1);
}
int Module(int a) {
	if (a >= 0) return a;
	else return -a;
}
