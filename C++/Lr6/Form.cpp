// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include "Tree.h"
#include "Form.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm3 *Form3;
CalculatingInTree tree;
using namespace std;

// ---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner) : TForm(Owner) {
}

// ---------------------------------------------------------------------------
void __fastcall TForm3::FormCreate(TObject *Sender) {
	StringGrid1->ColWidths[0] = 100;
	StringGrid1->ColWidths[1] = 100;
	StringGrid1->Cells[0][0] = "Surname of footballer";
	StringGrid1->Cells[1][0] = "Number of player";
	StringGrid1->Cells[0][1] = "Ronaldinho";
	StringGrid1->Cells[0][2] = "Messi";
	StringGrid1->Cells[0][3] = "Van Persie";
	StringGrid1->Cells[0][4] = "Buffon";
	StringGrid1->Cells[1][1] = "88";
	StringGrid1->Cells[1][2] = "10";
	StringGrid1->Cells[1][3] = "11";
	StringGrid1->Cells[1][4] = "1";
	Memo1->Clear();

	Edit1->Text = "";
	Edit2->Text = "";
}

// ---------------------------------------------------------------------------
// ---------------------------------------------------------------------------

void __fastcall TForm3::Button1Click(TObject *Sender) {
	tree.Clearing(tree.root);
	tree.root = NULL;
	AnsiString str;
	int tmp;
	for (int i = 1; i < StringGrid1->RowCount; i++) {
		if (!StringGrid1->Cells[0][i].IsEmpty()) {
			str = StringGrid1->Cells[0][i];
			string tmpStr = str.c_str();
			str = StringGrid1->Cells[1][i];
			tmp = StrToInt(str);
			tree.root = tree.Add(tree.root, tmpStr, tmp);
		}
	}
	tree.Showing(TreeView1);
	TreeView1->FullExpand();
}

// ---------------------------------------------------------------------------
void __fastcall TForm3::Button2Click(TObject *Sender) {
	int count = 1;
	int sum = 0;
	int lvl = 0;
	while (count != 0) {
		count = tree.Count(tree.root, lvl);
		if (count > 0) {
			sum += count;
		}
		lvl++;
	}
	Memo1->Lines->Add("There " + IntToStr(sum) + " symbols in all strings");
}
// ---------------------------------------------------------------------------

void __fastcall TForm3::Button3Click(TObject *Sender) {
	AnsiString sname = Edit1->Text;
	string name = (sname.c_str());
	AnsiString numbOfPlayr = Edit2->Text;
	int numb = StrToInt(numbOfPlayr);
	if (numb > 99 || numb < 1) {
		ShowMessage("Incorrect number. Enter namber between 0 and 100");
	}
	else {
		tree.root = tree.Add(tree.root, name, numb);

		tree.Showing(TreeView1);
		TreeView1->FullExpand();

		StringGrid1->RowCount++;
		StringGrid1->Cells[0][StringGrid1->RowCount - 1] = Edit1->Text;
		StringGrid1->Cells[1][StringGrid1->RowCount - 1] = Edit2->Text;
	}
}

// ---------------------------------------------------------------------------

void __fastcall TForm3::Button4Click(TObject *Sender) {
	if (!tree.root)
		return;

	else {
		int num = StrToInt(Edit2->Text);

		AnsiString str = tree.getPlayer(num);
		tree.Deleting(num);
		tree.Showing(TreeView1);
		Memo1->Lines->Add("Player deleted");
		Memo1->Lines->Add("Surname " + str);
		Memo1->Lines->Add("Number " + IntToStr(num));
		Memo1->Lines->Add("\n");
		for (int i = 1, j = 1; i < StringGrid1->RowCount; i++) {
			if (StringGrid1->Cells[1][i] != num) {
				StringGrid1->Cells[0][j] = StringGrid1->Cells[0][i];
				StringGrid1->Cells[1][j] = StringGrid1->Cells[1][i];
				j++;
			}
		}
		StringGrid1->RowCount--;
		Edit1->Text = "";
		Edit2->Text = "";
		TreeView1->FullExpand();
	}
}
// ---------------------------------------------------------------------------

void __fastcall TForm3::Button5Click(TObject *Sender) {
	if (!tree.root)
		return;
	else {
		int tmp = StrToInt(Edit2->Text);
		if (tmp < 100 && tmp > 0) {
			AnsiString temp = tree.getPlayer(tmp);
			if (temp != "") {
				Memo1->Lines->Add("Player found");
				Memo1->Lines->Add("Surname " + temp);
				Memo1->Lines->Add("Number " + IntToStr(tmp));
				Memo1->Lines->Add("\n");
			}
			else {
				Memo1->Lines->Add("Player not found");
				Memo1->Lines->Add("\n");
			}
		}
		else {

			Edit2->Text = "";
			ShowMessage("Incorrect number");
		}
	}
}

// ---------------------------------------------------------------------------
void __fastcall TForm3::Button6Click(TObject *Sender)
{
	Memo1 -> Lines -> Add("Forward detour");
	tree.Direct(Memo1, tree.root);
	Memo1 -> Lines -> Add("\n");	
}
//---------------------------------------------------------------------------

void __fastcall TForm3::Button7Click(TObject *Sender)
{
	Memo1 -> Lines -> Add("Reverse Detour: ");
	tree.Backward(Memo1, tree.root);
	Memo1 -> Lines -> Add("\n");
}
//---------------------------------------------------------------------------

void __fastcall TForm3::Button8Click(TObject *Sender)
{
	Memo1 -> Lines -> Add("Ascending Detour: ");
	tree.Key(Memo1, tree.root);
	Memo1 -> Lines -> Add("\n");
}
//---------------------------------------------------------------------------

