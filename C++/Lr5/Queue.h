// ---------------------------------------------------------------------------

#ifndef QueueH
#define QueueH
#include <string>

class Node {
public:
	int number;
	Node *prev; // pointer ont previous element
	Node *next; // pointer on next element

	Node() // default ctor
	{
		number = 0;
		prev = NULL;
		next = NULL;
	}
};

class List {
	public:
	Node *head; // pointer on head of list
	Node *tail; // pointer on tail of list
	int curr, max, min, size;

	List() // default ctor
	{
		head = NULL;
		tail = NULL;
		size = min = max = 0;
		curr = -1;

	}

	~List() {
		if (head) {
			head->prev = NULL;
		}
		if (tail) {
			tail->next = NULL;
		}
		while (head != NULL) {
			Node *tmp = head->next;
			delete head;
			head = tmp;
		}
	}
	void Add(int);
	void Delete();
	int TakeMin();
	int TakeMax();
	int TakeNumber(int);

};

class Queue : public List
{
	public:
		Node* currNode;
		Queue() : List()
		{
			currNode = NULL;
		}
		int Display();
		void TakeCurr();
		void Back();
};
#endif
