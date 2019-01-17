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
            listPanel.Add(panelazaloga);
            listPanel.Add(panelaodhodi);
            listPanel[index].BringToFront();
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
            index = 1;
            panelanav.Height = prihodi.Height;
            panelanav.Top = prihodi.Top;
            listPanel[index].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zaloga_Click(object sender, EventArgs e)
        {
            index = 0;
            panelanav.Height = zaloga.Height;
            panelanav.Top = zaloga.Top;
            listPanel[index].BringToFront();
        }

        private void narocila_Click(object sender, EventArgs e)
        {
            panelanav.Height = narocila.Height;
            panelanav.Top = narocila.Top;
        }

        private void dobavnice_Click(object sender, EventArgs e)
        {
            panelanav.Height = dobavnice.Height;
            panelanav.Top = dobavnice.Top;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
