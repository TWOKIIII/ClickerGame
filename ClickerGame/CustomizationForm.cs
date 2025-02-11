using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class CustomizationForm : Form
    {
        public Image SelectedCharacter { get; private set; }
        public CustomizationForm()
        {
            InitializeComponent();
        }

        private void SelectCharacter(Image image, PictureBox selectedPictureBox)
        {
            SelectedCharacter = image;
            foreach (Control control in Controls)
            {
                if (control is PictureBox pb)
                    pb.BorderStyle = BorderStyle.FixedSingle;
            }
            selectedPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (SelectedCharacter != null)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Выберите персонажа!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectCharacter(pictureBox1.Image, pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SelectCharacter(pictureBox2.Image, pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SelectCharacter(pictureBox3.Image, pictureBox3);
        }
    }
}
