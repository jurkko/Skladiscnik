namespace Skladiščnik
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dobavitelji = new System.Windows.Forms.Button();
            this.Narocila = new System.Windows.Forms.Button();
            this.prihodi = new System.Windows.Forms.Button();
            this.zaloga = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelanav = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dolzina = new System.Windows.Forms.TextBox();
            this.sirina = new System.Windows.Forms.TextBox();
            this.visina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imepredmeta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oblika = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.izhod2 = new Skladiščnik.CircleButton();
            this.mini2 = new Skladiščnik.CircleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dodajsliko = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dobavitelji);
            this.panel1.Controls.Add(this.Narocila);
            this.panel1.Controls.Add(this.prihodi);
            this.panel1.Controls.Add(this.zaloga);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 714);
            this.panel1.TabIndex = 15;
            // 
            // Dobavitelji
            // 
            this.Dobavitelji.FlatAppearance.BorderSize = 0;
            this.Dobavitelji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dobavitelji.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dobavitelji.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dobavitelji.Image = ((System.Drawing.Image)(resources.GetObject("Dobavitelji.Image")));
            this.Dobavitelji.Location = new System.Drawing.Point(0, 392);
            this.Dobavitelji.Name = "Dobavitelji";
            this.Dobavitelji.Size = new System.Drawing.Size(190, 97);
            this.Dobavitelji.TabIndex = 22;
            this.Dobavitelji.Text = "Dobavitelji";
            this.Dobavitelji.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dobavitelji.UseVisualStyleBackColor = true;
            this.Dobavitelji.Click += new System.EventHandler(this.narocila_Click);
            // 
            // Narocila
            // 
            this.Narocila.FlatAppearance.BorderSize = 0;
            this.Narocila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Narocila.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Narocila.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Narocila.Image = ((System.Drawing.Image)(resources.GetObject("Narocila.Image")));
            this.Narocila.Location = new System.Drawing.Point(0, 289);
            this.Narocila.Name = "Narocila";
            this.Narocila.Size = new System.Drawing.Size(190, 97);
            this.Narocila.TabIndex = 21;
            this.Narocila.Text = "Naročila";
            this.Narocila.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Narocila.UseVisualStyleBackColor = true;
            this.Narocila.Click += new System.EventHandler(this.dobavnice_Click);
            // 
            // prihodi
            // 
            this.prihodi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prihodi.BackgroundImage")));
            this.prihodi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prihodi.FlatAppearance.BorderSize = 0;
            this.prihodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prihodi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prihodi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.prihodi.Location = new System.Drawing.Point(0, 186);
            this.prihodi.Name = "prihodi";
            this.prihodi.Size = new System.Drawing.Size(190, 97);
            this.prihodi.TabIndex = 20;
            this.prihodi.Text = "prihodi in odhodi";
            this.prihodi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prihodi.UseVisualStyleBackColor = true;
            this.prihodi.Click += new System.EventHandler(this.button5_Click);
            // 
            // zaloga
            // 
            this.zaloga.FlatAppearance.BorderSize = 0;
            this.zaloga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zaloga.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.zaloga.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.zaloga.Image = ((System.Drawing.Image)(resources.GetObject("zaloga.Image")));
            this.zaloga.Location = new System.Drawing.Point(0, 83);
            this.zaloga.Name = "zaloga";
            this.zaloga.Size = new System.Drawing.Size(190, 97);
            this.zaloga.TabIndex = 18;
            this.zaloga.Text = "zaloga";
            this.zaloga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.zaloga.UseVisualStyleBackColor = true;
            this.zaloga.Click += new System.EventHandler(this.zaloga_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 88);
            this.panel4.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(2, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(189, 4);
            this.panel7.TabIndex = 24;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel8.Location = new System.Drawing.Point(187, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(925, 10);
            this.panel8.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "skladiscnik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 100);
            this.panel5.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(196, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 214);
            this.panel2.TabIndex = 16;
            // 
            // panelanav
            // 
            this.panelanav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelanav.Location = new System.Drawing.Point(197, 85);
            this.panelanav.Name = "panelanav";
            this.panelanav.Size = new System.Drawing.Size(6, 100);
            this.panelanav.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel6.Location = new System.Drawing.Point(188, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(926, 4);
            this.panel6.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(209, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(887, 540);
            this.panel9.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dodajsliko);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dolzina);
            this.panel3.Controls.Add(this.sirina);
            this.panel3.Controls.Add(this.visina);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.imepredmeta);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.oblika);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(18, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 465);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label9.Location = new System.Drawing.Point(64, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dolžina:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label8.Location = new System.Drawing.Point(76, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Širina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label7.Location = new System.Drawing.Point(74, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Višina:";
            // 
            // dolzina
            // 
            this.dolzina.Location = new System.Drawing.Point(135, 181);
            this.dolzina.Name = "dolzina";
            this.dolzina.Size = new System.Drawing.Size(56, 20);
            this.dolzina.TabIndex = 12;
            // 
            // sirina
            // 
            this.sirina.Location = new System.Drawing.Point(135, 154);
            this.sirina.Name = "sirina";
            this.sirina.Size = new System.Drawing.Size(56, 20);
            this.sirina.TabIndex = 11;
            // 
            // visina
            // 
            this.visina.Location = new System.Drawing.Point(136, 127);
            this.visina.Name = "visina";
            this.visina.Size = new System.Drawing.Size(56, 20);
            this.visina.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(13, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dimenzije";
            // 
            // imepredmeta
            // 
            this.imepredmeta.Location = new System.Drawing.Point(135, 51);
            this.imepredmeta.Name = "imepredmeta";
            this.imepredmeta.Size = new System.Drawing.Size(134, 20);
            this.imepredmeta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ime predmeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(74, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oblika";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // oblika
            // 
            this.oblika.FormattingEnabled = true;
            this.oblika.Items.AddRange(new object[] {
            "Brez pakiranja",
            "Lesena Skatla",
            "Karton",
            "Zascitna Folija"});
            this.oblika.Location = new System.Drawing.Point(135, 77);
            this.oblika.Name = "oblika";
            this.oblika.Size = new System.Drawing.Size(111, 21);
            this.oblika.TabIndex = 2;
            this.oblika.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodaj nov predmet v bazo podatkov";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zaloga";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Yellow;
            this.panel10.Location = new System.Drawing.Point(209, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(887, 540);
            this.panel10.TabIndex = 25;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // izhod2
            // 
            this.izhod2.BackColor = System.Drawing.Color.White;
            this.izhod2.FlatAppearance.BorderSize = 0;
            this.izhod2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izhod2.Location = new System.Drawing.Point(1086, 19);
            this.izhod2.Name = "izhod2";
            this.izhod2.Size = new System.Drawing.Size(19, 19);
            this.izhod2.TabIndex = 26;
            this.izhod2.UseVisualStyleBackColor = false;
            this.izhod2.Click += new System.EventHandler(this.izhod1_Click);
            // 
            // mini2
            // 
            this.mini2.BackColor = System.Drawing.Color.White;
            this.mini2.FlatAppearance.BorderSize = 0;
            this.mini2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini2.Location = new System.Drawing.Point(1061, 19);
            this.mini2.Name = "mini2";
            this.mini2.Size = new System.Drawing.Size(19, 19);
            this.mini2.TabIndex = 27;
            this.mini2.UseVisualStyleBackColor = false;
            this.mini2.Click += new System.EventHandler(this.circleButton1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.Location = new System.Drawing.Point(231, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label10.Location = new System.Drawing.Point(206, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "cm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label11.Location = new System.Drawing.Point(206, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "cm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label12.Location = new System.Drawing.Point(206, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "cm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label13.Location = new System.Drawing.Point(13, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "Slike";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(251)))));
            this.label14.Location = new System.Drawing.Point(39, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dodaj sliko:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dodajsliko
            // 
            this.dodajsliko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajsliko.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajsliko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.dodajsliko.Location = new System.Drawing.Point(171, 350);
            this.dodajsliko.Name = "dodajsliko";
            this.dodajsliko.Size = new System.Drawing.Size(112, 27);
            this.dodajsliko.TabIndex = 23;
            this.dodajsliko.Text = "Dodaj sliko";
            this.dodajsliko.UseVisualStyleBackColor = true;
            this.dodajsliko.Click += new System.EventHandler(this.dodajsliko_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1117, 712);
            this.Controls.Add(this.mini2);
            this.Controls.Add(this.izhod2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelanav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Skladiscnik";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.Move += new System.EventHandler(this.Form2_Move);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Narocila;
        private System.Windows.Forms.Button prihodi;
        private System.Windows.Forms.Button zaloga;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dobavitelji;
        private System.Windows.Forms.FlowLayoutPanel panelanav;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox oblika;
        private System.Windows.Forms.TextBox imepredmeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dolzina;
        private System.Windows.Forms.TextBox sirina;
        private System.Windows.Forms.TextBox visina;
        private System.Windows.Forms.Label label6;
        private CircleButton izhod2;
        private CircleButton mini2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button dodajsliko;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}