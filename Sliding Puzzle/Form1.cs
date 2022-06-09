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
    public partial class Form1 : Form
    {
        private string playerName;
        private int time = 0;
        private List<Image> images;
        private List<PictureBox> imageBoxes;
        private Image image;

        public Form1()
        {
            KeyPreview = true;
            images = new List<Image>(15);
            imageBoxes = new List<PictureBox>();
            InitializeComponent();
            TimeCount.Stop();

            imageBoxes.Add(pictureBox1);
            imageBoxes.Add(pictureBox2);
            imageBoxes.Add(pictureBox3);
            imageBoxes.Add(pictureBox4);
            imageBoxes.Add(pictureBox5);
            imageBoxes.Add(pictureBox6);
            imageBoxes.Add(pictureBox7);
            imageBoxes.Add(pictureBox8);
            imageBoxes.Add(pictureBox9);
            imageBoxes.Add(pictureBox10);
            imageBoxes.Add(pictureBox11);
            imageBoxes.Add(pictureBox12);
            imageBoxes.Add(pictureBox13);
            imageBoxes.Add(pictureBox14);
            imageBoxes.Add(pictureBox15);
            imageBoxes.Add(pictureBox16);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void TimeCount_Tick(object sender, EventArgs e)
        {
            time++;
            Time.Text = time.ToString() + " Seconds.";
        }

        public void ValueFromSS(string value)
        {
            //function only for playerName
            pName.Text = value;
            playerName = value;
        }

        public void GetImageFile(Image pic)
        {
            image = pic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            TimeCount.Start();
            MixPic();
            imageBoxes[15].Image = null;

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

        private static Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        public void ShowImage()
        {
            //cut and show the image on the screen
            Image tempImg;
            tempImg = ChangeImageSize(image, tableLayoutPanel1.Size);

            int width = tempImg.Width / 4;//רבע מאורך הקטע
            int height = tempImg.Height / 4;//רבע מגובה הקטע

            for (int i = 0; i < 4; i++)//this is Y
            {
                for (int j = 0; j < 4; j++)//this is X
                {
                    Rectangle area = new Rectangle(j * width, i * height, width, height);
                    images.Add(CropImage(tempImg, area));
                }
            }
            for (int i = 0; i < 15; i++)
            {
                imageBoxes[i].Image = images[i];
            }

        }

        private void show_Click(object sender, EventArgs e)
        {
            ShowImage();
            TimeCount.Stop();
            time = 0;
            Time.Text = time.ToString() + " seconds.";
            pictureBox16.Image = null;
            button2.Enabled = false;
        }

        public void MixPic()
        { //הגרלה של אותו מספר
            int[] indexs = new int[15];
            FillRandom(indexs);
            for (int i = 0; i < indexs.Length; i++)
            {
                imageBoxes[i].Image = images[indexs[i]];
            }
        }

        public static void FillRandom(int[] arr)
        {
            Random r = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 15; i++)
                numbers.Add(i);
            int insertIndex = 0;
            while (numbers.Count > 0)
            {
                int rndNum = r.Next(0, numbers.Count);
                arr[insertIndex++] = numbers[rndNum];
                numbers.RemoveAt(rndNum);
            }
        }

        private int[] Check(int location)
        {
            //arr[0] is True or False
            //arr[1] is the location of the empty tilt
            //arr[2] is Where to move (Left, Right, Up, Down) -- (+4 is Up, -4 is Down, +1 is Right, -1 is Left)
            int[] arr = new int[3];
            switch (location)
            {
                case 5:
                case 6:
                case 9:
                case 10:
                    if (imageBoxes[location - 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 4;
                        arr[2] = -4;
                    }
                    if (imageBoxes[location + 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 4;
                        arr[2] = 4;
                    }
                    if (imageBoxes[location - 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 1;
                        arr[2] = -1;
                    }
                    if (imageBoxes[location + 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 1;
                        arr[2] = 1;
                    }
                    break;

                case 1:
                case 2:
                    if (imageBoxes[location - 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 1;
                        arr[2] = -1;
                    }
                    if (imageBoxes[location + 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 1;
                        arr[2] = 1;
                    }
                    if (imageBoxes[location + 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 4;
                        arr[2] = 4;
                    }
                    break;

                case 4:
                case 8:
                    if (imageBoxes[location - 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 4;
                        arr[2] = -4;
                    }
                    if (imageBoxes[location + 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 4;
                        arr[2] = 4;
                    }
                    if (imageBoxes[location + 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 1;
                        arr[2] = 1;
                    }
                    break;

                case 13:
                case 14:
                    if (imageBoxes[location - 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 4;
                        arr[2] = -4;
                    }
                    if (imageBoxes[location + 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 1;
                        arr[2] = 1;
                    }
                    if (imageBoxes[location - 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 1;
                        arr[2] = -1;
                    }
                    break;

                case 7:
                case 11:
                    if (imageBoxes[location - 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 4;
                        arr[2] = -4;
                    }
                    if (imageBoxes[location + 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 4;
                        arr[2] = 4;
                    }
                    if (imageBoxes[location - 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 1;
                        arr[2] = -1;
                    }
                    break;

                case 0:
                    if (imageBoxes[location + 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 1;
                        arr[2] = 1;
                    }
                    if (imageBoxes[location + 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 4;
                        arr[2] = 4;
                    }
                    break;

                case 3:
                    if (imageBoxes[location - 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 1;
                        arr[2] = -1;
                    }
                    if (imageBoxes[location + 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 4;
                        arr[2] = 4;
                    }
                    break;

                case 12:
                    if (imageBoxes[location + 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location + 1;
                        arr[2] = 1;
                    }
                    if (imageBoxes[location - 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 4;
                        arr[2] = -4;
                    }
                    break;

                case 15:
                    if (imageBoxes[location - 1].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 1;
                        arr[2] = -1;
                    }
                    if (imageBoxes[location - 4].Image == null)
                    {
                        arr[0] = 1;
                        arr[1] = location - 4;
                        arr[2] = -4;
                    }
                    break;
                default:
                    break;
            }
            return arr;
        }


        private void MoveImage(int location)
        {
            int[] places = Check(location);

            if (places[0] == 1)
            {
                if (places[2] == 1)
                {
                    imageBoxes[places[1]].Image = imageBoxes[places[1] - 1].Image;
                    imageBoxes[places[1] - 1].Image = null;
                }
                if (places[2] == -1)
                {
                    imageBoxes[places[1]].Image = imageBoxes[places[1] + 1].Image;
                    imageBoxes[places[1] + 1].Image = null;
                }
                if (places[2] == 4)
                {
                    imageBoxes[places[1]].Image = imageBoxes[places[1] - 4].Image;
                    imageBoxes[places[1] - 4].Image = null;
                }

                if (places[2] == -4)
                {
                    imageBoxes[places[1]].Image = imageBoxes[places[1] + 4].Image;
                    imageBoxes[places[1] + 4].Image = null;
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            MoveImage(15);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MoveImage(14);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            MoveImage(13);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MoveImage(12);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MoveImage(11);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MoveImage(10);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MoveImage(9);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MoveImage(8);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MoveImage(7);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MoveImage(6);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MoveImage(5);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MoveImage(4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MoveImage(3);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MoveImage(2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MoveImage(1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MoveImage(0);
        }

        public bool GameFinished()
        {
            bool complete = true;
            List<Image> ImageEnd = new List<Image>();

            ImageEnd.Add(pictureBox1.Image);
            ImageEnd.Add(pictureBox2.Image);
            ImageEnd.Add(pictureBox3.Image);
            ImageEnd.Add(pictureBox4.Image);
            ImageEnd.Add(pictureBox5.Image);
            ImageEnd.Add(pictureBox6.Image);
            ImageEnd.Add(pictureBox7.Image);
            ImageEnd.Add(pictureBox8.Image);
            ImageEnd.Add(pictureBox9.Image);
            ImageEnd.Add(pictureBox10.Image);
            ImageEnd.Add(pictureBox11.Image);
            ImageEnd.Add(pictureBox12.Image);
            ImageEnd.Add(pictureBox13.Image);
            ImageEnd.Add(pictureBox14.Image);
            ImageEnd.Add(pictureBox15.Image);

            for (int i = 0; i < ImageEnd.Count; i++)
            {
                if (ImageEnd[i] != images[i])
                {
                    complete = false;
                }
            }
            return complete;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GameFinished())
            {
                TimeCount.Stop();
                MessageBox.Show("Congratulation You have complete the puzzle");
            }
            else
            {
                TimeCount.Stop();
                MessageBox.Show("You didn't resolve the puzzle... please continue");
                TimeCount.Start();
            }
        }
    }
}
