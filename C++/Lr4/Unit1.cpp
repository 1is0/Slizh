// ---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include <Stack.h>
#include "Unit1.h"
// ---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
using namespace std;
TForm3 *Form3;
DecodingOfStack stk;

// ---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner) : TForm(Owner) {
}

void __fastcall TForm3::Button1Click(TObject *Sender) {

	AnsiString strStr = Edit1->Text;
	string str = strStr.c_str();

	AnsiString str1 = Edit2->Text;
	stk.a = StrToFloat(str1);

	AnsiString str2 = Edit3->Text;
	stk.b = StrToFloat(str2);

	AnsiString str3 = Edit4->Text;
	stk.c = StrToFloat(str3);

	AnsiString str4 = Edit5->Text;
	stk.d = StrToFloat(str4);

	AnsiString str5 = Edit6->Text;
	stk.e = StrToFloat(str5);

	Memo1->Clear();

	// Преобразование в постфиксную форму (ОПЗ)
	char note[100];
	strcpy(note, str.c_str());
	string pnote = stk.OPZ(note);
	strStr = pnote.c_str();
	Memo1->Lines->Add("OPZ: " + strStr);

	// Вычисление выражения
	double dd = stk.Calculating(pnote);
	Memo1->Lines->Add("Result: " + AnsiString(dd));

}
// ---------------------------------------------------------------------------

void __fastcall TForm3::Button2Click(TObject *Sender) {
	Edit1->Text = "a*(b-c)/(d+e)";
	Edit2->Text = "1,6";
	Edit3->Text = "4,9";
	Edit4->Text = "5,7";
	Edit5->Text = "0,8";
	Edit6->Text = "2,3";
	Memo1->Clear();
}
// ---------------------------------------------------------------------------
