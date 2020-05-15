// ---------------------------------------------------------------------------

#pragma hdrstop

#include "HashTable.h"

int HashT::HashFun(int tmp) {
	if (!tmp)
		return tmp % size + 10;
	else
		return tmp % size;
}

void HashT::Creating() {
	arr = (Stack * *)calloc(size, sizeof(Stack));
	for (int i = 0; i < size; i++) {
		arr[i] = (Stack*)calloc(1, sizeof(Stack));
		arr[i] = NULL;
	}
}

void HashT::Add(int a, int b) {
	int tmp = HashFun(a);
	if (!arr[tmp])
		arr[tmp] = new Stack(a, b);
	else {
		Stack *temp = arr[tmp];
		while (temp->next)
			temp = temp->next;
		temp->next = new Stack(a, b);
	}
}

int HashT::Deleting(int numer) {
	int i = HashFun(numer);
	int res = 0;
	Stack *pd, *temp = NULL;
	for (pd = arr[i]; pd; pd = pd->next) {
		if (pd->key == numer) {
			if (!temp) {
				arr[i] = pd->next;
			}
			else {
				temp->next = pd->next;
			}
			pd = NULL;
			res = 1;
			break;
		}
		temp = pd;
	}
	return res;
}

void HashT::Showing(TMemo *Memo) {
	Memo->Lines->Clear();
	Memo->Lines->Add("Hash table:\n");
	AnsiString tmp = "";
	for (int i = 0; i < size; i++) {
		if (arr[i]) {
			tmp = "(" + IntToStr(arr[i]->key) + ", " +
				IntToStr(arr[i]->num) + ")";
			if (!arr[i]->next) {
				Memo->Lines->Add(IntToStr(i + 1) + ": " + tmp);
			}
			else {
				AnsiString s = "";
				Stack *temp = arr[i]->next;
				while (temp) {
					s += " (" + IntToStr(temp->key) + ", " +
						IntToStr(temp->num) + ")";
					temp = temp->next;
				}
				tmp += s;
				Memo->Lines->Add(IntToStr(i + 1) + ": " + tmp);
			}
		}
	}
	Memo->Lines->Add("\n");
}

Stack* HashT::Search(int numer) {
	int i = HashFun(numer);
	Stack* result = NULL;

	if (!arr[i]) {
		ShowMessage("No elements with such key");
		return NULL;
	}
	if (arr[i]->key == numer) {
		result = arr[i];
	}
	else {
		int marker = 0;
		Stack *temp = NULL;
		for (temp = arr[i]->next; temp; temp = temp->next) {
			if (temp->key == numer) {
				result = temp;
				break;
			}
		}
	}

	return result;
}

Stack *HashT :: FindStack(int &numbe) {
	int min = 1000000000;
	numbe = 0;
	Stack *res = NULL;
	for (int i = 0; i < size; i++) {
		if (arr[i]) {
			if (!arr[i]->next) {
				if (arr[i]->key < min) {
					min = arr[i]->key;
					numbe = i + 1;
					res = arr[i];
				}
			}
			else {
				Stack *temp = arr[i]->next;
				while (temp) {
					if (temp->key < min) {
						min = temp->key;
						numbe = i + 1;
						res = temp;
					}
					temp = temp->next;
				}
			}
		}
	}
	return res;
}

// ---------------------------------------------------------------------------
#pragma package(smart_init)
