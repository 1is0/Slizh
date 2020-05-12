// ---------------------------------------------------------------------------

#pragma hdrstop

#include "Tree.h"
#include <string>
using namespace std;

Node* Tree::MakingOfTree(string surn, int num) {
	Node* tmp = new Node;
	if (!tmp)
		return NULL;
	tmp->left = NULL;
	tmp->right = NULL;
	tmp->number = num;
	tmp->surname = surn;
	return tmp;
}

Node* Tree::Add(Node* tree, string surname, int number) {
	if (!tree)
		return MakingOfTree(surname, number);
	Node* root = tree;
	while (1) {
		if (root->number == number)
			return tree;
		if (number < root->number) {
			if (root->left)
				root = root->left;
			else {
				root->left = MakingOfTree(surname, number);
				return tree;
			}
		}
		else {
			if (root->right)
				root = root->right;
			else {
				root->right = MakingOfTree(surname, number);
				return tree;
			}
		}
	}
}

int Tree::Counting(Node* root) {
	if (root->left == NULL && root->right == NULL)
		return 1;
	int left = 0, right = 0;
	if (root->left != NULL)
		left = Counting(root->left);
	else
		left = 0;
	if (root->right != NULL)
		right = Counting(root->right);
	else
		right = 0;
	return left + right + 1;
}

void Tree::Printing(Node* tmp, TTreeView *TreeView, int &index) {
	int i = index;
	if (tmp->left) {
		TreeView->Items->AddChild(TreeView->Items->Item[i],
			(tmp->left->surname).c_str());
		Printing(tmp->left, TreeView, ++index);
	}
	if (tmp->right) {
		TreeView->Items->AddChild(TreeView->Items->Item[i],
			(tmp->right->surname).c_str());
		Printing(tmp->right, TreeView, ++index);
	}

}

void Tree::Showing(TTreeView *TreeView) {
	int index = 0;
	TreeView->Items->Clear();
	if (root) {
		TreeView->Items->Add(NULL, (root->surname).c_str());
		Printing(root, TreeView, index);
	}
}

int CalculatingInTree::Count(Node* root, int tmp) {
	if (root == 0)
		return 0;
	if (tmp == 0)
		return root->surname.length();

	int left = Count(root->left, tmp - 1);
	int right = Count(root->right, tmp - 1);
	return left + right;
}

void Tree::Direct(TMemo *Memo1, Node* pointer) {
	if (pointer) {
		Memo1->Lines->Add((pointer->surname).c_str());
		Direct(Memo1, pointer->left);
		Direct(Memo1, pointer->right);
	}
}

void Tree::Backward(TMemo *Memo1, Node* pointer) {
	if (pointer) {
		Backward(Memo1, pointer->left);
		Backward(Memo1, pointer->right);
		Memo1->Lines->Add((pointer->surname).c_str());
	}
}

void Tree::Key(TMemo *Memo1, Node* pointer) {
	if (pointer) {
		Key(Memo1, pointer->left);
		Memo1->Lines->Add((pointer->surname).c_str());
		Key(Memo1, pointer->right);
	}
}

void Tree::Clearing(Node *root) {
	if (!root)
		return;
	Clearing(root->left);
	Clearing(root->right);
	delete root;
}

void Tree::Deleting(int tmp) {
	Node *del, *node, *pd, *pn;
	del = root;
	pd = NULL;
	while (del->number != tmp) {
		pd = del;
		if (tmp < del->number)
			del = del->left;
		else
			del = del->right;
	}
	if (!del)
		return;
	if (!del->right)
		node = del->left;
	else {
		if (!del->left)
			node = del->right;
		else {
			pn = del;
			node = del->left;
			while (node->right) {
				pn = del;
				node = node->right;
			}
			if (pn == del)
				node->right = del->right;
			else {
				node->right = del->right;
				pn->right = node->left;
				node->left = pn;
			}
		}
	}
	if (!pd)
		root = pd = node;
	else {
		if (del->number < pd->number)
			pd->left = node;
		else
			pd->right = node;
	}
	delete del;
	numberOfNodes--;
}

AnsiString Tree::getPlayer(int par) {
	Node *tmp = root;
	while (tmp->number != par) {
		if (par < tmp->number)
			tmp = tmp->left;
		else
			tmp = tmp->right;
	}
	if (tmp)
		return (tmp->surname).c_str();
	else
		return "";

}
// ---------------------------------------------------------------------------
#pragma package(smart_init)
