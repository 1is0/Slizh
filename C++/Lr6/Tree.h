// ---------------------------------------------------------------------------

#ifndef TreeH
#define TreeH
#include <string>
#include <Form.h>
using namespace std;

class Node {
public:
	string surname;
	int number;
	Node *left;
	Node *right;
};

class Tree {
public:
	Node *root;
	int numberOfNodes;

	Tree() {
		root = NULL;
		numberOfNodes = 0;
	}
	Node* MakingOfTree(string, int);
	Node* Add(Node* , string, int);
	int Counting(Node*);
	void Printing(Node* , TTreeView *, int &);
	void Showing(TTreeView *);
	void Direct(TMemo*, Node*);
	void Backward(TMemo*, Node*);
	void Key(TMemo*, Node*);
	void Clearing(Node *);
	void Deleting(int);
	AnsiString getPlayer(int);
};

// По заданию создаем дочерний класс для реализации варианта
class CalculatingInTree : public Tree {
public:
	int Count(Node* , int);
};

// ---------------------------------------------------------------------------
#endif
