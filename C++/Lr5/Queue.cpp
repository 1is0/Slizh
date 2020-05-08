// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Queue.h"

void List::Add(int par) {
	Node *tmp = new Node();
	tmp->number = par;
	tmp->next = NULL;
	tmp->prev = tail;
	if (tail) {
		tail->next = tmp;
	}
	tail = tmp;
	if (!head) {
		head = tmp;
	}
	size++;
	curr++;
}

void List::Delete() {
	if (head) {
		head->prev = NULL;
	}
	if (tail) {
		tail->next = NULL;
	}
	while (head) {
		Node *tmp = head->next;
		delete tmp;
		head = tmp;
	}
	size = 0;
	tail = NULL;
}

int List :: TakeMin() {
	Node* pointer = head;
	int minimal = 100000000, i = 0;
	while (pointer != NULL) {
		if (pointer->number < min) {
			minimal = pointer->number;
			min = i;
		}
		i++;
		pointer = pointer->next;
	}
	return minimal;

}

int List :: TakeMax() {
	Node* pointer = head;
	int maximal = -10000000, i = 0;
	while (pointer != NULL) {
		if(pointer -> number > maximal){
			maximal = pointer -> number;
			max = i;
		}
		i++;
		pointer = pointer -> next;
	}
	return maximal;
}

//-------------------------------------------------------------

int Queue :: Display()
{
	int tmp = 0;
	if (currNode) {
		tmp = currNode -> number;
		currNode = currNode -> next;
	}
	return tmp;
}

void Queue :: TakeCurr()
{
	if (head) {
		currNode = head;
	}
	else
	{
		currNode = NULL;
	}
}

void Queue :: Back()
{
	if (head && tail) {
		head -> prev = tail;
		tail -> next = head;
	}
}

#pragma package(smart_init)
