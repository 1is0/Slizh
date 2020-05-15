//---------------------------------------------------------------------------
#include <vcl.h>
#ifndef HashTableH
#define HashTableH
#include <string>
#include "Form.h"
class Stack
{
	public:
		Stack* next;
		int key, num;

		//ctor
		Stack(int kii, int nimber)
		{
			next = NULL;
			key = kii;
			num = nimber;
		}
};

class HashT
{
	const int size = 5;

public:
	Stack **arr;
	int HashFun(int);
	void Creating();
	void Add (int, int);
	int Deleting(int);
	void Showing(TMemo*);
	Stack* Search(int);
	Stack* FindStack(int &);
};
//---------------------------------------------------------------------------
#endif
