using System;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class WinForm : Form
    {
        private Form1 mainForm; // Ссылка на основное окно игры
        public WinForm(Form1 form)  // Конструктор получает ссылку на Form1
        {
            InitializeComponent();
            mainForm = form; // Сохраняем ссылку на основное окно
        }

        private void buttonRestart_Click(object sender, EventArgs e) // Нажатие на кнопку "Начать заново", рестарт игры
        {
            mainForm.ResetGame();
            this.Close();
        }

        private void buttonWinExit_Click(object sender, EventArgs e)  // Выход из игры
        {
            Application.Exit();
        }
    }
}
