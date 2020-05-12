object Form3: TForm3
  Left = 0
  Top = 0
  Caption = 'Form3'
  ClientHeight = 551
  ClientWidth = 854
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 19
    Width = 182
    Height = 23
    Caption = 'Surname of footballer'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 24
    Top = 59
    Width = 131
    Height = 23
    Caption = 'Playing number'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label3: TLabel
    Left = 101
    Top = 272
    Width = 92
    Height = 23
    Caption = 'Intial data:'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label4: TLabel
    Left = 501
    Top = -1
    Width = 98
    Height = 23
    Caption = 'Information'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label5: TLabel
    Left = 501
    Top = 278
    Width = 115
    Height = 23
    Caption = 'Balanced tree'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label6: TLabel
    Left = 24
    Top = 181
    Width = 57
    Height = 23
    Caption = 'Detour'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label7: TLabel
    Left = 0
    Top = 144
    Width = 536
    Height = 13
    Caption = 
      '----------------------------------------------------------------' +
      '----------------------------------------------------------------' +
      '------'
  end
  object Label8: TLabel
    Left = 0
    Top = 232
    Width = 504
    Height = 13
    Caption = 
      '----------------------------------------------------------------' +
      '--------------------------------------------------------------'
  end
  object Edit1: TEdit
    Left = 212
    Top = 19
    Width = 121
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 212
    Top = 56
    Width = 121
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
  end
  object Memo1: TMemo
    Left = 502
    Top = 28
    Width = 344
    Height = 253
    Lines.Strings = (
      'Memo1')
    TabOrder = 2
  end
  object TreeView1: TTreeView
    Left = 502
    Top = 301
    Width = 344
    Height = 228
    Indent = 19
    TabOrder = 3
  end
  object Button1: TButton
    Left = 427
    Top = 383
    Width = 75
    Height = 25
    Caption = 'Data -> Tree'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Symbol'
    Font.Style = []
    ParentFont = False
    TabOrder = 4
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 397
    Top = 28
    Width = 99
    Height = 25
    Caption = 'Number of symbols'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
    TabOrder = 5
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 24
    Top = 104
    Width = 75
    Height = 25
    Caption = 'Add'
    TabOrder = 6
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 131
    Top = 104
    Width = 75
    Height = 25
    Caption = 'Delete'
    TabOrder = 7
    OnClick = Button4Click
  end
  object Button5: TButton
    Left = 240
    Top = 104
    Width = 75
    Height = 25
    Caption = 'Search'
    TabOrder = 8
    OnClick = Button5Click
  end
  object Button6: TButton
    Left = 118
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Forward'
    TabOrder = 9
    OnClick = Button6Click
  end
  object Button7: TButton
    Left = 224
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Reverse'
    TabOrder = 10
    OnClick = Button7Click
  end
  object Button8: TButton
    Left = 328
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Ascending'
    TabOrder = 11
    OnClick = Button8Click
  end
  object StringGrid1: TStringGrid
    Left = 101
    Top = 301
    Width = 320
    Height = 228
    TabOrder = 12
    RowHeights = (
      24
      24
      24
      24
      24)
  end
end
