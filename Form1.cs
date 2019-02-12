using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);

                    bitmapImage = new Bitmap(newImage, 320, 240);

                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArayFromBitmap();

        }

        private void SetBitmapFromAray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        private void SetArayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Green;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Green = col.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int iWidth = 320;
            int iHeight = 240;
            Color[,] TempArray = new Color[320, 240];
            ImageArray = TempArray;
            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void Invert_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 255 - Red, 255 - Green, 255 - Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Red = Red + 5;
                    Blue = Blue + 5;
                    Green = Green + 5;

                    if (Red > 255)
                    {
                        Red = Red - 5;
                    }
                    else
                    {
                        Convert.ToByte(Red);
                    }
                    if (Green > 255)
                    {
                        Green = Green - 5;
                    }
                    else
                    {
                        Convert.ToByte(Green);
                    }
                    if (Blue > 255)
                    {
                        Blue = Blue - 5;
                    }
                    else
                    {
                        Convert.ToByte(Blue);
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;


                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Red = Red - 5;
                    Blue = Blue - 5;
                    Green = Green - 5;

                    if (Red < 0)
                    {
                        Red = Red + 5;
                    }
                    else
                    {
                        Convert.ToByte(Red);
                    }
                    if (Green < 0)
                    {
                        Green = Green + 5;
                    }
                    else
                    {
                        Convert.ToByte(Green);
                    }
                    if (Blue < 0)
                    {
                        Blue = Blue + 5;
                    }
                    else
                    {
                        Convert.ToByte(Blue);
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Red = Red + 60;
                    Blue = Blue - 20;

                    if (Red > 255)
                    {
                        Red = Red - 60;
                    }
                    else
                    {
                        Red = Convert.ToByte(Red);
                    }

                    if (Blue < 0)
                    {
                        Blue = Blue + 20;
                    }
                    else
                    {
                        Blue = Convert.ToByte(Blue);
                    }
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue, AvgRed, AvgBlue, AvgGreen;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            AvgRed = 0;
            AvgGreen = 0;
            AvgBlue = 0;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    AvgRed = AvgRed + Red;
                    AvgGreen = AvgGreen + Green;
                    AvgBlue = AvgBlue + Blue;
                }
            }

            AvgRed = AvgRed / (320 * 240);
            AvgGreen = AvgGreen / (320 * 240);
            AvgBlue = AvgBlue / (320 * 240);
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;
                    //Get the green element of the color

                    if (Red > AvgRed)
                    {
                        Red = 255;
                    }
                    else
                    {
                        Red = 0;
                    }
                    if (Green > AvgGreen)
                    {
                        Green = 255;
                    }
                    else
                    {
                        Green = 0;
                    }
                    if (Blue > AvgBlue)
                    {
                        Blue = 255;
                    }
                    else
                    {
                        Blue = 0;
                    }
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int Red, Green, Blue;
            int Average;
            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel



            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Average = (Red + Green + Blue) / 3;

                    Color newColor = Color.FromArgb(255, Average, Average, Average);
                    ImageArray[i, j] = newColor;

                }
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnExtractR_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Red;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;

                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnExtractB_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            Byte Blue;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipHoriz_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < (iWidth / 2); i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    Color temp;

                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[319 - i, j];
                    ImageArray[319 - i, j] = temp;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipVert_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < (iHeight / 2); j++)
                {
                    Color col = ImageArray[i, j];
                    Color temp;

                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[i, 239 - j];

                    ImageArray[i, 239 - j] = temp;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            /// Process the array data here!!!

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel

            for (int i = 0; i < (iWidth / 2); i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];
                    Color temp;

                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[319 - i, 239 - j];

                    ImageArray[319 - i, 239 - j] = temp;

                }
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int AvgBlue, AvgRed, AvgGreen;
            Color[,] TempArray = new Color[320, 240];

            for (int i = 1; i < 320; i++)
            {
                for (int j = 1; j < 240; j++)
                {
                    Color col = ImageArray[i, j];

                    if (i == 0 && j == 0)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i, j + 1].G + ImageArray[i + 1, j + 1].G + ImageArray[i + 1, j].G) / 4;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i, j + 1].B + ImageArray[i + 1, j + 1].B + ImageArray[i + 1, j].B) / 4;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i, j + 1].R + ImageArray[i + 1, j + 1].R + ImageArray[i + 1, j].R) / 4;
                    }
                    else if (i == 319 && j == 0)
                    {

                        AvgGreen = (ImageArray[i, j].G + ImageArray[i - 1, j].G + ImageArray[i - 1, j + 1].G + ImageArray[i, j + 1].G) / 4;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i - 1, j].B + ImageArray[i - 1, j + 1].B + ImageArray[i, j + 1].B) / 4;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i - 1, j].R + ImageArray[i - 1, j + 1].R + ImageArray[i, j + 1].R) / 4;
                    }
                    else if (i == 0 && j == 239)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i, j - 1].G + ImageArray[i + 1, j - 1].G + ImageArray[i + 1, j].G) / 4;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i, j - 1].B + ImageArray[i + 1, j - 1].B + ImageArray[i + 1, j].B) / 4;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i, j - 1].R + ImageArray[i + 1, j - 1].R + ImageArray[i + 1, j].R) / 4;
                    }
                    else if (i == 319 && j == 239)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i - 1, j].G + ImageArray[i - 1, j - 1].G + ImageArray[i, j - 1].G) / 4;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i - 1, j].B + ImageArray[i - 1, j - 1].B + ImageArray[i, j - 1].B) / 4;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i - 1, j].R + ImageArray[i - 1, j - 1].R + ImageArray[i, j - 1].R) / 4;
                    }
                    else if (i == 0)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i, j - 1].G + ImageArray[i, j + 1].G + ImageArray[i + 1, j - 1].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j + 1].G) / 6;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i, j - 1].R + ImageArray[i, j + 1].R + ImageArray[i + 1, j - 1].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j + 1].R) / 6;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i, j - 1].B + ImageArray[i, j + 1].B + ImageArray[i + 1, j - 1].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j + 1].B) / 6;
                    }
                    else if (i == 319)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i, j - 1].G + ImageArray[i, j + 1].G + ImageArray[i - 1, j + 1].G + ImageArray[i - 1, j].G + ImageArray[i - 1, j - 1].G) / 6;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i, j - 1].R + ImageArray[i, j + 1].R + ImageArray[i - 1, j + 1].R + ImageArray[i - 1, j].R + ImageArray[i - 1, j - 1].R) / 6;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i, j - 1].B + ImageArray[i, j + 1].B + ImageArray[i - 1, j + 1].B + ImageArray[i - 1, j].B + ImageArray[i - 1, j - 1].B) / 6;
                    }
                    else if (j == 0)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i, j + 1].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j + 1].G + ImageArray[i - 1, j].G + ImageArray[i - 1, j - 1].G) / 6;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i, j + 1].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j + 1].R + ImageArray[i - 1, j].R + ImageArray[i - 1, j - 1].R) / 6;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i, j + 1].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j + 1].B + ImageArray[i - 1, j].B + ImageArray[i - 1, j - 1].B) / 6;
                    }
                    else if (j == 239)
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i - 1, j].G + ImageArray[i + 1, j].G + ImageArray[i - 1, j - 1].G + ImageArray[i, j - 1].G + ImageArray[i + 1, j - 1].G) / 6;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i - 1, j].R + ImageArray[i + 1, j].R + ImageArray[i - 1, j - 1].R + ImageArray[i, j - 1].R + ImageArray[i + 1, j - 1].R) / 6;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i - 1, j].B + ImageArray[i + 1, j].B + ImageArray[i - 1, j - 1].B + ImageArray[i, j - 1].B + ImageArray[i + 1, j - 1].B) / 6;
                    }
                    else
                    {
                        AvgGreen = (ImageArray[i, j].G + ImageArray[i - 1, j].G + ImageArray[i - 1, j + 1].G + ImageArray[i, j + 1].G + ImageArray[i + 1, j + 1].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j - 1].G + ImageArray[i, j - 1].G + ImageArray[i - 1, j - 1].G) / 9;
                        AvgBlue = (ImageArray[i, j].B + ImageArray[i - 1, j].B + ImageArray[i - 1, j + 1].B + ImageArray[i, j + 1].B + ImageArray[i + 1, j + 1].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j - 1].B + ImageArray[i, j - 1].B + ImageArray[i - 1, j - 1].B) / 9;
                        AvgRed = (ImageArray[i, j].R + ImageArray[i - 1, j].R + ImageArray[i - 1, j + 1].R + ImageArray[i, j + 1].R + ImageArray[i + 1, j + 1].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j - 1].R + ImageArray[i, j - 1].R + ImageArray[i - 1, j - 1].R) / 9;
                    }

                    Color newColor = Color.FromArgb(255, AvgRed, AvgGreen, AvgBlue);

                    TempArray[i, j] = newColor;

                }
            }

            for (int i = 1; i < 320; i++)
            {
                for (int j = 1; j < 240; j++)
                {
                    ImageArray[i, j] = TempArray[i, j];
                }
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < (iWidth / 2); i++)
            {
                for (int j = 0; j < (iHeight / 2); j++)
                {
                    Color col = ImageArray[i, j];
                    Color temp;

                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[160 + i, 120 + j];

                    ImageArray[160 + i, 120 + j] = temp;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Red, Green, Blue;
            int Average;
            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Get the green element of the color
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Average = (Red + Green + Blue) / 3;

                    Color newColor = Color.FromArgb(255, Average, Average, Average);
                    ImageArray[i, j] = newColor;
                }
            }
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    int iValue = ImageArray[i, j].G;
                    int k = i - 1;

                    while (k >= 0)
                    {
                        if (ImageArray[k, j].G > iValue)
                        {
                            ImageArray[k + 1, j] = ImageArray[k, j];
                        }
                        else
                        {
                            break;
                        }
                        k--;
                    }
                    ImageArray[k + 1, j] = Color.FromArgb(255, iValue, iValue, iValue);
                }
            }
           SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnScroll_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int iWidth = 320;
            int iHeight = 240;
            Color[,] TempArray = new Color[320, 240];

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {

                    if(j + 40 < 240)
                    {
                        TempArray[i , j + 40] = ImageArray[i, j];
                    }
                    else
                    {
                        TempArray[i, j - 200] = ImageArray[i, j];
                    }
                }
            }
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = TempArray[i, j];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPixellate_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;
            int iWidth = 320;
            int iHeight = 240;
            Color[,] TempArray = new Color[320, 240];
            
            for (int i = 4; i < iWidth; i = i + 4)
            {
                for (int j = 4; j < iHeight; j = j + 4)
                {
                    for (int k = 4; k > 0; k--)
                    {
                        for (int l = 4; l > 0; l--)
                        {
                            ImageArray[i - k, j - l] = (ImageArray[i - 4, j - 4]);
                        }
                    }
                }
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }
    }
}

