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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.zaloga = new System.Windows.Forms.Button();
            this.prihodi = new System.Windows.Forms.Button();
            this.dobavnice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.narocila = new System.Windows.Forms.Button();
            this.panelanav = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelazaloga = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelaprihodi = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelaodhodi = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelazaloga.SuspendLayout();
            this.panelaprihodi.SuspendLayout();
            this.panelaodhodi.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button3.Image = global::Skladiščnik.Properties.Resources.icons8_minimize_window_32;
            this.button3.Location = new System.Drawing.Point(1055, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Skladiščnik.Properties.Resources.icons8_delete_50;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button2.Image = global::Skladiščnik.Properties.Resources.icons8_delete_50;
            this.button2.Location = new System.Drawing.Point(1084, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.narocila);
            this.panel1.Controls.Add(this.dobavnice);
            this.panel1.Controls.Add(this.prihodi);
            this.panel1.Controls.Add(this.zaloga);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 714);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(196, 497);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 214);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel3.Location = new System.Drawing.Point(190, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 119);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panelazaloga);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 88);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 100);
            this.panel5.TabIndex = 18;
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
            // prihodi
            // 
            this.prihodi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prihodi.BackgroundImage")));
            this.prihodi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prihodi.FlatAppearance.BorderSize = 0;
            this.prihodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prihodi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prihodi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.prihodi.Location = new System.Drawing.Point(-9, 186);
            this.prihodi.Name = "prihodi";
            this.prihodi.Size = new System.Drawing.Size(190, 97);
            this.prihodi.TabIndex = 20;
            this.prihodi.Text = "prihodi in odhodi";
            this.prihodi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.prihodi.UseVisualStyleBackColor = true;
            this.prihodi.Click += new System.EventHandler(this.button5_Click);
            // 
            // dobavnice
            // 
            this.dobavnice.FlatAppearance.BorderSize = 0;
            this.dobavnice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dobavnice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dobavnice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dobavnice.Image = ((System.Drawing.Image)(resources.GetObject("dobavnice.Image")));
            this.dobavnice.Location = new System.Drawing.Point(0, 392);
            this.dobavnice.Name = "dobavnice";
            this.dobavnice.Size = new System.Drawing.Size(190, 97);
            this.dobavnice.TabIndex = 21;
            this.dobavnice.Text = "dobavnice";
            this.dobavnice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dobavnice.UseVisualStyleBackColor = true;
            this.dobavnice.Click += new System.EventHandler(this.dobavnice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "skladiscnik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // narocila
            // 
            this.narocila.FlatAppearance.BorderSize = 0;
            this.narocila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.narocila.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.narocila.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.narocila.Location = new System.Drawing.Point(0, 289);
            this.narocila.Name = "narocila";
            this.narocila.Size = new System.Drawing.Size(190, 97);
            this.narocila.TabIndex = 22;
            this.narocila.Text = "naročila";
            this.narocila.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.narocila.UseVisualStyleBackColor = true;
            this.narocila.Click += new System.EventHandler(this.narocila_Click);
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
            this.panel6.Controls.Add(this.panelaprihodi);
            this.panel6.Location = new System.Drawing.Point(188, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(926, 4);
            this.panel6.TabIndex = 23;
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
            // panelazaloga
            // 
            this.panelazaloga.Controls.Add(this.label2);
            this.panelazaloga.Location = new System.Drawing.Point(189, 48);
            this.panelazaloga.Name = "panelazaloga";
            this.panelazaloga.Size = new System.Drawing.Size(907, 544);
            this.panelazaloga.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(328, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "panela2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelaprihodi
            // 
            this.panelaprihodi.Controls.Add(this.label3);
            this.panelaprihodi.Location = new System.Drawing.Point(20, 3);
            this.panelaprihodi.Name = "panelaprihodi";
            this.panelaprihodi.Size = new System.Drawing.Size(907, 544);
            this.panelaprihodi.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(328, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "panela1";
            // 
            // panelaodhodi
            // 
            this.panelaodhodi.Controls.Add(this.label4);
            this.panelaodhodi.Location = new System.Drawing.Point(193, 50);
            this.panelaodhodi.Name = "panelaodhodi";
            this.panelaodhodi.Size = new System.Drawing.Size(907, 544);
            this.panelaodhodi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label4.Location = new System.Drawing.Point(328, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "panela1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1115, 712);
            this.Controls.Add(this.panelaodhodi);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelanav);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelazaloga.ResumeLayout(false);
            this.panelazaloga.PerformLayout();
            this.panelaprihodi.ResumeLayout(false);
            this.panelaprihodi.PerformLayout();
            this.panelaodhodi.ResumeLayout(false);
            this.panelaodhodi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dobavnice;
        private System.Windows.Forms.Button prihodi;
        private System.Windows.Forms.Button zaloga;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button narocila;
        private System.Windows.Forms.FlowLayoutPanel panelanav;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelazaloga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelaprihodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelaodhodi;
        private System.Windows.Forms.Label label4;
    }
}