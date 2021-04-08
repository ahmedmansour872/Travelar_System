using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelar_System
{
    public partial class Form6 : Form
    {
        private Image image;

        public Form6(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

       

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
