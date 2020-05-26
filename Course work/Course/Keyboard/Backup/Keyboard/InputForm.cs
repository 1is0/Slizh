using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class InputForm : Form
    {
        public string Name;
        public const int InputSize = 65;
        public int Level;
        public int Second;
        public int ErrorsCount;
        public int CurrentChar;
        public int CorrectChars;
        public int CurrentString;

        public string Input;
        public string[] lines;
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Shown(object sender, EventArgs e)
        {
            Second = 0;
            CurrentChar = 0;
            CurrentString = 0;
            ErrorsCount = 0;
            CorrectChars = 0;
            timer.Enabled = true;

            //загрузка строк
            string Path = Application.StartupPath;

            if (Level == 0)
            {
                Path += "\\easy.txt";
                LevelLabel.Text = "Уровень: Низкий";
            }
            if (Level == 1)
            {
                Path += "\\medium.txt";
                LevelLabel.Text = "Уровень: Средний";
            }
            if (Level == 2)
            {
                Path += "\\hard.txt";
                LevelLabel.Text = "Уровень: Высокий";
            }
            lines = System.IO.File.ReadAllLines(Path, Encoding.GetEncoding(1251));
            
            TaskString.Text = lines[CurrentString];
            InputString.Text = "";
            Input = "";

            SecondLabel.Text = "Время: " + Second.ToString() + " сек";
            ErrorsLabel.Text = "Ошибки: " + ErrorsCount.ToString();
            StringNumberLabel.Text = "Строка: " + (CurrentString + 1).ToString() + "/" + lines.Count().ToString();
            SpeedLabel.Text = "Скорость набора: 0 сим/мин"; 
        }
        

        private void timer_Tick(object sender, EventArgs e)
        {
            Second++;
            SecondLabel.Text = "Время: " + Second.ToString() + " сек";
            int InputSpeed = (int)(((float)CorrectChars / (float)Second) * 60);
            SpeedLabel.Text = "Скорость набора:" + InputSpeed.ToString() + " сим/мин"; 
        }

        private void InputForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer.Enabled) return;
            if (e.KeyChar.ToString() == lines[CurrentString][CurrentChar].ToString())
            {

                Input += e.KeyChar.ToString();
                //
                InputString.Text = Input;
                TaskString.Text = lines[CurrentString];
                if (CurrentChar > InputSize / 2)
                {
                    InputString.Text = Input.Substring(CurrentChar - InputSize / 2);
                    TaskString.Text = lines[CurrentString].Substring(CurrentChar - InputSize / 2);
                }
               
                CurrentChar++;
                CorrectChars++;
                int InputSpeed = (int) (((float)CorrectChars / (float)Second) * 60);
                SpeedLabel.Text = "Скорость набора:" +  InputSpeed.ToString() + " сим/мин"; 
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
                ErrorsCount++;
            }
            if (CurrentChar == lines[CurrentString].Length)
            {

                CurrentChar = 0;
                CurrentString++;
                if (CurrentString == lines.Count())
                {
                    timer.Enabled = false;
                    if (MessageBox.Show("Программа обучения выполнена. Сохранить результаты?", "Программа обучения выполнена.", MessageBoxButtons.OKCancel) == DialogResult.OK)   
                        if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                        {                          
                            string[] SaveLines = { "Имя обучающегося: " + Name, LevelLabel.Text, SecondLabel.Text, ErrorsLabel.Text, SpeedLabel.Text };
                            System.IO.File.WriteAllLines(saveFileDialog.FileName, SaveLines);
                        }
                    this.Close();
                }
                else
                {
                    TaskString.Text = lines[CurrentString];
                    InputString.Text = "";
                    Input = "";
                }
                StringNumberLabel.Text = "Строка: " + (CurrentString + 1).ToString() + "/" + lines.Count().ToString();
            }

            ErrorsLabel.Text = "Ошибки: " + ErrorsCount.ToString();
        }     
        
    }
}
