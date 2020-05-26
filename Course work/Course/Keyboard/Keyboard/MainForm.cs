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
    public partial class MainForm : Form
    {
        public InputForm input_form;
        public EditForm edit_form;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            input_form = new InputForm();
            edit_form = new EditForm();
            LevelComboBox.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            input_form.Level = LevelComboBox.SelectedIndex;
            input_form.Name = NameBox.Text;
            input_form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            edit_form.Level = LevelComboBox.SelectedIndex;
            edit_form.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }
    }
}
