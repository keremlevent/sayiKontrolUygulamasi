namespace nypÖdevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Sayı");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Sayı");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Sayı");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Sayı");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCiftCarpimSonucu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCiftToplamSonucu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listCiftSayilar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTekCarpimSonucu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTekToplamSonucu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listTekSayilar = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtAsalCarpimSonucu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAsalToplamSonucu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listAsalSayilar = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtMukemmelCarpimSonucu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMukemmelToplamSonucu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listMukemmelSayilar = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpHesap = new System.Windows.Forms.GroupBox();
            this.txtBitisDegeri = new System.Windows.Forms.MaskedTextBox();
            this.txtBaslangicDegeri = new System.Windows.Forms.MaskedTextBox();
            this.buton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpHesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(108, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 208);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCiftCarpimSonucu);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCiftToplamSonucu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listCiftSayilar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 182);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Çift Sayılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCiftCarpimSonucu
            // 
            this.txtCiftCarpimSonucu.Location = new System.Drawing.Point(243, 141);
            this.txtCiftCarpimSonucu.Name = "txtCiftCarpimSonucu";
            this.txtCiftCarpimSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtCiftCarpimSonucu.TabIndex = 7;
            this.txtCiftCarpimSonucu.TextChanged += new System.EventHandler(this.txtCiftCarpimSonucu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Çarpım";
            // 
            // txtCiftToplamSonucu
            // 
            this.txtCiftToplamSonucu.Location = new System.Drawing.Point(243, 96);
            this.txtCiftToplamSonucu.Name = "txtCiftToplamSonucu";
            this.txtCiftToplamSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtCiftToplamSonucu.TabIndex = 5;
            this.txtCiftToplamSonucu.TextChanged += new System.EventHandler(this.txtCiftToplamSonucu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam";
            // 
            // listCiftSayilar
            // 
            this.listCiftSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listCiftSayilar.HideSelection = false;
            this.listCiftSayilar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10});
            this.listCiftSayilar.Location = new System.Drawing.Point(30, 17);
            this.listCiftSayilar.Name = "listCiftSayilar";
            this.listCiftSayilar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listCiftSayilar.Size = new System.Drawing.Size(483, 52);
            this.listCiftSayilar.TabIndex = 3;
            this.listCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.listCiftSayilar.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTekCarpimSonucu);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtTekToplamSonucu);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listTekSayilar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tek Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTekCarpimSonucu
            // 
            this.txtTekCarpimSonucu.Location = new System.Drawing.Point(245, 143);
            this.txtTekCarpimSonucu.Name = "txtTekCarpimSonucu";
            this.txtTekCarpimSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtTekCarpimSonucu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Çarpım";
            // 
            // txtTekToplamSonucu
            // 
            this.txtTekToplamSonucu.Location = new System.Drawing.Point(245, 98);
            this.txtTekToplamSonucu.Name = "txtTekToplamSonucu";
            this.txtTekToplamSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtTekToplamSonucu.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Toplam";
            // 
            // listTekSayilar
            // 
            this.listTekSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listTekSayilar.HideSelection = false;
            this.listTekSayilar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11});
            this.listTekSayilar.Location = new System.Drawing.Point(32, 19);
            this.listTekSayilar.Name = "listTekSayilar";
            this.listTekSayilar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listTekSayilar.Size = new System.Drawing.Size(483, 52);
            this.listTekSayilar.TabIndex = 8;
            this.listTekSayilar.UseCompatibleStateImageBehavior = false;
            this.listTekSayilar.View = System.Windows.Forms.View.List;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtAsalCarpimSonucu);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtAsalToplamSonucu);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.listAsalSayilar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(546, 182);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtAsalCarpimSonucu
            // 
            this.txtAsalCarpimSonucu.Location = new System.Drawing.Point(245, 143);
            this.txtAsalCarpimSonucu.Name = "txtAsalCarpimSonucu";
            this.txtAsalCarpimSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtAsalCarpimSonucu.TabIndex = 12;
            this.txtAsalCarpimSonucu.TextChanged += new System.EventHandler(this.txtAsalCarpimSonucu_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Çarpım";
            // 
            // txtAsalToplamSonucu
            // 
            this.txtAsalToplamSonucu.Location = new System.Drawing.Point(245, 98);
            this.txtAsalToplamSonucu.Name = "txtAsalToplamSonucu";
            this.txtAsalToplamSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtAsalToplamSonucu.TabIndex = 10;
            this.txtAsalToplamSonucu.TextChanged += new System.EventHandler(this.txtAsalToplamSonucu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Toplam";
            // 
            // listAsalSayilar
            // 
            this.listAsalSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listAsalSayilar.HideSelection = false;
            this.listAsalSayilar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9});
            this.listAsalSayilar.Location = new System.Drawing.Point(32, 19);
            this.listAsalSayilar.Name = "listAsalSayilar";
            this.listAsalSayilar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listAsalSayilar.Size = new System.Drawing.Size(483, 52);
            this.listAsalSayilar.TabIndex = 8;
            this.listAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.listAsalSayilar.View = System.Windows.Forms.View.List;
            this.listAsalSayilar.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtMukemmelCarpimSonucu);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtMukemmelToplamSonucu);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.listMukemmelSayilar);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(546, 182);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtMukemmelCarpimSonucu
            // 
            this.txtMukemmelCarpimSonucu.Location = new System.Drawing.Point(245, 143);
            this.txtMukemmelCarpimSonucu.Name = "txtMukemmelCarpimSonucu";
            this.txtMukemmelCarpimSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtMukemmelCarpimSonucu.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Çarpım";
            // 
            // txtMukemmelToplamSonucu
            // 
            this.txtMukemmelToplamSonucu.Location = new System.Drawing.Point(245, 98);
            this.txtMukemmelToplamSonucu.Name = "txtMukemmelToplamSonucu";
            this.txtMukemmelToplamSonucu.Size = new System.Drawing.Size(100, 20);
            this.txtMukemmelToplamSonucu.TabIndex = 10;
            this.txtMukemmelToplamSonucu.TextChanged += new System.EventHandler(this.txtMukemmelToplamSonucu_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Toplam";
            // 
            // listMukemmelSayilar
            // 
            this.listMukemmelSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.listMukemmelSayilar.HideSelection = false;
            this.listMukemmelSayilar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12});
            this.listMukemmelSayilar.Location = new System.Drawing.Point(32, 19);
            this.listMukemmelSayilar.Name = "listMukemmelSayilar";
            this.listMukemmelSayilar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listMukemmelSayilar.Size = new System.Drawing.Size(483, 52);
            this.listMukemmelSayilar.TabIndex = 8;
            this.listMukemmelSayilar.UseCompatibleStateImageBehavior = false;
            this.listMukemmelSayilar.View = System.Windows.Forms.View.List;
            // 
            // grpHesap
            // 
            this.grpHesap.Controls.Add(this.txtBitisDegeri);
            this.grpHesap.Controls.Add(this.txtBaslangicDegeri);
            this.grpHesap.Controls.Add(this.buton);
            this.grpHesap.Controls.Add(this.label2);
            this.grpHesap.Controls.Add(this.label1);
            this.grpHesap.Location = new System.Drawing.Point(94, 36);
            this.grpHesap.Name = "grpHesap";
            this.grpHesap.Size = new System.Drawing.Size(612, 118);
            this.grpHesap.TabIndex = 5;
            this.grpHesap.TabStop = false;
            this.grpHesap.Text = "Hesap";
            // 
            // txtBitisDegeri
            // 
            this.txtBitisDegeri.Location = new System.Drawing.Point(338, 51);
            this.txtBitisDegeri.Mask = "00000";
            this.txtBitisDegeri.Name = "txtBitisDegeri";
            this.txtBitisDegeri.Size = new System.Drawing.Size(100, 20);
            this.txtBitisDegeri.TabIndex = 8;
            this.txtBitisDegeri.ValidatingType = typeof(int);
            this.txtBitisDegeri.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBitisDegeri_MaskInputRejected);
            this.txtBitisDegeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBitisDegeri_KeyPress);
            // 
            // txtBaslangicDegeri
            // 
            this.txtBaslangicDegeri.Location = new System.Drawing.Point(118, 51);
            this.txtBaslangicDegeri.Mask = "00000";
            this.txtBaslangicDegeri.Name = "txtBaslangicDegeri";
            this.txtBaslangicDegeri.Size = new System.Drawing.Size(100, 20);
            this.txtBaslangicDegeri.TabIndex = 7;
            this.txtBaslangicDegeri.ValidatingType = typeof(int);
            this.txtBaslangicDegeri.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.txtBaslangicDegeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaslangicDegeri_KeyPress);
            // 
            // buton
            // 
            this.buton.Location = new System.Drawing.Point(468, 51);
            this.buton.Name = "buton";
            this.buton.Size = new System.Drawing.Size(75, 23);
            this.buton.TabIndex = 4;
            this.buton.Text = "Çalıştır";
            this.buton.UseVisualStyleBackColor = true;
            this.buton.Click += new System.EventHandler(this.buton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baslangic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpHesap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.grpHesap.ResumeLayout(false);
            this.grpHesap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCiftCarpimSonucu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCiftToplamSonucu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listCiftSayilar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox grpHesap;
        private System.Windows.Forms.Button buton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTekCarpimSonucu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTekToplamSonucu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listTekSayilar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtAsalCarpimSonucu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAsalToplamSonucu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listAsalSayilar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtMukemmelCarpimSonucu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMukemmelToplamSonucu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listMukemmelSayilar;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MaskedTextBox txtBaslangicDegeri;
        private System.Windows.Forms.MaskedTextBox txtBitisDegeri;
    }
}

