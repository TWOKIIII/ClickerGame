using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        private int score = 0; // Переменная для хранения счета
        private int multiplier = 1; // Множитель очков (по умолчанию x1)
        private Timer autoClickTimer; // Таймер для автокликера

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
            score += multiplier; // Добавляем очки с учетом множителя
            labelScore.Text = "" + score;

            if (score >= 50) // Если счет достиг 50, открываем окно победы
            {
                WinForm winForm = new WinForm(this);
                winForm.ShowDialog();
            }
        }

        private void buttonBoostX2_Click(object sender, EventArgs e)
        {
            multiplier = 2;
            buttonBoostX2.Enabled = false; // Отключаем кнопку, чтобы нельзя было активировать снова

            Task.Delay(10000).ContinueWith(_ =>
            {
                multiplier = 1;
                buttonBoostX2.Invoke((MethodInvoker)(() => buttonBoostX2.Enabled = true)); // Включаем кнопку обратно
            });
        }

        private void buttonBoostX4_Click(object sender, EventArgs e)
        {
            multiplier = 4;
            buttonBoostX4.Enabled = false; // Отключаем кнопку

            Task.Delay(5000).ContinueWith(_ =>
            {
                multiplier = 1;
                buttonBoostX4.Invoke((MethodInvoker)(() => buttonBoostX4.Enabled = true)); // Включаем кнопку обратно
            });
        }

        private void buttonAutoClicker_Click(object sender, EventArgs e)
        {
            buttonAutoClicker.Enabled = false; // Отключаем кнопку
            autoClickTimer = new Timer();
            autoClickTimer.Interval = 500; // Каждые 500 мс +1 клик
            autoClickTimer.Tick += (s, ev) => pictureBoxCharacter_MouseDown(null, null);
            autoClickTimer.Start();

            Task.Delay(5000).ContinueWith(_ =>
            {
                autoClickTimer.Stop();
                autoClickTimer.Dispose();
                buttonAutoClicker.Invoke((MethodInvoker)(() => buttonAutoClicker.Enabled = true)); // Включаем кнопку обратно
            });
        }
    }
}
