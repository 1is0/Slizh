//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Form.h"
#include "Queue.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm3 *Form3;
List first;
Queue firstQueue, secondQueue;
//---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button1Click(TObject *Sender)
{
    first.Delete();
	ListBox1 -> Clear();
	srand(time(0));
	int quantityOfNumbers = StrToInt(Edit1 -> Text);
	int random;
	for (int i = 0; i < quantityOfNumbers; i++) {
		random = rand() % 200 - 100;
		first.Add(random);
		ListBox1->Items->Add(IntToStr(i + 1) + ".  " + random);
	}
	Label7 -> Caption = first.TakeMax();
	Label8 -> Caption = first.TakeMin();
}

//---------------------------------------------------------------------------

void __fastcall TForm3::Button2Click(TObject *Sender)
{
	Node* pointer = first.head;
	int i = 0;
	firstQueue.Delete();
	ListBox2 -> Clear();
	secondQueue.Delete();
	ListBox3 -> Clear();

	while(pointer != NULL)
	{
		if (first.max > first.min) {
			if (i < first.max && i>first.min) {
				firstQueue.Add(pointer->number);
				firstQueue.Back();
				ListBox2->Items->Add(IntToStr(pointer -> number));
			}
			else
			{
				secondQueue.Add(pointer -> number);
				secondQueue.Back();
				ListBox3 -> Items -> Add(IntToStr(pointer -> number));
			}
		}
		else
		{
			if(i < first.min && i > first.max)
			{
				firstQueue.Add(pointer -> number);
				firstQueue.Back();
				ListBox2 -> Items -> Add(IntToStr(pointer -> number));
			}
			else
			{
				secondQueue.Add(pointer -> number);
				secondQueue.Back();
				ListBox3 -> Items -> Add(IntToStr(pointer -> number));
			}
		}
        i++;
		pointer = pointer -> next;
	}
	firstQueue.TakeCurr();
	int tmp = firstQueue.Display();
	Edit2 -> Text = IntToStr(tmp);
	secondQueue.TakeCurr();
	int num = secondQueue.Display();

	Edit3 -> Text = IntToStr(num);
}
//---------------------------------------------------------------------------

/*void __fastcall TForm3::FormCreate(TObject *Sender)
{
	Edit1 -> Text = 10;
} */

void __fastcall TForm3::Button3Click(TObject *Sender)
{
	int tmp = firstQueue.Display();
	Edit2 -> Text = IntToStr(tmp);
}
//---------------------------------------------------------------------------

void __fastcall TForm3::Button4Click(TObject *Sender)
{
	int num = secondQueue.Display();

	Edit3 -> Text = IntToStr(num);
}
//---------------------------------------------------------------------------
/*void TForm3 :: PrintEdit()
{
	int tmp = firstQueue.PrintNode();
	Edit2 -> Text = IntToStr(tmp);
}
void TForm3 :: PrintEdit2()
{
	int num = secondQueue.PrintNode();

	Edit3 -> Text = IntToStr(num);
}

//---------------------------------------------------------------------------
*/
void __fastcall TForm3::FormCreate(TObject *Sender)
{
	Edit1->Text = 10;
}
//---------------------------------------------------------------------------

