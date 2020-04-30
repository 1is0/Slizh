// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Stack.h"
#include <windows.h>
#include <ctype.h>
#include <vcl.h>
using namespace std;

bool Stack::IsEmpty() {
	bool flag;
	if (counter == 0)
		flag = true;
	else
		flag = false;
	return flag;
}

char Stack::GetCount() {
	char tmp;
	tmp = stack[counter];
	return tmp;
}

void Stack::Push(char par) {
	counter++;
	stack[counter] = par;
}

char Stack::Pop() {
	char tmp = stack[counter];
	counter--;
	return tmp;
}

int Stack::PriorityOfSignes(char par) {
	if ((par == '/') || (par == '*'))
		return 1;
	if ((par == '-') || (par == '+'))
		return 2;
	if ((par == '(') || (par == ')'))
		return 0;
}

int Stack::Count_Priority() {
	int tmp = PriorityOfSignes(stack[counter]);
	return tmp;
}

void DecodingOfStack::Push(double par) {
	counter++;
	sum.push_back(par);
}

void DecodingOfStack::Pop() {
	counter--;
	sum.erase(sum.end() - 1);
	/* end возвращает итератор на место после последнего элемента вектора,поэтому добавляем -1
	 erase очищает место в стэке,которое вернул get_top_element */
}

double DecodingOfStack::GetTopElement() {
	return sum[counter - 1];
}

double DecodingOfStack::Calculating(const string& pnote) {
	DecodingOfStack final;

	// делим строку на лексемы
	char tmpArray[20];
	strcpy(tmpArray, pnote.c_str());
	char *pch = strtok(tmpArray, " ");
	while (pch != NULL) {
		if (*pch == '+') {
			double oper1 = final.GetTopElement();
			final.Pop();
			double oper2 = final.GetTopElement();
			final.Pop();
			final.Push(oper2 + oper1);
		}
		else {
			if (*pch == '-') {
				double oper1 = final.GetTopElement();
				final.Pop();
				double oper2 = final.GetTopElement();
				final.Pop();
				final.Push(oper2 - oper1);
			}
			else {
				if (*pch == '*') {
					double oper1 = final.GetTopElement();
					final.Pop();
					double oper2 = final.GetTopElement();
					final.Pop();
					final.Push(oper2 * oper1);
				}
				else {
					if (*pch == '/') {
						double oper1 = final.GetTopElement();
						final.Pop();
						double oper2 = final.GetTopElement();
						final.Pop();
						final.Push(oper2 / oper1 * 1.0);
					}
					else {
						double temp = 0;
						switch (*pch) {
						case 'a':
							temp = a;
							break;
						case 'b':
							temp = b;
							break;
						case 'c':
							temp = c;
							break;
						case 'd':
							temp = d;
							break;
						case 'e':
							temp = e;
							break;
						}
						final.Push(temp);
					}
				}
			}
		}

		pch = strtok(NULL, " ");
	}

	double cd = final.GetTopElement();
	return cd;
}

string DecodingOfStack::OPZ(const char(&note)[100]) {
	int i = 0;
	Stack s;
	string pnote;
	if (note[0] == '-') {
		pnote += note[0];
		i++;
	}

	for (i = 0; i < strlen(note); i++) {
		if (note[i] == '(') {
			s.Push(note[i]);
		}
		else if ((note[i] == '+') || (note[i] == '-') || (note[i] == '/') ||(note[i] == '*')) {
			while ((!s.IsEmpty()) && (s.Count_Priority() >=s.PriorityOfSignes(note[i]))) {
				pnote += s.Pop();
				pnote += " ";
			}
			s.Push(note[i]);
		}
		else if (note[i] == ')') {
			while ((!s.IsEmpty()) && (s.GetCount() != '(')) {
				pnote += s.Pop();
				pnote += " ";
			}
			s.Pop();
		}
		else if (isalpha(note[i])) {
			string temp = "";
			while (i < strlen(note) && note[i] != '+' && note[i] != '-' && note
				[i] != '/' && note[i] != '*' && note[i] != '(' && note[i]
				!= ')')
			{
				temp += note[i];
				i++;
			}
			pnote += temp += " ";
			i--;
		}

		else if (note[i] != ' ') {
			ShowMessage("Error");
			return "None";
		}
	}
	while (!s.IsEmpty()) {
		pnote += s.Pop();
	}
	return pnote;

}
// ---------------------------------------------------------------------------
#pragma package(smart_init)
