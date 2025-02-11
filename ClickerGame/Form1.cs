using System;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCustomize_Click(object sender, EventArgs e)
        {
            using (CustomizationForm form = new CustomizationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxCharacter.Image = form.SelectedCharacter;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            score = 0;
            labelScore.Text = "0";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            AboutGameForm form = new AboutGameForm();
            form.Show();
        }

        public void ResetGame()
        {
            score = 0;
            labelScore.Text = "0";
        }

        private void pictureBoxCharacter_MouseDown(object sender, MouseEventArgs e)
        {
            score++;
            labelScore.Text = "" + score;

            if (score >= 50)
            {
                WinForm winForm = new WinForm(this);
                winForm.ShowDialog();
            }
        }
    }
}
