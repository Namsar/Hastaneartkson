namespace HastaneYönetimSistemi
{
    partial class Doktor
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
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hastaneDataSet = new HastaneYönetimSistemi.HastaneDataSet();
            this.doktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktorTableAdapter = new HastaneYönetimSistemi.HastaneDataSetTableAdapters.DoktorTableAdapter();
            this.hastaneDataSet1 = new HastaneYönetimSistemi.HastaneDataSet1();
            this.doktorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doktorTableAdapter1 = new HastaneYönetimSistemi.HastaneDataSet1TableAdapters.DoktorTableAdapter();
            this.hastaneDataSet2 = new HastaneYönetimSistemi.HastaneDataSet2();
            this.doktorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doktorTableAdapter2 = new HastaneYönetimSistemi.HastaneDataSet2TableAdapters.DoktorTableAdapter();
            this.doktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet3 = new HastaneYönetimSistemi.HastaneDataSet3();
            this.doktorlarTableAdapter = new HastaneYönetimSistemi.HastaneDataSet3TableAdapters.DoktorlarTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CİNSİYET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "BRANŞ";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(131, 169);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(148, 21);
            this.cmbCinsiyet.TabIndex = 10;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(131, 205);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(148, 21);
            this.cmbBrans.TabIndex = 11;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 132);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 19);
            this.button2.TabIndex = 16;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(203, 237);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 19);
            this.button3.TabIndex = 17;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(317, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 19);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.VisibleChanged += new System.EventHandler(this.richTextBox1_VisibleChanged);
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(17, 259);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(258, 108);
            this.listBox4.TabIndex = 20;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(131, 43);
            this.Ad.Margin = new System.Windows.Forms.Padding(2);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(148, 20);
            this.Ad.TabIndex = 22;
            this.Ad.TextChanged += new System.EventHandler(this.Ad_TextChanged);
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(131, 68);
            this.Soyad.Margin = new System.Windows.Forms.Padding(2);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(148, 20);
            this.Soyad.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(649, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 32);
            this.button4.TabIndex = 24;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "KULLANICI ADI";
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBindingSource
            // 
            this.doktorBindingSource.DataMember = "Doktor";
            this.doktorBindingSource.DataSource = this.hastaneDataSet;
            // 
            // doktorTableAdapter
            // 
            this.doktorTableAdapter.ClearBeforeFill = true;
            // 
            // hastaneDataSet1
            // 
            this.hastaneDataSet1.DataSetName = "HastaneDataSet1";
            this.hastaneDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBindingSource1
            // 
            this.doktorBindingSource1.DataMember = "Doktor";
            this.doktorBindingSource1.DataSource = this.hastaneDataSet1;
            // 
            // doktorTableAdapter1
            // 
            this.doktorTableAdapter1.ClearBeforeFill = true;
            // 
            // hastaneDataSet2
            // 
            this.hastaneDataSet2.DataSetName = "HastaneDataSet2";
            this.hastaneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorBindingSource2
            // 
            this.doktorBindingSource2.DataMember = "Doktor";
            this.doktorBindingSource2.DataSource = this.hastaneDataSet2;
            // 
            // doktorTableAdapter2
            // 
            this.doktorTableAdapter2.ClearBeforeFill = true;
            // 
            // doktorlarBindingSource
            // 
            this.doktorlarBindingSource.DataMember = "Doktorlar";
            this.doktorlarBindingSource.DataSource = this.hastaneDataSet3;
            // 
            // hastaneDataSet3
            // 
            this.hastaneDataSet3.DataSetName = "HastaneDataSet3";
            this.hastaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doktorlarTableAdapter
            // 
            this.doktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(317, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 273);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kullanıcı Adı";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dogum Tarihi";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Branş";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(317, 325);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 32);
            this.button5.TabIndex = 32;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 373);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet3)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource doktorBindingSource;
        private HastaneDataSetTableAdapters.DoktorTableAdapter doktorTableAdapter;
        private HastaneDataSet1 hastaneDataSet1;
        private System.Windows.Forms.BindingSource doktorBindingSource1;
        private HastaneDataSet1TableAdapters.DoktorTableAdapter doktorTableAdapter1;
        private HastaneDataSet2 hastaneDataSet2;
        private System.Windows.Forms.BindingSource doktorBindingSource2;
        private HastaneDataSet2TableAdapters.DoktorTableAdapter doktorTableAdapter2;
        private HastaneDataSet3 hastaneDataSet3;
        private System.Windows.Forms.BindingSource doktorlarBindingSource;
        private HastaneDataSet3TableAdapters.DoktorlarTableAdapter doktorlarTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button5;
    }
}