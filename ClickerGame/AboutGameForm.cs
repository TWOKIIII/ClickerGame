using System;
using System.Windows.Forms;

namespace ClickerGame
{
    partial class AboutGameForm : Form
    {
        public AboutGameForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) // Закрытие окна
        {
            this.Close();
        }
    }
}