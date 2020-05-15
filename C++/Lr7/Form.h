//---------------------------------------------------------------------------

#ifndef FormH
#define FormH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
//---------------------------------------------------------------------------
class TForm3 : public TForm
{
__published:	// IDE-managed Components
	TMemo *Memo1;
	TButton *Add;
	TButton *Delete;
	TEdit *Edit1;
	TLabel *Label1;
	TButton *Search;
	TButton *Finding;
	void __fastcall AddClick(TObject *Sender);
	void __fastcall DeleteClick(TObject *Sender);
	void __fastcall SearchClick(TObject *Sender);
	void __fastcall FindingClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm3(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm3 *Form3;
//---------------------------------------------------------------------------
#endif
