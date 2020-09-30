namespace personelkayitprojesi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combosehir = new System.Windows.Forms.ComboBox();
            this.txtperid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpersoyad = new System.Windows.Forms.TextBox();
            this.mtxtmaas = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtperad = new System.Windows.Forms.TextBox();
            this.permeslek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafik = new System.Windows.Forms.Button();
            this.btnist = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelvtDataSet = new personelkayitprojesi.personelvtDataSet();
            this.personelTableAdapter = new personelkayitprojesi.personelvtDataSetTableAdapters.personelTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelvtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bulunduğu Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Medeni Durum:";
            // 
            // combosehir
            // 
            this.combosehir.FormattingEnabled = true;
            this.combosehir.Location = new System.Drawing.Point(115, 120);
            this.combosehir.Name = "combosehir";
            this.combosehir.Size = new System.Drawing.Size(144, 23);
            this.combosehir.TabIndex = 4;
            // 
            // txtperid
            // 
            this.txtperid.Location = new System.Drawing.Point(115, 33);
            this.txtperid.Name = "txtperid";
            this.txtperid.Size = new System.Drawing.Size(144, 23);
            this.txtperid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 0;
            // 
            // txtpersoyad
            // 
            this.txtpersoyad.Location = new System.Drawing.Point(115, 91);
            this.txtpersoyad.Name = "txtpersoyad";
            this.txtpersoyad.Size = new System.Drawing.Size(144, 23);
            this.txtpersoyad.TabIndex = 3;
            // 
            // mtxtmaas
            // 
            this.mtxtmaas.Location = new System.Drawing.Point(115, 155);
            this.mtxtmaas.Mask = "0000";
            this.mtxtmaas.Name = "mtxtmaas";
            this.mtxtmaas.Size = new System.Drawing.Size(144, 23);
            this.mtxtmaas.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(115, 187);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(200, 187);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.mtxtmaas);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtperad);
            this.groupBox1.Controls.Add(this.txtpersoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.permeslek);
            this.groupBox1.Controls.Add(this.txtperid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combosehir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 284);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            this.label9.TextChanged += new System.EventHandler(this.label9_TextChanged);
            // 
            // txtperad
            // 
            this.txtperad.Location = new System.Drawing.Point(115, 62);
            this.txtperad.Name = "txtperad";
            this.txtperad.Size = new System.Drawing.Size(144, 23);
            this.txtperad.TabIndex = 2;
            // 
            // permeslek
            // 
            this.permeslek.Location = new System.Drawing.Point(115, 216);
            this.permeslek.Name = "permeslek";
            this.permeslek.Size = new System.Drawing.Size(144, 23);
            this.permeslek.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Meslek:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btngrafik);
            this.groupBox2.Controls.Add(this.btnist);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btnguncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(330, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 178);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btngrafik
            // 
            this.btngrafik.Location = new System.Drawing.Point(221, 97);
            this.btngrafik.Name = "btngrafik";
            this.btngrafik.Size = new System.Drawing.Size(136, 34);
            this.btngrafik.TabIndex = 6;
            this.btngrafik.Text = "Grafikler";
            this.btngrafik.UseVisualStyleBackColor = true;
            this.btngrafik.Click += new System.EventHandler(this.btngrafik_Click);
            // 
            // btnist
            // 
            this.btnist.Location = new System.Drawing.Point(221, 57);
            this.btnist.Name = "btnist";
            this.btnist.Size = new System.Drawing.Size(136, 34);
            this.btnist.TabIndex = 5;
            this.btnist.Text = "İstatistik";
            this.btnist.UseVisualStyleBackColor = true;
            this.btnist.Click += new System.EventHandler(this.btnist_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(221, 17);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(136, 34);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(36, 132);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(136, 34);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(36, 95);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(136, 34);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(36, 57);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(136, 34);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(36, 17);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(136, 34);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.dataGridView1);
            this.groupbox3.Location = new System.Drawing.Point(12, 297);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Size = new System.Drawing.Size(752, 176);
            this.groupbox3.TabIndex = 7;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "perad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "persehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "persehir";
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "permaas";
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.personelvtDataSet;
            // 
            // personelvtDataSet
            // 
            this.personelvtDataSet.DataSetName = "personelvtDataSet";
            this.personelvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SlateGray;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(363, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 45);
            this.label10.TabIndex = 9;
            this.label10.Text = "YEŞİLAY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SlateGray;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(520, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 45);
            this.label11.TabIndex = 9;
            this.label11.Text = "TOPLULUĞU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rapor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(776, 473);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupbox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupbox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelvtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combosehir;
        private System.Windows.Forms.TextBox txtperid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpersoyad;
        private System.Windows.Forms.MaskedTextBox mtxtmaas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtperad;
        private System.Windows.Forms.TextBox permeslek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafik;
        private System.Windows.Forms.Button btnist;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupbox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private personelvtDataSet personelvtDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private personelvtDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

