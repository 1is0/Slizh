// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include "HashTable.h"
#include "Form.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm3 *Form3;
HashT has;

// ---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner) : TForm(Owner) {
	has.Creating();
	srand(time(0));
	Memo1->Lines->Clear();
}

// ---------------------------------------------------------------------------
void __fastcall TForm3::AddClick(TObject *Sender) {
	int tmp = rand() % 100;
	int num = rand() % 100;
	has.Add(tmp, num);
	has.Showing(Memo1);
}

// ---------------------------------------------------------------------------
void __fastcall TForm3::DeleteClick(TObject *Sender) {
	int tmp = StrToInt(Edit1->Text);
	if (tmp < 0)
		ShowMessage("Enter a correct key");
	else {
		int res = has.Deleting(tmp);
		if (!res)
			ShowMessage("No elements with this key");
		has.Showing(Memo1);
	}
}

// ---------------------------------------------------------------------------
void __fastcall TForm3::SearchClick(TObject *Sender) {
	Memo1->Clear();
	int tmp = StrToInt(Edit1->Text);
	if (tmp < 0)
		ShowMessage("Enter a correct key");
	else {
		Stack* res = has.Search(tmp);
		if (res != NULL) {
			Memo1->Lines->Add("Elements found\n Key: " + IntToStr(res->key) +
				" value:\n");
		}
		else
			ShowMessage("No elements with such key");
	}
}

// ---------------------------------------------------------------------------

void __fastcall TForm3::FindingClick(TObject *Sender) {
	has.Showing(Memo1);
	Memo1->Lines->Add("\n");
	int num = 0;
	Stack* res = has.FindStack(num);
	if (res != NULL) {
		Memo1->Lines->Add("Номер стека, с минимальным ключом: " +
			IntToStr(num));
		AnsiString str = "Минимальный элемент: ";
		str = str + "(" + IntToStr(res->key) + ", " + IntToStr(res->num) + ")";
		Memo1->Lines->Add(str + "\n");
	}
}
// ---------------------------------------------------------------------------
