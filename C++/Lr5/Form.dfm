object Form3: TForm3
  Left = 0
  Top = 0
  Caption = 'Form3'
  ClientHeight = 309
  ClientWidth = 611
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
    Left = 206
    Top = 13
    Width = 86
    Height = 23
    Caption = 'Source list'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 344
    Top = 13
    Width = 94
    Height = 23
    Caption = 'First queue'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label3: TLabel
    Left = 482
    Top = 13
    Width = 121
    Height = 23
    Caption = 'Second queue'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label4: TLabel
    Left = 32
    Top = 210
    Width = 141
    Height = 23
    Caption = 'Maximal element'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label5: TLabel
    Left = 32
    Top = 239
    Width = 137
    Height = 23
    Caption = 'Minimal element'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label6: TLabel
    Left = 32
    Top = 268
    Width = 252
    Height = 23
    Caption = 'Enter a number of elements'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label7: TLabel
    Left = 179
    Top = 210
    Width = 14
    Height = 23
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label8: TLabel
    Left = 179
    Top = 239
    Width = 14
    Height = 23
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label9: TLabel
    Left = 32
    Top = 96
    Width = 79
    Height = 23
    Caption = 'Loopback'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Button1: TButton
    Left = 32
    Top = 24
    Width = 113
    Height = 25
    Caption = 'Filling list'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 32
    Top = 55
    Width = 113
    Height = 25
    Caption = 'Filling queue'
    TabOrder = 1
    OnClick = Button2Click
  end
  object ListBox1: TListBox
    Left = 206
    Top = 42
    Width = 121
    Height = 145
    ItemHeight = 13
    TabOrder = 2
  end
  object ListBox2: TListBox
    Left = 344
    Top = 40
    Width = 121
    Height = 145
    ItemHeight = 13
    TabOrder = 3
  end
  object ListBox3: TListBox
    Left = 482
    Top = 40
    Width = 121
    Height = 145
    ItemHeight = 13
    TabOrder = 4
  end
  object Edit1: TEdit
    Left = 304
    Top = 268
    Width = 65
    Height = 23
    TabOrder = 5
  end
  object Edit2: TEdit
    Left = 32
    Top = 136
    Width = 41
    Height = 21
    TabOrder = 6
  end
  object Edit3: TEdit
    Left = 32
    Top = 163
    Width = 41
    Height = 21
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 7
  end
  object Button3: TButton
    Left = 79
    Top = 134
    Width = 94
    Height = 25
    Caption = 'Next in 1st queue'
    TabOrder = 8
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 79
    Top = 161
    Width = 94
    Height = 25
    Caption = 'Next in 2nd queue'
    TabOrder = 9
    OnClick = Button4Click
  end
end
