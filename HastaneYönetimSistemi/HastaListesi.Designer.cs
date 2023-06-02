namespace HastaneYönetimSistemi
{
    partial class HastaListesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugünün Hasta Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Muayene işlemi için listeden hasta bilgileri üzerine çift tıklayınız.";
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(86, 372);
=======
            this.button1.Location = new System.Drawing.Point(86, 417);
>>>>>>> d1a42ffafc195b77062166c80d6ec4a771c12580
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hastayı Çağır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(308, 372);
=======
            this.button2.Location = new System.Drawing.Point(311, 417);
>>>>>>> d1a42ffafc195b77062166c80d6ec4a771c12580
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hastaları Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
<<<<<<< HEAD
            this.button3.Location = new System.Drawing.Point(547, 372);
=======
            this.button3.Location = new System.Drawing.Point(547, 417);
>>>>>>> d1a42ffafc195b77062166c80d6ec4a771c12580
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 87);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(86, 65);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(578, 262);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TC";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Poliklinik";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hekim";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Tarihi";
            this.columnHeader5.Width = 92;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Randevu Saati";
            this.columnHeader6.Width = 87;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(121, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(331, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // HastaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
<<<<<<< HEAD
=======
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView2);
>>>>>>> d1a42ffafc195b77062166c80d6ec4a771c12580
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaListesi";
            this.Text = "HastaListesi";
            this.Load += new System.EventHandler(this.HastaListesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}