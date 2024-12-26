namespace Tyuiu.FilimonchukED.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private PictureBox pictureBoxFormula;
        private TextBox textBoxVarA;
        private TextBox textBoxResult;
        private Button buttonAccess;
        private Button buttonQuestion;
        private Label labelCondition;
        private Label label1;
        private Label label4;
        private TextBox textBoxTask;
    }
}
