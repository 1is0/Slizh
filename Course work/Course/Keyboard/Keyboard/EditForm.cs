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
    public partial class EditForm : Form
    {
        public int Level;
        public string Path;
        public EditForm()
        {
            InitializeComponent();
        }

        

        private void SaveButton_Click(object sender, EventArgs e)
        {

            richTextBox.SaveFile(Path, RichTextBoxStreamType.PlainText);
            this.Close();
        }

        private void EditForm_Shown(object sender, EventArgs e)
        {
            Path = Application.StartupPath;
            if (Level == 0)
                Path += "\\easy.txt";
            if (Level == 1)
                Path += "\\medium.txt";
            if (Level == 2)
                Path += "\\hard.txt";

            richTextBox.LoadFile(Path, RichTextBoxStreamType.PlainText);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
