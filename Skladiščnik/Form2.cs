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
        int counter;


        public string conString = "Data Source=DESKTOP-2KUD0UO;Initial Catalog=Skladiscnik;Integrated Security=True";
        SqlCommand cmd;

        public Form2()
        {
            listPanel.Add(panel9);
            listPanel.Add(panel10);

            listPanel.Add(panel11);

            listPanel.Add(panel12);
            //custum gumba miniziraj in izhod
            InitializeComponent();
            izhod2.MouseEnter += izhod2gumbHover;
            izhod2.MouseLeave += izhod2gumbLeave;

            mini2.MouseEnter += mini2gumbHover;
            mini2.MouseLeave += mini2gumbLeave;


            //sql connection string + nafilaj datagrid iz baze
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Predmet]", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(pr);
            da.Fill(ds);
            datagridpredmeti.DataSource = ds;
            datagridpredmeti.DataMember = ds.Tables[0].ToString();

            //datagrid predmeti oblikovanje
            
            datagridpredmeti.BorderStyle = BorderStyle.None;
            datagridpredmeti.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            datagridpredmeti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridpredmeti.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            datagridpredmeti.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            datagridpredmeti.BackgroundColor = Color.White;
            datagridpredmeti.EnableHeadersVisualStyles = false;
            datagridpredmeti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridpredmeti.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            datagridpredmeti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            var totalHeight = datagridpredmeti.Rows.GetRowsHeight(DataGridViewElementStates.None);
            var totalWidth = datagridpredmeti.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            datagridpredmeti.RowTemplate.Height = 40;
            datagridpredmeti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagridpredmeti.Columns[7].Visible = false;
            this.datagridpredmeti.Columns[3].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);
           

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
            panel11.Visible = false;
            panel12.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zaloga_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;



            panelanav.Height = zaloga.Height;
            panelanav.Top = zaloga.Top;
            
        }

        private void narocila_Click(object sender, EventArgs e)
        {
            panelanav.Height = Dobavitelji.Height;
            panelanav.Top = Dobavitelji.Top;

            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = true;

        }

        private void dobavnice_Click(object sender, EventArgs e)
        {
            
            panelanav.Height = Narocila.Height;
            panelanav.Top = Narocila.Top;

            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = true;
            panel12.Visible = false;

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
                int kol = Convert.ToInt32(kolicina.Text); 
                int vis = Convert.ToInt32(visina.Text);
                int sir = Convert.ToInt32(sirina.Text);
                int dol = Convert.ToInt32(dolzina.Text);
                byte[] slike = null;
                FileStream Stream = new FileStream(lokacijaslike, FileMode.Open,FileAccess.Read);
                BinaryReader brs = new BinaryReader(Stream);
                slike = brs.ReadBytes((int)Stream.Length);


                cmd = new SqlCommand("INSERT INTO Predmet (Ime,Oblika,Kolicina,Višina,Širina,Dolžina,Slika) VALUES ('"+ime+"','"+obl+"','"+kol+"','"+vis+"','"+sir+"','"+dol+"',@images)", con);

                MessageBox.Show("dodali ste nov predmet " + ime);
                cmd.Parameters.Add(new SqlParameter("@images", slike));
                cmd.ExecuteNonQuery();
                con.Close();
            }


            SqlConnection con2 = new SqlConnection(conString);
            con2.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Predmet]", con2);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(pr);
            da.Fill(ds);
            datagridpredmeti.DataSource = ds;
            datagridpredmeti.DataMember = ds.Tables[0].ToString();
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

        private void datagridpredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
