using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comparission_smooting_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openID.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openID.ShowDialog();

            string ChooseFle = "";

            ChooseFle = openID.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.Image = Image.FromFile(ChooseFle);
            pictureBox2.Image = Image.FromFile(ChooseFle);
            pictureBox3.Image = Image.FromFile(ChooseFle);
            pictureBox4.Image = Image.FromFile(ChooseFle);
        }
           
            

    }

}
