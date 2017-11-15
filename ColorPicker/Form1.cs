using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorPicker();
        }
        

        private void colorPicker()
        {

            Bitmap bmp = new Bitmap(pictureBox1.BackgroundImage);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color gotColor = bmp.GetPixel(x, y);
                    gotColor = Color.FromArgb(gotColor.R, gotColor.G, gotColor.B);

                    PictureBox myPic = new PictureBox();
                    if (gotColor != Color.FromArgb(255, 255, 255))
                    {
                        myPic.BackColor = gotColor;
                    }
                    else
                    {
                        myPic.BackColor = gotColor;
                    }
                    myPic.Size = new Size(1, 1);
                    myPic.Location = new Point(x, y);
                    Controls.Add(myPic);
                    listBox1.Items.Add(gotColor.ToString());

                    //listBox1.Items.Add(gotColor.ToString());
                    //label1.Text = listBox1.Items.Count.ToString();

                    //PictureBox myPicture = new PictureBox();
                    //myPicture.BackColor = gotColor;
                    //Controls.Add(myPicture);

                }
            }
            
        }
    }
}
