using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sliding_Puzzle
{
    public partial class SplashScreen : Form
    {
        private Form1 f1;
        private Image image;

        public SplashScreen()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG (*.jpg)|*.jpg|IMG (*.img)|*.img|JPEG files(*.jpeg)|*.jpeg|PNG Files (*.png)|*.png";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Choosing file(picture)
                string location = openFileDialog1.FileName;
                fileName.Text = openFileDialog1.SafeFileName;

                //Opens the picture and show it
                image = Image.FromFile(location);
                Image newImage = ChangeImageSize(image, Preview.Size);
                Preview.Image = newImage;

                if (fileName.Text != "" && textBox1.Text != "")
                    button1.Enabled = true;

            }
        }
        private static Image ChangeImageSize(Image image, Size newSize)
        {
            Image newImage = new Bitmap(newSize.Width, newSize.Height);

            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }

            return newImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1();
            f1.ValueFromSS(textBox1.Text);
            f1.GetImageFile(image);

            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (fileName.Text != "" && textBox1.Text != "")
                button1.Enabled = true;
        }

    }
}
