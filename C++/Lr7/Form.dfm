object Form3: TForm3
  Left = 0
  Top = 0
  Caption = 'Form3'
  ClientHeight = 231
  ClientWidth = 365
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 0
    Top = 195
    Width = 30
    Height = 23
    Caption = 'Key'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Memo1: TMemo
    Left = 0
    Top = 8
    Width = 257
    Height = 178
    Lines.Strings = (
      'Memo1')
    TabOrder = 0
  end
  object Add: TButton
    Left = 272
    Top = 8
    Width = 75
    Height = 25
    Caption = 'Add'
    TabOrder = 1
    OnClick = AddClick
  end
  object Delete: TButton
    Left = 272
    Top = 39
    Width = 75
    Height = 25
    Caption = 'Delete'
    TabOrder = 2
    OnClick = DeleteClick
  end
  object Edit1: TEdit
    Left = 36
    Top = 192
    Width = 121
    Height = 31
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 3
  end
  object Search: TButton
    Left = 272
    Top = 70
    Width = 75
    Height = 25
    Caption = 'Search'
    TabOrder = 4
    OnClick = SearchClick
  end
  object Finding: TButton
    Left = 272
    Top = 101
    Width = 75
    Height = 25
    Caption = 'Finding Stack'
    TabOrder = 5
    OnClick = FindingClick
  end
end
