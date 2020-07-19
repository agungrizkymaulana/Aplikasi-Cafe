namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdjenis = new System.Windows.Forms.ComboBox();
            this.cmdnama = new System.Windows.Forms.ComboBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtpotongan = new System.Windows.Forms.TextBox();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Makanan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Makanan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Harga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Potongan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Bayar : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Penjualan Makanan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(549, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Potongan 50 ribu untuk total pembelian diatas 500 ribu";
            // 
            // cmdjenis
            // 
            this.cmdjenis.FormattingEnabled = true;
            this.cmdjenis.Location = new System.Drawing.Point(209, 71);
            this.cmdjenis.Name = "cmdjenis";
            this.cmdjenis.Size = new System.Drawing.Size(147, 21);
            this.cmdjenis.TabIndex = 10;
            this.cmdjenis.SelectedIndexChanged += new System.EventHandler(this.cmdjenis_SelectedIndexChanged);
            // 
            // cmdnama
            // 
            this.cmdnama.FormattingEnabled = true;
            this.cmdnama.Location = new System.Drawing.Point(209, 114);
            this.cmdnama.Name = "cmdnama";
            this.cmdnama.Size = new System.Drawing.Size(147, 21);
            this.cmdnama.TabIndex = 11;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(209, 152);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(151, 20);
            this.txtharga.TabIndex = 12;
            // 
            // txtjumlah
            // 
            this.txtjumlah.Location = new System.Drawing.Point(209, 199);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(151, 20);
            this.txtjumlah.TabIndex = 13;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(583, 155);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(151, 20);
            this.txttotal.TabIndex = 14;
            // 
            // txtpotongan
            // 
            this.txtpotongan.Location = new System.Drawing.Point(583, 199);
            this.txtpotongan.Name = "txtpotongan";
            this.txtpotongan.Size = new System.Drawing.Size(151, 20);
            this.txtpotongan.TabIndex = 15;
            // 
            // txtbayar
            // 
            this.txtbayar.Location = new System.Drawing.Point(583, 230);
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(151, 20);
            this.txtbayar.TabIndex = 16;
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(81, 290);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(143, 37);
            this.btnhitung.TabIndex = 17;
            this.btnhitung.Text = "Hitung";
            this.btnhitung.UseVisualStyleBackColor = true;
            // 
            // btnbatal
            // 
            this.btnbatal.Location = new System.Drawing.Point(305, 290);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(157, 37);
            this.btnbatal.TabIndex = 18;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(791, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.txtbayar);
            this.Controls.Add(this.txtpotongan);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.cmdnama);
            this.Controls.Add(this.cmdjenis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmdjenis;
        private System.Windows.Forms.ComboBox cmdnama;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtpotongan;
        private System.Windows.Forms.TextBox txtbayar;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

