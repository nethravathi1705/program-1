using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPicViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
                //show the open dialog window, if user selects 
                //an image file load that file into yhe picturebox.
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Load (openFileDialog1.FileName);
            }
            else
            {

            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear the picture.
            //by setting the image property of the picturebox into null.
            pictureBox1.Image = null;
        }

        private void BackgroundButton_Click(object sender, EventArgs e)
        {
            //show the color dialog
            //if user selects a color then
            //set the color as background color of the picture box.
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }

        }
        private void Closebutton_Click(object sender, EventArgs e)
        {
            //close the form.
            //as we are closing the parent form
            //entire APP gets exited/closed
            this.Close();
        }

        private void stretchcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(stretchcheckBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }

        }

       
    }
    
}
