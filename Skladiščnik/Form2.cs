using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Skladiščnik
{
    public partial class Form2 : Form
    {
        List<Panel> listPanel = new List<Panel>();

        List<String> artikliNarocilaList = new List<String>();

        List<int> kolicnaArtikliNarocilaList = new List<int>();

        List<DateTime> rokDobaveNarocila = new List<DateTime>();

        List<String> artikliDobavaList = new List<String>();

        List<int> kolicnaArtikliDobavaList = new List<int>();

        List<String> imenaNarocilPrevoz = new List<String>();

        List<String> imenaDobavPrevoz = new List<String>();

        SqlDataReader dr;
        SqlParameter slika;
        string lokacijaslike;
        int counter;


        public string conString = "Data Source=DESKTOP-58RBMLJ;Initial Catalog=Skladiscnik;Integrated Security=True";
        SqlCommand cmd;
        SqlCommand insertArtikle;

        public Form2()
        {
            listPanel.Add(panel9);
            listPanel.Add(panel10);

            listPanel.Add(panel11);

            listPanel.Add(panel12);
            //custum gumba miniziraj in izhod
            InitializeComponent();
            fillArtikelCombobox();
            izhod2.MouseEnter += izhod2gumbHover;
            izhod2.MouseLeave += izhod2gumbLeave;

            mini2.MouseEnter += mini2gumbHover;
            mini2.MouseLeave += mini2gumbLeave;


            //sql connection string + nafilaj datagrid iz baze
            fillDataGridPredmeti();

            fillDataGridNarocila();

            fillDataGridDobave();

            fillDataGridPrevozi();

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

            datagridnarocila.BorderStyle = BorderStyle.None;
            datagridnarocila.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            datagridnarocila.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            datagridnarocila.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            datagridnarocila.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            datagridnarocila.BackgroundColor = Color.White;
            datagridnarocila.EnableHeadersVisualStyles = false;
            datagridnarocila.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridnarocila.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            datagridnarocila.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            var totalHeight2 = datagridnarocila.Rows.GetRowsHeight(DataGridViewElementStates.None);
            var totalWidth2 = datagridnarocila.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            datagridnarocila.RowTemplate.Height = 40;
            datagridnarocila.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            datagridnarocila.Columns[3].Visible = false;
            this.datagridnarocila.Columns[0].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            var totalHeight3 = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.None);
            var totalWidth3 = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[0].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            var totalHeight4 = dataGridView2.Rows.GetRowsHeight(DataGridViewElementStates.None);
            var totalWidth4 = dataGridView2.Columns.GetColumnsWidth(DataGridViewElementStates.None);
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.Columns[3].Visible = false;
            this.dataGridView2.Columns[0].DefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);


        }

        private void fillDataGridPrevozi()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Prevoz]", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(pr);
            da.Fill(ds);
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = ds.Tables[0].ToString();
        }

        private void fillDataGridPredmeti()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Predmet]", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(pr);
            da.Fill(ds);
            datagridpredmeti.DataSource = ds;
            datagridpredmeti.DataMember = ds.Tables[0].ToString();
        }

        private void fillDataGridDobave()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Dobava]", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(pr);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();

            SqlDataReader reader;
            try
            {
                reader = pr.ExecuteReader();

                while (reader.Read())
                {
                    string imeDobave = reader.GetString(1);
                    comboBox4.Items.Add(imeDobave);
                }
                reader.Close();
            }
            catch (Exception e)
            {

            }
        }

        private void fillDataGridNarocila()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Narocilo]", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(pr);
            da.Fill(ds);
            datagridnarocila.DataSource = ds;
            datagridnarocila.DataMember = ds.Tables[0].ToString();

            SqlDataReader reader;
            try
            {
                reader = pr.ExecuteReader();

                while (reader.Read())
                {
                    string imeNarocila = reader.GetString(1);
                    comboBox5.Items.Add(imeNarocila);
                }
                reader.Close();
            }
            catch (Exception e)
            {

            }

        }

        private void fillArtikelCombobox()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr = new SqlCommand("SELECT * FROM [Predmet]", con);
            SqlDataReader reader;
            try
            {
                reader = pr.ExecuteReader();

                while (reader.Read())
                {
                    string imePredmeta = reader.GetString(1);
                    artikelListCombo.Items.Add(imePredmeta);
                    comboBox1.Items.Add(imePredmeta);
                    comboBox2.Items.Add(imePredmeta);
                    comboBox3.Items.Add(imePredmeta);
                }
                reader.Close();
            }
            catch (Exception e)
            {

            }
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
                SqlCommand dobiPredmete = new SqlCommand("SELECT Ime FROM Predmet", con);
                SqlDataReader reader;

                List<String> imena = new List<String>();

                try
                {
                    reader = dobiPredmete.ExecuteReader();

                    while (reader.Read())
                    {
                        String imePredmeta = reader.GetString(0);
                        imena.Add(imePredmeta);
                    }
                    reader.Close();
                }
                catch (Exception ea)
                {

                }

                if (oblika.SelectedIndex < 0 || string.IsNullOrEmpty(imepredmeta.Text) || string.IsNullOrEmpty(kolicina.Text) || string.IsNullOrEmpty(visina.Text) || string.IsNullOrEmpty(sirina.Text) || string.IsNullOrEmpty(dolzina.Text))
                { MessageBox.Show("Prosim izpolnite vsa polja."); }

                else
                {
                    //int a = oblika.SelectedIndex;
                    string ime = imepredmeta.Text;
                    string obl = oblika.SelectedItem.ToString();
                    int kol, vis, sir, dol;

                    Boolean isNum1 = int.TryParse(kolicina.Text, out kol);
                    Boolean isNum2 = int.TryParse(visina.Text, out vis);
                    Boolean isNum3 = int.TryParse(sirina.Text, out sir);
                    Boolean isNum4 = int.TryParse(dolzina.Text, out dol);


                    if (imena.Contains(ime))
                    {
                        MessageBox.Show("Predmet z imenom " + ime + " že obstaja!");
                    }

                    else
                    {
                        if (isNum1.Equals(true) && isNum2.Equals(true) && isNum3.Equals(true) && isNum4.Equals(true))
                        {
                            if (string.IsNullOrEmpty(lokacijaslike))
                            {

                                /*byte[] slike = null;
                                FileStream Stream = new FileStream(lokacijaslike, FileMode.Open, FileAccess.Read);
                                BinaryReader brs = new BinaryReader(Stream);
                                slike = brs.ReadBytes((int)Stream.Length);

                                 ,@images*/


                                cmd = new SqlCommand("INSERT INTO Predmet (Ime,Oblika,Kolicina,Višina,Širina,Dolžina) VALUES ('" + ime + "','" + obl + "','" + kol + "','" + vis + "','" + sir + "','" + dol + "')", con);

                                MessageBox.Show("dodali ste nov predmet " + ime);
                                //cmd.Parameters.Add(new SqlParameter("@images", slike));
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }
                            else
                            {

                                byte[] slike = null;
                                FileStream Stream = new FileStream(lokacijaslike, FileMode.Open, FileAccess.Read);
                                BinaryReader brs = new BinaryReader(Stream);
                                slike = brs.ReadBytes((int)Stream.Length);


                                cmd = new SqlCommand("INSERT INTO Predmet (Ime,Oblika,Kolicina,Višina,Širina,Dolžina,Slika) VALUES ('" + ime + "','" + obl + "','" + kol + "','" + vis + "','" + sir + "','" + dol + "',@images)", con);

                                MessageBox.Show("dodali ste nov predmet " + ime);
                                cmd.Parameters.Add(new SqlParameter("@images", slike));
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }
                        }
                        else { MessageBox.Show("Prosim vnesite številke, kjer je to smiselno (količina, višina, dolžina, širina)."); }

                        fillDataGridPredmeti();

                        artikelListCombo.Items.Clear();
                        fillArtikelCombobox();
                    }
                }
                   
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dodajsliko_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void artikelListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ime = artikelListCombo.Text;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + ime + "'", con);

            SqlDataReader reader;
            try
            {
                reader = pr2.ExecuteReader();

                while (reader.Read())
                {
                    int kolicina = reader.GetInt32(0);
                    dovoljenaKolicinaLabel.Text = "Na voljo je: " + kolicina.ToString() + " artiklov " + ime + ".";
                }
            }
            catch (Exception ea)
            {

            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            String imeArtikla = artikelListCombo.Text;
            int kolicinaArtikla;
            bool isNumeric = int.TryParse(artikelKolicinaText.Text, out kolicinaArtikla);

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + imeArtikla + "'", con);
            Int32 kolicinaArtiklaNaZalogi = (Int32)pr2.ExecuteScalar();

            if (isNumeric == false)
            {
                notIntegerWarning.Text = "Prosim vnesite številko z znaki 0-9";
            }
            else if (kolicinaArtikla > kolicinaArtiklaNaZalogi)
            {
                notIntegerWarning.Text = "Prosim vnesite količino, ki je manjša ali enaka zalogi";
            }
            else if (artikliNarocilaList.Contains(imeArtikla))
            {
                notIntegerWarning.Text = "Ta predmet ste že vnesli.";
            }
            else
            {
                artikliNarocilaList.Add(imeArtikla);
                kolicnaArtikliNarocilaList.Add(kolicinaArtikla);
                notIntegerWarning.Text = "Dodan artikel: " + imeArtikla + ". Kolicina: " + kolicinaArtikla;
            }

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            if (imeNarocilaText.Text.Count() > 0 && narocnikText.Text.Count() > 0)
            {


                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand vsaNarocila = new SqlCommand("SELECT imeNarocila FROM Narocilo", con);

                SqlDataReader reader;
                List<String> imenaNarocil = new List<String>();
                try
                {
                    reader = vsaNarocila.ExecuteReader();

                    while (reader.Read())
                    {
                        String ime = reader.GetString(0);
                        imenaNarocil.Add(ime);
                    }
                    reader.Close();
                }
                catch (Exception ea)
                {

                }
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //DateTime date = dateTimePicker1.Text; ,rokDobave  "','" + dateTimePicker1.Text + 
                    String imeNarocila = imeNarocilaText.Text;
                    String imeNarocnika = narocnikText.Text;

                    if (imenaNarocil.Contains(imeNarocila))
                    {
                        MessageBox.Show("Naročilo s tem imenom že obstaja. Poimenujte drugače");
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Narocilo (imeNarocila, narocnik, status) VALUES ('" + imeNarocila + "','" + imeNarocnika + "','0')", con);

                        MessageBox.Show("Dodali ste novo naročilo " + imeNarocila);
                        cmd.ExecuteNonQuery();

                        fillDataGridNarocila();

                        SqlCommand idNarocila = new SqlCommand("SELECT stevilkaNarocila FROM Narocilo WHERE imeNarocila ='" + imeNarocila + "'", con);

                        Int32 idNarocilaForeign = (Int32)idNarocila.ExecuteScalar();

                        Int32 kolicinaPredmet;

                        for (int i = 0; i < artikliNarocilaList.Count; i++)
                        {
                            kolicinaPredmet = 0;
                            SqlCommand kolicina = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime= '" + artikliNarocilaList.ElementAt(i) + "'", con);
                            kolicinaPredmet = (Int32)kolicina.ExecuteScalar();
                            kolicinaPredmet = kolicinaPredmet - kolicnaArtikliNarocilaList.ElementAt(i);

                            cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + kolicinaPredmet + "' WHERE Ime= '" + artikliNarocilaList.ElementAt(i) + "'", con);
                            cmd.ExecuteNonQuery();

                            insertArtikle = new SqlCommand("INSERT INTO predmetVNarocilu (imePredmeta, kolicina, idNarocilaForeign) VALUES ('" + artikliNarocilaList.ElementAt(i) +
                                "','" + kolicnaArtikliNarocilaList.ElementAt(i) + "','" + idNarocilaForeign + "')", con);
                            insertArtikle.ExecuteNonQuery();
                        }

                        artikliNarocilaList.Clear();
                        kolicnaArtikliNarocilaList.Clear();

                        fillDataGridPredmeti();

                        con.Close();
                    }

                }

            }
            else
            {
                warningEmptyNarocilo.Text = "Prosim izpolnite vsa polja ustrezno. Datum mm/dd/yyyy";
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void datagridnarocila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listView1.Items.Clear();
            int rowNumber = e.RowIndex;
            DataGridViewRow row = datagridnarocila.Rows[rowNumber];
            int stevilkaNarocila = Convert.ToInt32(row.Cells[0].Value.ToString());

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand dobiNarocilo = new SqlCommand("SELECT * FROM Narocilo WHERE stevilkaNarocila = '" + stevilkaNarocila + "'", con);

                SqlCommand dobiArtikleNarocila = new SqlCommand("SELECT * FROM PredmetVNarocilu WHERE idNarocilaForeign = '" + stevilkaNarocila + "'", con);

                SqlDataReader reader;
                listView1.View = View.Details;
                try
                {
                    reader = dobiNarocilo.ExecuteReader();

                    while (reader.Read())
                    {
                        String imeNarocila = reader.GetString(1);
                        String narocnik = reader.GetString(2);
                        //DateTime date = reader.GetDateTime(3);
                    }
                    reader.Close();
                }
                catch (Exception er)
                {

                }

                String[] arr = new string[3];
                try
                {
                    reader = dobiArtikleNarocila.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        String imeArtikla = reader.GetString(1);
                        int kolicina = reader.GetInt32(2);
                        arr[0] = id.ToString();
                        arr[1] = imeArtikla;
                        arr[2] = kolicina.ToString();
                        ListViewItem itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
                catch (Exception er)
                {

                }

            }
        }

        private void izbrisiArtikel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && listView1.SelectedItems.Count < 2)
            {
                int id = Convert.ToInt32(listView1.SelectedItems[0].Text);

                int steviloVrstice = listView1.SelectedItems[0].Index;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand dobiPredmetNarocila = new SqlCommand("SELECT imePredmeta FROM predmetVNarocilu WHERE idPredmetiNarocila = '" + id + "'", con);
                    String imePredmeta = (String)dobiPredmetNarocila.ExecuteScalar();

                    SqlCommand dobiKolicinoNarocila = new SqlCommand("SELECT kolicina FROM predmetVNarocilu WHERE idPredmetiNarocila = '" + id + "'", con);
                    Int32 kolicinaArtikla = (Int32)dobiKolicinoNarocila.ExecuteScalar();

                    SqlCommand dobiPredmet = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime = '" + imePredmeta + "'", con);
                    Int32 zalogaArtikla = (Int32)dobiPredmet.ExecuteScalar();

                    zalogaArtikla = zalogaArtikla + kolicinaArtikla;

                    cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + zalogaArtikla + "' WHERE Ime= '" + imePredmeta + "'", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM PredmetVNarocilu WHERE idPredmetiNarocila = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    listView1.Items[steviloVrstice].Remove();
                    MessageBox.Show("Izbrisali ste artikel iz narocila");
                }
            }
            
        }

        private void UrediArtikel_Click(object sender, EventArgs e)
        {
            String imeArtikla = comboBox1.Text;
            int kolicinaArtikla;
            bool isNumeric = int.TryParse(textBox1.Text, out kolicinaArtikla);

            int stevilkaNarocila;
            bool isNumeric2 = int.TryParse(SteviloNarocila.Text, out stevilkaNarocila);


            if (isNumeric2.Equals(true)) {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + imeArtikla + "'", con);
                Int32 kolicinaArtiklaNaZalogi = (Int32)pr2.ExecuteScalar();
                SqlCommand pr3 = new SqlCommand("SELECT * FROM [predmetVNarocilu]", con);

                SqlCommand dobiNarocilo = new SqlCommand("SELECT stevilkaNarocila FROM Narocilo WHERE stevilkaNarocila = '" + stevilkaNarocila + "'", con);

                var idNarocila = dobiNarocilo.ExecuteScalar();

                SqlDataReader reader;
                List<String> imena = new List<String>();
                try
                {
                    reader = pr3.ExecuteReader();

                    while (reader.Read())
                    {
                        String imePredmeta = reader.GetString(1);
                        imena.Add(imePredmeta);
                    }
                    reader.Close();
                }
                catch (Exception er)
                {

                }
                con.Close();

                if (isNumeric == false)
                {
                    label32.Text = "Prosim vnesite številko z znaki 0-9";
                }
                else if (kolicinaArtikla > kolicinaArtiklaNaZalogi)
                {
                    label32.Text = "Prosim vnesite količino, ki je manjša ali enaka zalogi";
                }
                else if (imena.Contains(imeArtikla))
                {
                    label32.Text = "Ta predmet ste že vnesli.";
                }
                else if (idNarocila == null)
                {
                    label32.Text = "Neveljavna številka naročila.";
                }

                else
                {
                    SqlConnection con1 = new SqlConnection(conString);
                    con1.Open();
                    int kolicinaPredmet;
                    if (con1.State == System.Data.ConnectionState.Open)
                    {
                        kolicinaPredmet = 0;
                        SqlCommand kolicina = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime= '" + imeArtikla + "'", con1);
                        kolicinaPredmet = (Int32)kolicina.ExecuteScalar();
                        kolicinaPredmet = kolicinaPredmet - kolicinaArtikla;

                        cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + kolicinaPredmet + "' WHERE Ime= '" + imeArtikla + "'", con1);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("INSERT INTO predmetVNarocilu (imePredmeta, kolicina, idNarocilaForeign) VALUES ('" + imeArtikla + "','" + kolicinaArtikla + "','" + stevilkaNarocila + "')", con1);

                        MessageBox.Show("Dodali ste nov predmet " + imeArtikla);
                        cmd.ExecuteNonQuery();

                        SqlCommand getId = new SqlCommand("SELECT idPredmetiNarocila FROM predmetVNarocilu WHERE idNarocilaForeign = '" + stevilkaNarocila + "'", con);
                        Int32 id = (Int32)getId.ExecuteScalar();

                        String[] arr = new string[3];

                        arr[0] = id.ToString();
                        arr[1] = imeArtikla;
                        arr[2] = kolicinaArtikla.ToString();

                        ListViewItem itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                        con1.Close();
                    }
                }
            }
                
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String ime = comboBox1.Text;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + ime + "'", con);

            SqlDataReader reader;
            try
            {
                reader = pr2.ExecuteReader();

                while (reader.Read())
                {
                    int kolicina = reader.GetInt32(0);
                    label30.Text = "Na voljo je: " + kolicina.ToString() + " artiklov " + ime + ".";
                }
            }
            catch (Exception ea)
            {

            }
        }

        private void button2_Click_4(object sender, EventArgs e)
        {
            int stevilkaNarocila;
            bool isNumeric2 = int.TryParse(textBox2.Text, out stevilkaNarocila);

            if (isNumeric2.Equals(true))
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand dobiNarocilo = new SqlCommand("SELECT stevilkaNarocila FROM Narocilo WHERE stevilkaNarocila = '" + stevilkaNarocila + "'", con);

                    var idNarocila = dobiNarocilo.ExecuteScalar();

                    if (idNarocila == null)
                    {
                        MessageBox.Show("Narocilo z številko " + stevilkaNarocila + " ne obstaja.");
                    }
                    else
                    {

                        if (con.State == System.Data.ConnectionState.Open)
                        {


                            SqlCommand dobiPredmeteNarocila = new SqlCommand("SELECT * FROM predmetVNarocilu WHERE idNarocilaForeign = '" + stevilkaNarocila + "'", con);

                            SqlDataReader reader;
                            List<String> seznamPredmetov = new List<String>();
                            List<int> seznamKolicin = new List<int>();
                            try
                            {
                                reader = dobiPredmeteNarocila.ExecuteReader();

                                while (reader.Read())
                                {
                                    String ime = reader.GetString(1);
                                    int kolicina = reader.GetInt32(2);
                                    seznamPredmetov.Add(ime);
                                    seznamKolicin.Add(kolicina);
                                }
                                reader.Close();
                            }
                            catch (Exception ea)
                            {

                            }

                            for (int i = 0; i < seznamPredmetov.Count(); i++)
                            {
                                SqlCommand dobiPredmet22 = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime = '" + seznamPredmetov.ElementAt(i) + "'", con);
                                Int32 kolicinaArtiklaNaZalogi22 = (Int32)dobiPredmet22.ExecuteScalar();

                                kolicinaArtiklaNaZalogi22 = kolicinaArtiklaNaZalogi22 + seznamKolicin.ElementAt(i);

                                cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + kolicinaArtiklaNaZalogi22 + "' WHERE Ime= '" + seznamPredmetov.ElementAt(i) + "'", con);
                                cmd.ExecuteNonQuery();
                            }


                            cmd = new SqlCommand("DELETE FROM PredmetVNarocilu WHERE idNarocilaForeign = '" + stevilkaNarocila + "'", con);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("DELETE FROM Narocilo WHERE stevilkaNarocila = '" + stevilkaNarocila + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Izbrisali naročilo z številko: " + stevilkaNarocila);

                            fillDataGridNarocila();
                            listView1.Items.Clear();
                        }
                    }

                }
            }
            else { MessageBox.Show("Prosim vnesite s številko."); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ime = comboBox2.Text;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + ime + "'", con);

            SqlDataReader reader;
            try
            {
                reader = pr2.ExecuteReader();

                while (reader.Read())
                {
                    int kolicina = reader.GetInt32(0);
                    label39.Text = "Zaloga artikla " + ime + " je " + kolicina + ".";
                }
            }
            catch (Exception ea)
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String imeArtikla = comboBox2.Text;
            int kolicinaArtikla;
            bool isNumeric = int.TryParse(textBox3.Text, out kolicinaArtikla);

            if (isNumeric == false)
            {
                label40.Text = "Prosim vnesite številko z znaki 0-9";
            }
            else if (artikliDobavaList.Contains(imeArtikla))
            {
                label40.Text = "Ta predmet ste že vnesli.";
            }
            else
            {
                artikliDobavaList.Add(imeArtikla);
                kolicnaArtikliDobavaList.Add(kolicinaArtikla);
                label40.Text = "Dodan artikel: " + imeArtikla + ". Kolicina: " + kolicinaArtikla;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (imeDobaveText.Text.Count() > 0 && dobaviteljText.Text.Count() > 0)
            {


                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //DateTime date = dateTimePicker2.Value.Date;  , datumDostave  "','" + date + 
                    String imeDobave = imeDobaveText.Text;
                    String imeDobavitelj = dobaviteljText.Text;

                    SqlCommand vseDobave = new SqlCommand("SELECT imeDobave FROM Dobava", con);

                    SqlDataReader reader;
                    List<String> imenaDobav = new List<String>();
                    try
                    {
                        reader = vseDobave.ExecuteReader();

                        while (reader.Read())
                        {
                            String ime = reader.GetString(0);
                            imenaDobav.Add(ime);
                        }
                        reader.Close();
                    }
                    catch (Exception ea)
                    {

                    }

                    if (imenaDobav.Contains(imeDobave))
                    {
                        MessageBox.Show("Dobava s tem imenom že obstaja. Poimenujte drugače");
                    }

                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Dobava (imeDobave, dobavitelj, status) VALUES ('" + imeDobave + "','" + imeDobavitelj + "','0')", con);

                        MessageBox.Show("Dodali ste novo dobavo " + imeDobave);
                        cmd.ExecuteNonQuery();

                        fillDataGridDobave();

                        SqlCommand idDobave = new SqlCommand("SELECT stevilkaDobave FROM Dobava WHERE imeDobave ='" + imeDobave + "'", con);

                        Int32 idDobaveForeign = (Int32)idDobave.ExecuteScalar();

                        Int32 kolicinaPredmet;

                        for (int i = 0; i < artikliDobavaList.Count; i++)
                        {
                            kolicinaPredmet = 0;
                            SqlCommand kolicina = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime= '" + artikliDobavaList.ElementAt(i) + "'", con);
                            kolicinaPredmet = (Int32)kolicina.ExecuteScalar();
                            kolicinaPredmet = kolicinaPredmet + kolicnaArtikliDobavaList.ElementAt(i);

                            cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + kolicinaPredmet + "' WHERE Ime= '" + artikliDobavaList.ElementAt(i) + "'", con);
                            cmd.ExecuteNonQuery();

                            insertArtikle = new SqlCommand("INSERT INTO predmetVDobavi (imePredmeta, kolicina, idDobaveForeign) VALUES ('" + artikliDobavaList.ElementAt(i) +
                                "','" + kolicnaArtikliDobavaList.ElementAt(i) + "','" + idDobaveForeign + "')", con);
                            insertArtikle.ExecuteNonQuery();
                        }

                        artikliDobavaList.Clear();
                        kolicnaArtikliDobavaList.Clear();

                        fillDataGridPredmeti();

                        con.Close();
                    }

                }

            }
            else
            {
                label41.Text = "Prosim izpolnite vsa polja ustrezno. Datum mm/dd/yyyy";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listView2.Items.Clear();
            int rowNumber = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowNumber];
            int stevilkaDobave = Convert.ToInt32(row.Cells[0].Value.ToString());

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand dobiDobavo = new SqlCommand("SELECT * FROM Dobava WHERE stevilkaDobave = '" + stevilkaDobave + "'", con);

                SqlCommand dobiArtikleDobave = new SqlCommand("SELECT * FROM PredmetVDobavi WHERE idDobaveForeign = '" + stevilkaDobave + "'", con);

                SqlDataReader reader;
                listView2.View = View.Details;
                try
                {
                    reader = dobiDobavo.ExecuteReader();

                    while (reader.Read())
                    {
                        String imeDobave = reader.GetString(1);
                        String dobavitelj = reader.GetString(2);
                        //DateTime date = reader.GetDateTime(3);
                    }
                    reader.Close();
                }
                catch (Exception er)
                {

                }

                String[] arr = new string[3];
                try
                {
                    reader = dobiArtikleDobave.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        String imeArtikla = reader.GetString(1);
                        int kolicina = reader.GetInt32(2);
                        arr[0] = id.ToString();
                        arr[1] = imeArtikla;
                        arr[2] = kolicina.ToString();
                        ListViewItem itm = new ListViewItem(arr);
                        listView2.Items.Add(itm);
                    }
                }
                catch (Exception er)
                {

                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0 && listView2.SelectedItems.Count < 2)
            {
                int id = Convert.ToInt32(listView2.SelectedItems[0].Text);

                int steviloVrstice = listView2.SelectedItems[0].Index;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {

                    SqlCommand dobiPredmetDobave = new SqlCommand("SELECT imePredmeta FROM predmetVDobavi WHERE idPredmetDobave = '" + id + "'", con);
                    String imePredmeta = (String)dobiPredmetDobave.ExecuteScalar();

                    SqlCommand dobiKolicinoDobave = new SqlCommand("SELECT kolicina FROM predmetVDobavi WHERE idPredmetDobave = '" + id + "'", con);
                    Int32 kolicinaArtikla = (Int32)dobiKolicinoDobave.ExecuteScalar();

                    SqlCommand dobiPredmet = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime = '" + imePredmeta + "'", con);
                    Int32 zalogaArtikla = (Int32)dobiPredmet.ExecuteScalar();

                    zalogaArtikla = zalogaArtikla - kolicinaArtikla;

                    cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + zalogaArtikla + "' WHERE Ime= '" + imePredmeta + "'", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("DELETE FROM PredmetVDobavi WHERE idPredmetDobave = '" + id + "'", con);
                    cmd.ExecuteNonQuery();
                    listView2.Items[steviloVrstice].Remove();
                    MessageBox.Show("Izbrisali ste predmet iz dobave");
                }
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ime = comboBox3.Text;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + ime + "'", con);

            SqlDataReader reader;
            try
            {
                reader = pr2.ExecuteReader();

                while (reader.Read())
                {
                    int kolicina = reader.GetInt32(0);
                    label47.Text = "Zaloga artikla " + ime + " je " + kolicina.ToString() + ".";
                }
            }
            catch (Exception ea)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String imeArtikla = comboBox3.Text;
            int kolicinaArtikla;
            bool isNumeric = int.TryParse(textBox4.Text, out kolicinaArtikla);
            int stevilkaDobave;
            bool isNumeric2 = int.TryParse(textBox5.Text, out stevilkaDobave);

            if (isNumeric2.Equals(true)) {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand pr2 = new SqlCommand("SELECT Kolicina FROM [Predmet] WHERE Ime = '" + imeArtikla + "'", con);
                Int32 kolicinaArtiklaNaZalogi = (Int32)pr2.ExecuteScalar();
                SqlCommand pr3 = new SqlCommand("SELECT * FROM [predmetVDobavi]", con);
                SqlCommand dobiDobavo = new SqlCommand("SELECT stevilkaDobave FROM Dobava WHERE stevilkaDobave = '" + stevilkaDobave + "'", con);

                var idNarocila = dobiDobavo.ExecuteScalar();

                SqlDataReader reader;
                List<String> imena = new List<String>();
                try
                {
                    reader = pr3.ExecuteReader();

                    while (reader.Read())
                    {
                        String imePredmeta = reader.GetString(1);
                        imena.Add(imePredmeta);
                    }
                    reader.Close();
                }
                catch (Exception er)
                {

                }
                con.Close();

                if (isNumeric.Equals(false))
                {
                    label48.Text = "Prosim vnesite številko z znaki 0-9";
                }
                else if (imena.Contains(imeArtikla))
                {
                    label48.Text = "Ta predmet ste že vnesli.";
                }
                else if (idNarocila == null)
                {
                    label48.Text = "Dobava s tem številom ne obstaja";
                }
                else {
                    SqlConnection con1 = new SqlConnection(conString);
                    con1.Open();
                    int kolicinaPredmet;
                    if (con1.State == System.Data.ConnectionState.Open)
                    {
                        kolicinaPredmet = 0;
                        SqlCommand kolicina = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime= '" + imeArtikla + "'", con1);
                        kolicinaPredmet = (Int32)kolicina.ExecuteScalar();
                        kolicinaPredmet = kolicinaPredmet + kolicinaArtikla;

                        cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + kolicinaPredmet + "' WHERE Ime= '" + imeArtikla + "'", con1);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("INSERT INTO predmetVDobavi (imePredmeta, kolicina, idDobaveForeign) VALUES ('" + imeArtikla + "','" + kolicinaArtikla + "','" + stevilkaDobave + "')", con1);

                        MessageBox.Show("Dodali ste nov predmet " + imeArtikla);
                        cmd.ExecuteNonQuery();

                        SqlCommand dobiId = new SqlCommand("SELECT idPredmetDobave FROM predmetVDobavi WHERE idDobaveForeign = '" + stevilkaDobave + "'", con);
                        Int32 id = (Int32)dobiId.ExecuteScalar();

                        String[] arr = new string[3];

                        arr[0] = id.ToString();
                        arr[1] = imeArtikla;
                        arr[2] = kolicinaArtikla.ToString();

                        ListViewItem itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                        con1.Close();
                    }
                }
            }
            else { label48.Text = "Prosim vnesite številko dobave z znaki 0-9"; }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int stevilkaDobave;
            bool isNumeric2 = int.TryParse(stevilkaDobaveIzbris.Text, out stevilkaDobave);

            if (isNumeric2.Equals(true))
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand dobiDobavo = new SqlCommand("SELECT stevilkaDobave FROM Dobava WHERE stevilkaDobave = '" + stevilkaDobave + "'", con);

                    var idDobave = dobiDobavo.ExecuteScalar();

                    if (idDobave == null)
                    {
                        MessageBox.Show("Narocilo z številko " + stevilkaDobave + " ne obstaja.");
                    }
                    else
                    {

                        if (con.State == System.Data.ConnectionState.Open)
                        {


                            SqlCommand dobiPredmeteDobave = new SqlCommand("SELECT * FROM predmetVDobavi WHERE idDobaveForeign = '" + stevilkaDobave + "'", con);

                            SqlDataReader reader;
                            List<String> seznamPredmetov = new List<String>();
                            List<int> seznamKolicin = new List<int>();
                            try
                            {
                                reader = dobiPredmeteDobave.ExecuteReader();

                                while (reader.Read())
                                {
                                    String ime = reader.GetString(1);
                                    int kolicina = reader.GetInt32(2);
                                    seznamPredmetov.Add(ime);
                                    seznamKolicin.Add(kolicina);
                                }
                                reader.Close();
                            }
                            catch (Exception ea)
                            {

                            }

                            for (int i = 0; i < seznamPredmetov.Count(); i++)
                            {
                                SqlCommand dobiPredmet22 = new SqlCommand("SELECT Kolicina FROM Predmet WHERE Ime = '" + seznamPredmetov.ElementAt(i) + "'", con);
                                Int32 kolicinaArtiklaNaZalogi22 = (Int32)dobiPredmet22.ExecuteScalar();

                                kolicinaArtiklaNaZalogi22 = kolicinaArtiklaNaZalogi22 + seznamKolicin.ElementAt(i);

                                cmd = new SqlCommand("UPDATE Predmet SET Kolicina ='" + kolicinaArtiklaNaZalogi22 + "' WHERE Ime= '" + seznamPredmetov.ElementAt(i) + "'", con);
                                cmd.ExecuteNonQuery();
                            }


                            cmd = new SqlCommand("DELETE FROM PredmetVDobavi WHERE idDobaveForeign = '" + stevilkaDobave + "'", con);
                            cmd.ExecuteNonQuery();

                            cmd = new SqlCommand("DELETE FROM Dobava WHERE stevilkaDobave = '" + stevilkaDobave + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Izbrisali dobavo z številko: " + stevilkaDobave);

                            fillDataGridDobave();
                            listView2.Items.Clear();
                        }
                    }

                }
            }
            else { MessageBox.Show("Prosim vnesite s številko."); }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String msg1 = "", msg2 = "";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (!string.IsNullOrEmpty(comboBox4.Text))
                {
                    String imeDobave = comboBox4.Text;
                    imenaDobavPrevoz.Add(imeDobave);
                    cmd = new SqlCommand("UPDATE Dobava SET status = '1' WHERE imeDobave = '" + imeDobave + "'", con);
                    cmd.ExecuteNonQuery();
                    msg1 = "Dodali ste dobavo " + imeDobave;
                }

                if (!string.IsNullOrEmpty(comboBox5.Text))
                {
                    String imeNarocila = comboBox5.Text;
                    imenaNarocilPrevoz.Add(imeNarocila);
                    cmd = new SqlCommand("UPDATE Narocilo SET status = '1' WHERE imeNarocila = '" + imeNarocila + "'", con);
                    cmd.ExecuteNonQuery();
                    msg2 = "Dodali ste naročilo " + imeNarocila;
                }
                label55.Text = msg1;
                label56.Text = msg2;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text) || !string.IsNullOrEmpty(textBox7.Text) )
            {
                String imePrevoza = textBox6.Text;
                String imePrevoznika = textBox7.Text;
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    cmd = new SqlCommand("INSERT INTO Prevoz (imePrevoza, imePrevoznika) VALUES ('" + imePrevoza + "','" + imePrevoznika + "')", con);
                    cmd.ExecuteNonQuery();

                    SqlCommand prevoz = new SqlCommand("SELECT idPrevoza FROM Prevoz WHERE imePrevoza = '" + imePrevoza + "'", con);
                    Int32 id = (Int32)prevoz.ExecuteScalar();

                    for (int i = 0 ; i < imenaDobavPrevoz.Count() ; i++)
                    {
                        cmd = new SqlCommand("UPDATE Dobava SET idPrevoz = '" + id + "' WHERE imeDobave = '" + imenaDobavPrevoz.ElementAt(i) + "'", con);
                        cmd.ExecuteNonQuery();
                    }

                    for (int i = 0; i < imenaNarocilPrevoz.Count(); i++)
                    {
                        cmd = new SqlCommand("UPDATE Narocilo SET idPrevoz = '" + id + "' WHERE imeNarocila = '" + imenaNarocilPrevoz.ElementAt(i) + "'", con);
                        cmd.ExecuteNonQuery();
                    }

                    imenaDobavPrevoz.Clear();
                    imenaNarocilPrevoz.Clear();
                    MessageBox.Show("Uspešno dodan prevoz " + imePrevoza);
                    fillDataGridPrevozi();
                }
            }
            else
            {
                MessageBox.Show("Prosimo izpolnite polji Ime prevoza in Ime prevoznika.");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listView3.Items.Clear();
            int rowNumber = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowNumber];
            int stevilkaPrevoza = Convert.ToInt32(row.Cells[0].Value.ToString());

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand dobiPrevoz = new SqlCommand("SELECT * FROM Prevoz WHERE idPrevoza = '" + stevilkaPrevoza + "'", con);

                SqlCommand dobiNaloge1 = new SqlCommand("SELECT * FROM Dobava WHERE idPrevoz = '" + stevilkaPrevoza + "'", con);

                SqlCommand dobiNaloge2 = new SqlCommand("SELECT * FROM Narocilo WHERE idPrevoz = '" + stevilkaPrevoza + "'", con);

                SqlDataReader reader;
                listView3.View = View.Details;
                String[] arr = new string[5];
                try
                {
                    reader = dobiNaloge1.ExecuteReader();

                    while (reader.Read())
                    {
                        int idDobave = reader.GetInt32(0);
                        String imeDobave = reader.GetString(1);
                        String dobavitelj = reader.GetString(2);
                        //DateTime date = reader.GetDateTime(3);
                        int status = reader.GetInt32(4);

                        arr[0] = idDobave.ToString();
                        arr[1] = imeDobave;
                        arr[2] = dobavitelj;
                        //arr[3] = date.ToString();
                        arr[4] = status.ToString();
                        ListViewItem itm = new ListViewItem(arr);
                        listView3.Items.Add(itm);

                    }
                    reader.Close();
                }
                catch (Exception er)
                {

                }

                try
                {
                    reader = dobiNaloge2.ExecuteReader();

                    while (reader.Read())
                    {
                        int idNarocila = reader.GetInt32(0);
                        String imeNarocila = reader.GetString(1);
                        String narocnik = reader.GetString(2);
                        //DateTime date = reader.GetDateTime(3);
                        int status = reader.GetInt32(4);

                        arr[0] = idNarocila.ToString();
                        arr[1] = imeNarocila;
                        arr[2] = narocnik;
                        //arr[3] = date.ToString();
                        arr[4] = status.ToString();
                        ListViewItem itm = new ListViewItem(arr);
                        listView3.Items.Add(itm);
                    }
                }
                catch (Exception er)
                {

                }
            }
        }
    }
}
    

