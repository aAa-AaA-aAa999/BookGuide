using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    public partial class MainWind : Form
    {
        public MainWind()
        {
            InitializeComponent();
            button1.Paint += button1_Paint;
        }

        private void MainWind_Load(object sender, EventArgs e)
        {



        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {

            LinearGradientBrush linGrBrush = new LinearGradientBrush(new Point(0, button1.Height + 50), new Point(button1.Width, -50), Color.FromArgb(255, 245, 134, 52), Color.FromArgb(255, 236, 38, 143));
            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, button1.Width, button1.Height);
            using (Font font1 = new Font("Century Gothic", 25, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                string text = "Список\n   книг";
                // Определение размера текста
                SizeF textSize = e.Graphics.MeasureString(text, font1);

                // Определение положения для текста (центрирование по горизонтали и вертикали)
                float x = (button1.Width - textSize.Width) / 2;
                float y = (button1.Height - textSize.Height) / 2;

                // Рисование текста
                e.Graphics.DrawString(text, font1, Brushes.White, x, y);
            }
        }

        private void user_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms.OfType<Profile>().Count() == 0) {
                Profile profile = new Profile();
                profile.Show();
            }
            else
            {
                MessageBox.Show("У вас уже открыт профиль:D", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }
        private void list_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms.OfType<ListOfBooks>().Count() == 0)
            {
                ListOfBooks listOfBooks = new ListOfBooks();
                listOfBooks.Show();
            }
            else
            {
                MessageBox.Show("У вас уже открыт список;)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }
    }
}
