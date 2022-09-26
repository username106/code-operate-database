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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_MouseEnter(object sender, EventArgs e)
        {
            Add.ForeColor = Color.Red;
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            Add.ForeColor = Color.Black;
        }

        private void Edi_MouseEnter(object sender, EventArgs e)
        {
            Edi.ForeColor = Color.Red;
        }

        private void Edi_MouseLeave(object sender, EventArgs e)
        {
            Edi.ForeColor = Color.Black;
        }

        private void Del_MouseEnter(object sender, EventArgs e)
        {
            Del.ForeColor = Color.Red;
        }

        private void Del_MouseLeave(object sender, EventArgs e)
        {
            Del.ForeColor = Color.Black;
        }

        private void Srch_MouseEnter(object sender, EventArgs e)
        {
            Srch.ForeColor = Color.Red;
        }

        private void Srch_MouseLeave(object sender, EventArgs e)
        {
           Srch.ForeColor = Color.Black;
        }
        Point Cordinate;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Cordinate.X;
                this.Top += e.Y - Cordinate.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Cordinate = new Point(e.X, e.Y);
        }

        private void Srch_Click(object sender, EventArgs e)
        {
            String SrchBook = Srch.Text;
            Form4 dlg = new Form4();
            dlg.Show(this);
            
        }

        private void ShowDB_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.Show(this);
        }

        private void ShowDB_MouseEnter(object sender, EventArgs e)
        {
            ShowDB.ForeColor = Color.Red;
        }

        private void ShowDB_MouseLeave(object sender, EventArgs e)
        {
            ShowDB.ForeColor = Color.Black;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.Show(this);
        }

        private void Edi_Click(object sender, EventArgs e)
        {
            Form5 dlg = new Form5();
            dlg.Show(this);
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Form6 dlg = new Form6();
            dlg.Show(this);
        }
    }
}
