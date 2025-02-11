using System;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class WinForm : Form
    {
        private Form1 mainForm;
        public WinForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            mainForm.ResetGame();
            this.Close();
        }

        private void buttonWinExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
