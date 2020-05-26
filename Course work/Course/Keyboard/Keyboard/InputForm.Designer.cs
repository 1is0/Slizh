namespace Keyboard
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.InputLabel = new System.Windows.Forms.Label();
            this.TaskString = new System.Windows.Forms.Label();
            this.InputString = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.StringNumberLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLabel.Location = new System.Drawing.Point(28, 151);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(174, 25);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Введите строку:";
            // 
            // TaskString
            // 
            this.TaskString.AutoSize = true;
            this.TaskString.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TaskString.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskString.Location = new System.Drawing.Point(28, 190);
            this.TaskString.Name = "TaskString";
            this.TaskString.Size = new System.Drawing.Size(94, 25);
            this.TaskString.TabIndex = 1;
            this.TaskString.Text = "(строка)";
            // 
            // InputString
            // 
            this.InputString.AutoSize = true;
            this.InputString.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputString.Location = new System.Drawing.Point(28, 236);
            this.InputString.Name = "InputString";
            this.InputString.Size = new System.Drawing.Size(72, 25);
            this.InputString.TabIndex = 2;
            this.InputString.Text = "(ввод)";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLabel.Location = new System.Drawing.Point(28, 27);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(82, 25);
            this.SecondLabel.TabIndex = 4;
            this.SecondLabel.Text = "Время:";
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorsLabel.Location = new System.Drawing.Point(28, 67);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(98, 25);
            this.ErrorsLabel.TabIndex = 6;
            this.ErrorsLabel.Text = "Ошибки:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedLabel.Location = new System.Drawing.Point(28, 114);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(190, 25);
            this.SpeedLabel.TabIndex = 7;
            this.SpeedLabel.Text = "Скорость набора:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelLabel.Location = new System.Drawing.Point(414, 27);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(101, 25);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.Text = "Уровень:";
            // 
            // StringNumberLabel
            // 
            this.StringNumberLabel.AutoSize = true;
            this.StringNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StringNumberLabel.Location = new System.Drawing.Point(414, 67);
            this.StringNumberLabel.Name = "StringNumberLabel";
            this.StringNumberLabel.Size = new System.Drawing.Size(90, 25);
            this.StringNumberLabel.TabIndex = 9;
            this.StringNumberLabel.Text = "Строка:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Текстовые документы (.txt)|*.txt";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 290);
            this.Controls.Add(this.StringNumberLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.InputString);
            this.Controls.Add(this.TaskString);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Обучение";
            this.Shown += new System.EventHandler(this.InputForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label TaskString;
        private System.Windows.Forms.Label InputString;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label StringNumberLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

