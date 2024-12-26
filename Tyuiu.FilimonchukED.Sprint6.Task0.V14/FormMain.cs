using Tyuiu.FilimonchukED.Sprint6.Task0.V14.Lib;

namespace Tyuiu.FilimonchukED.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxFormula = new PictureBox();
            textBoxVarA = new TextBox();
            textBoxResult = new TextBox();
            buttonAccess = new Button();
            buttonQuestion = new Button();
            labelCondition = new Label();
            label1 = new Label();
            label4 = new Label();
            textBoxTask = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(352, 12);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(143, 84);
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxVarA
            // 
            textBoxVarA.Location = new Point(134, 231);
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(100, 23);
            textBoxVarA.TabIndex = 9;
            textBoxVarA.KeyPress += textBoxVarA_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(352, 231);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 12;
            // 
            // buttonAccess
            // 
            buttonAccess.Location = new Point(386, 286);
            buttonAccess.Name = "buttonAccess";
            buttonAccess.Size = new Size(99, 25);
            buttonAccess.TabIndex = 13;
            buttonAccess.Text = "Выполнить\r\n\r\n";
            buttonAccess.UseVisualStyleBackColor = true;
            buttonAccess.Click += buttonDone_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.FlatStyle = FlatStyle.Flat;
            buttonQuestion.Location = new Point(343, 286);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(24, 25);
            buttonQuestion.TabIndex = 14;
            buttonQuestion.Text = "?";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += buttonHelp_Click;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(12, 9);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(53, 15);
            labelCondition.TabIndex = 15;
            labelCondition.Text = "Условие";
            // 
            // label1
            // 
            label1.Location = new Point(134, 208);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 16;
            label1.Text = "Переменная А";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(352, 208);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 19;
            label4.Text = "Результат";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(12, 27);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(334, 157);
            textBoxTask.TabIndex = 20;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            ClientSize = new Size(497, 323);
            Controls.Add(textBoxTask);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(labelCondition);
            Controls.Add(buttonQuestion);
            Controls.Add(buttonAccess);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxVarA);
            Controls.Add(pictureBoxFormula);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "сигмабой";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент бимбим бамбам");
        }
    }
}
