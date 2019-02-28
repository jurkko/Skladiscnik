using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Skladiščnik
{
    public partial class Form2 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        SqlDataReader dr;
        SqlParameter slika;
        string lokacijaslike;

        public string conString = "Data Source=DESKTOP-2KUD0UO;Initial Catalog=Skladiscnik;Integrated Security=True";
        SqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
            izhod2.MouseEnter += izhod2gumbHover;
            izhod2.MouseLeave += izhod2gumbLeave;

            mini2.MouseEnter += mini2gumbHover;
            mini2.MouseLeave += mini2gumbLeave;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void izhod2gumbHover(object sender, EventArgs e)
        {

            izhod2.BackColor = Color.FromArgb(233, 28, 28);
        }

        private void izhod2gumbLeave(object sender, EventArgs e)
        {
            izhod2.BackColor = Color.FromArgb(209, 228, 251);
        }

        private void mini2gumbHover(object sender, EventArgs e)
        {

            mini2.BackColor = Color.FromArgb(250, 143, 15);
        }

        private void mini2gumbLeave(object sender, EventArgs e)
        {
            mini2.BackColor = Color.FromArgb(209, 228, 251);
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

        private void izhod1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void circleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                //int a = oblika.SelectedIndex;
                string ime = imepredmeta.Text;
                string obl = oblika.SelectedItem.ToString();
                int vis = Convert.ToInt32(visina.Text);
                int sir = Convert.ToInt32(sirina.Text);
                int dol = Convert.ToInt32(dolzina.Text);
                byte[] slike = null;
                FileStream Stream = new FileStream(lokacijaslike, FileMode.Open,FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                slike = brs.ReadBytes((int)Stream.Length);


                cmd = new SqlCommand("INSERT INTO Predmet (Ime,Oblika,Višina,Širina,Dolžina,Slika) VALUES ('"+ime+"','"+obl+"','"+vis+"','"+sir+"','"+dol+"',@images)", con);

                MessageBox.Show("dodali ste nov predmet " + ime);
                cmd.Parameters.Add(new SqlParameter("@images", slike));
                cmd.ExecuteNonQuery();
                con.Close();
            }
}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajsliko_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    lokacijaslike = ofd.FileName.ToString();
                    pictureBox1.ImageLocation = lokacijaslike;
                }
            }
        }
    }
    
}
