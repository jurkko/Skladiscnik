using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiščnik
{
    public partial class Form2 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        
        Point lastPoint;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
            
        }

        private void Form2_Move(object sender, EventArgs e)
        {
          
        }

        private void Form2_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            panelanav.Height = prihodi.Height;
            panelanav.Top = prihodi.Top;

            panel9.Visible = false;
            panel10.Visible = true;
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zaloga_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel10.Visible = false;
            

            panelanav.Height = zaloga.Height;
            panelanav.Top = zaloga.Top;
            
        }

        private void narocila_Click(object sender, EventArgs e)
        {
            panelanav.Height = Dobavitelji.Height;
            panelanav.Top = Dobavitelji.Top;
            panel9.Visible = false;
            panel10.Visible = false;
            
        }

        private void dobavnice_Click(object sender, EventArgs e)
        {
            
            panelanav.Height = Narocila.Height;
            panelanav.Top = Narocila.Top;
            panel9.Visible = false;
            panel10.Visible = false;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            panel10.Visible = true;

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
