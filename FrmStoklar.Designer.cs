namespace Pansiyon_Kayit_Uygulamasi
{
    partial class FrmStoklar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chGidalar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chİcecekler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAtistirmaliklar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtİcecek = new System.Windows.Forms.TextBox();
            this.txtAtistirmalik = new System.Windows.Forms.TextBox();
            this.txtGida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtİnternet = new System.Windows.Forms.TextBox();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.chElektrik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chİnternet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGidalar,
            this.chİcecekler,
            this.chAtistirmaliklar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 267);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(470, 178);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chGidalar
            // 
            this.chGidalar.Text = "Gıdalar";
            this.chGidalar.Width = 148;
            // 
            // chİcecekler
            // 
            this.chİcecekler.Text = "İcecekler";
            this.chİcecekler.Width = 138;
            // 
            // chAtistirmaliklar
            // 
            this.chAtistirmaliklar.Text = "Atıştırmalıklar";
            this.chAtistirmaliklar.Width = 175;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtİcecek);
            this.groupBox1.Controls.Add(this.txtAtistirmalik);
            this.groupBox1.Controls.Add(this.txtGida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 248);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(89, 195);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(126, 36);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(267, 195);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 36);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // txtİcecek
            // 
            this.txtİcecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİcecek.Location = new System.Drawing.Point(219, 86);
            this.txtİcecek.Name = "txtİcecek";
            this.txtİcecek.Size = new System.Drawing.Size(214, 30);
            this.txtİcecek.TabIndex = 14;
            // 
            // txtAtistirmalik
            // 
            this.txtAtistirmalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtistirmalik.Location = new System.Drawing.Point(219, 135);
            this.txtAtistirmalik.Name = "txtAtistirmalik";
            this.txtAtistirmalik.Size = new System.Drawing.Size(214, 30);
            this.txtAtistirmalik.TabIndex = 13;
            // 
            // txtGida
            // 
            this.txtGida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGida.Location = new System.Drawing.Point(219, 31);
            this.txtGida.Name = "txtGida";
            this.txtGida.Size = new System.Drawing.Size(214, 30);
            this.txtGida.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Atıştırmalıklar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "İçecek Tutarı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gıda Tutarı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTemizle2);
            this.groupBox2.Controls.Add(this.btnKaydet2);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.txtİnternet);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(525, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 248);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle2.Location = new System.Drawing.Point(72, 191);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(126, 36);
            this.btnTemizle2.TabIndex = 24;
            this.btnTemizle2.Text = "Temizle";
            this.btnTemizle2.UseVisualStyleBackColor = true;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet2.Location = new System.Drawing.Point(250, 191);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(126, 36);
            this.btnKaydet2.TabIndex = 23;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // txtSu
            // 
            this.txtSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSu.Location = new System.Drawing.Point(202, 82);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(214, 30);
            this.txtSu.TabIndex = 22;
            // 
            // txtİnternet
            // 
            this.txtİnternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİnternet.Location = new System.Drawing.Point(202, 131);
            this.txtİnternet.Name = "txtİnternet";
            this.txtİnternet.Size = new System.Drawing.Size(214, 30);
            this.txtİnternet.TabIndex = 21;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElektrik.Location = new System.Drawing.Point(202, 25);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(214, 30);
            this.txtElektrik.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "İnternet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Su :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Elektrik :";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chElektrik,
            this.chSu,
            this.chİnternet});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(525, 267);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(482, 178);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // chElektrik
            // 
            this.chElektrik.Text = "Elektrik";
            this.chElektrik.Width = 148;
            // 
            // chSu
            // 
            this.chSu.Text = "Su";
            this.chSu.Width = 138;
            // 
            // chİnternet
            // 
            this.chİnternet.Text = "İnternet";
            this.chİnternet.Width = 175;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1057, 484);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chGidalar;
        private System.Windows.Forms.ColumnHeader chİcecekler;
        private System.Windows.Forms.ColumnHeader chAtistirmaliklar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtİcecek;
        private System.Windows.Forms.TextBox txtAtistirmalik;
        private System.Windows.Forms.TextBox txtGida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtİnternet;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader chElektrik;
        private System.Windows.Forms.ColumnHeader chSu;
        private System.Windows.Forms.ColumnHeader chİnternet;
    }
}