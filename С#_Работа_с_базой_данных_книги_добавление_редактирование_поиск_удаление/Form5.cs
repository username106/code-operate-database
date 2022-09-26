using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        Point Cordinate;
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Cordinate.X;
                this.Top += e.Y - Cordinate.Y;
            }
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            Cordinate = new Point(e.X, e.Y);
        }
    }
}
