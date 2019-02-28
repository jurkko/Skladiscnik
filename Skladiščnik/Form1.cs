using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Skladiščnik
{
    public partial class Form1 : Form
    {

        public string conString = "Data Source=DESKTOP-2KUD0UO;Initial Catalog=Skladiscnik;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            izhod1.MouseEnter += izhod1gumbHover;
            izhod1.MouseLeave += izhod1gumbLeave;

            mini1.MouseEnter += mini1gumbHover;
            mini1.MouseLeave += mini1gumbLeave;

            
        }

        private void izhod1gumbHover(object sender, EventArgs e)
        {
            
            izhod1.BackColor = Color.FromArgb(233, 28, 28);
        }

        private void izhod1gumbLeave(object sender, EventArgs e)
        {
            izhod1.BackColor = Color.FromArgb(209, 228, 251);
        }

        private void mini1gumbHover(object sender, EventArgs e)
        {

            mini1.BackColor = Color.FromArgb(250, 143, 15);
        }

        private void mini1gumbLeave(object sender, EventArgs e)
        {
            mini1.BackColor = Color.FromArgb(209, 228, 251);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            textBox2.PasswordChar = '*';
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string preveri = "Select * from Uporabniki Where Uporabniskoime= '"+textBox1.Text.Trim()+"' and Geslo = '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(preveri, con);
                DataTable dttbl = new DataTable();
                sda.Fill(dttbl);
                if (dttbl.Rows.Count == 1)
                {
                   
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    
                    
                } else
                {
                    MessageBox.Show(" Napacno geslo ali uporabnisko ime");
                }

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(255, 255, 255);

            pictureBox2.Image= Properties.Resources.uporabnik1;
            pictureBox3.Image = Properties.Resources.geslo2;
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(255, 255, 255);
            pictureBox3.Image = Properties.Resources.geslo1;
            pictureBox2.Image = Properties.Resources.uporabnik2;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void izhod1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mini1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
