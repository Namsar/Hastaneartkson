namespace HastaneYönetimSistemi
{
    partial class Hemsire
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hemşireBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet5 = new HastaneYönetimSistemi.HastaneDataSet5();
            this.hemşireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet4 = new HastaneYönetimSistemi.HastaneDataSet4();
            this.hemşireTableAdapter = new HastaneYönetimSistemi.HastaneDataSet4TableAdapters.HemşireTableAdapter();
            this.hemşireTableAdapter1 = new HastaneYönetimSistemi.HastaneDataSet5TableAdapters.HemşireTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hemşireBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hemşireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Branş";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(378, 49);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(352, 24);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "Arama...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastaneYönetimSistemi.Properties.Resources.hastanelogo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(124, 264);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(197, 21);
            this.cmbCinsiyet.TabIndex = 25;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(124, 306);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(197, 21);
            this.cmbBrans.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(656, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 20);
            this.textBox4.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // hemşireBindingSource1
            // 
            this.hemşireBindingSource1.DataMember = "Hemşire";
            this.hemşireBindingSource1.DataSource = this.hastaneDataSet5;
            // 
            // hastaneDataSet5
            // 
            this.hastaneDataSet5.DataSetName = "HastaneDataSet5";
            this.hastaneDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hemşireBindingSource
            // 
            this.hemşireBindingSource.DataMember = "Hemşire";
            this.hemşireBindingSource.DataSource = this.hastaneDataSet4;
            this.hemşireBindingSource.CurrentChanged += new System.EventHandler(this.hemşireBindingSource_CurrentChanged);
            // 
            // hastaneDataSet4
            // 
            this.hastaneDataSet4.DataSetName = "HastaneDataSet4";
            this.hastaneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hemşireTableAdapter
            // 
            this.hemşireTableAdapter.ClearBeforeFill = true;
            // 
            // hemşireTableAdapter1
            // 
            this.hemşireTableAdapter1.ClearBeforeFill = true;
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
            this.listView1.Location = new System.Drawing.Point(378, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 313);
            this.listView1.TabIndex = 30;
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
            this.columnHeader5.Text = "Doğum Tarihi";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Branş";
            // 
            // Hemsire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 426);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Hemsire";
            this.Text = "Hemsire";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.Shown += new System.EventHandler(this.Form7_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hemşireBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hemşireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private HastaneDataSet4 hastaneDataSet4;
        private System.Windows.Forms.BindingSource hemşireBindingSource;
        private HastaneDataSet4TableAdapters.HemşireTableAdapter hemşireTableAdapter;
        private HastaneDataSet5 hastaneDataSet5;
        private System.Windows.Forms.BindingSource hemşireBindingSource1;
        private HastaneDataSet5TableAdapters.HemşireTableAdapter hemşireTableAdapter1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}