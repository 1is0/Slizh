// ---------------------------------------------------------------------------

#ifndef StackH
#define StackH
#include <iostream>
#include<vector>
#include <string>
using namespace std;

class Stack {
	char stack[100];
	int counter;

public:
	bool IsEmpty();

	Stack() {
		counter = 0;
	};
	char GetCount();
	char Pop();
	void Push(char par);
	int PriorityOfSignes(char tmp);

	int Count_Priority();
};

class DecodingOfStack {
	int counter;
	vector<double>sum;

public:
	float a, b, c, d, e;

	DecodingOfStack() {
		counter = 0;
		a = b = c = d = e = 0;
	};
	void Push(double par);
	void Pop();
	double GetTopElement();
	double Calculating(const string& pnote);
	string OPZ(const char(&note)[100]);
};
// ---------------------------------------------------------------------------
#endif
