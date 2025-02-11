using System;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        private int score = 0; // Переменная для хранения счета

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCustomize_Click(object sender, EventArgs e) // Открытие окна кастомизации персонажа
        {
            using (CustomizationForm form = new CustomizationForm()) // Создаем окно кастомизации
            {
                if (form.ShowDialog() == DialogResult.OK) // Если выбрали персонажа и нажали "ОК"
                {
                    pictureBoxCharacter.Image = form.SelectedCharacter; // Устанавливаем выбранное изображение
                } 
            }
        }

        private void buttonReset_Click(object sender, EventArgs e) // Сброс счета
        {
            score = 0;
            labelScore.Text = "0";
        }

        private void buttonExit_Click(object sender, EventArgs e) // Выход из игры
        {
            Application.Exit();
        }

        private void buttonInfo_Click(object sender, EventArgs e) // Открытие окна информации об игре
        {
            AboutGameForm form = new AboutGameForm();
            form.Show();
        }

        public void ResetGame() // Метод для сброса игры
        {
            score = 0;
            labelScore.Text = "0";
        }

        private void pictureBoxCharacter_MouseDown(object sender, MouseEventArgs e) // Обработчик нажатия на персонажа
        {
            score++;
            labelScore.Text = "" + score;

            if (score >= 50) // Если счет достиг 50, открываем окно победы
            {
                WinForm winForm = new WinForm(this);
                winForm.ShowDialog();
            }
        }
    }
}
