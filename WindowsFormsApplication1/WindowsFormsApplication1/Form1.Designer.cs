namespace WindowsFormsApplication1
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
            this.cboxotbüstürü = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxmüsteribilgi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkydet = new System.Windows.Forms.Button();
            this.labelotobüstürü = new System.Windows.Forms.Label();
            this.labelkoltukno = new System.Windows.Forms.Label();
            this.grbxcinsiyet = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxmüsteribilgi.SuspendLayout();
            this.grbxcinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxotbüstürü
            // 
            this.cboxotbüstürü.FormattingEnabled = true;
            this.cboxotbüstürü.Items.AddRange(new object[] {
            "travego",
            "setra\t\t"});
            this.cboxotbüstürü.Location = new System.Drawing.Point(0, 151);
            this.cboxotbüstürü.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxotbüstürü.Name = "cboxotbüstürü";
            this.cboxotbüstürü.Size = new System.Drawing.Size(117, 24);
            this.cboxotbüstürü.TabIndex = 0;
            this.cboxotbüstürü.SelectedIndexChanged += new System.EventHandler(this.cboxotbüstürü_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-5, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs türü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(289, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 458);
            this.panel1.TabIndex = 3;
            // 
            // gboxmüsteribilgi
            // 
            this.gboxmüsteribilgi.Controls.Add(this.label4);
            this.gboxmüsteribilgi.Controls.Add(this.label3);
            this.gboxmüsteribilgi.Controls.Add(this.btnkydet);
            this.gboxmüsteribilgi.Controls.Add(this.labelotobüstürü);
            this.gboxmüsteribilgi.Controls.Add(this.labelkoltukno);
            this.gboxmüsteribilgi.Controls.Add(this.grbxcinsiyet);
            this.gboxmüsteribilgi.Controls.Add(this.textBox1);
            this.gboxmüsteribilgi.Controls.Add(this.label2);
            this.gboxmüsteribilgi.Location = new System.Drawing.Point(843, 122);
            this.gboxmüsteribilgi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxmüsteribilgi.Name = "gboxmüsteribilgi";
            this.gboxmüsteribilgi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxmüsteribilgi.Size = new System.Drawing.Size(459, 458);
            this.gboxmüsteribilgi.TabIndex = 4;
            this.gboxmüsteribilgi.TabStop = false;
            this.gboxmüsteribilgi.Text = "müşteribilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "otobüstürü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "koltukno::";
            // 
            // btnkydet
            // 
            this.btnkydet.Location = new System.Drawing.Point(29, 274);
            this.btnkydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkydet.Name = "btnkydet";
            this.btnkydet.Size = new System.Drawing.Size(115, 36);
            this.btnkydet.TabIndex = 5;
            this.btnkydet.Text = "Kaydet";
            this.btnkydet.UseVisualStyleBackColor = true;
            this.btnkydet.Click += new System.EventHandler(this.btnkydet_Click);
            // 
            // labelotobüstürü
            // 
            this.labelotobüstürü.AutoSize = true;
            this.labelotobüstürü.Location = new System.Drawing.Point(132, 241);
            this.labelotobüstürü.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelotobüstürü.Name = "labelotobüstürü";
            this.labelotobüstürü.Size = new System.Drawing.Size(0, 17);
            this.labelotobüstürü.TabIndex = 4;
            // 
            // labelkoltukno
            // 
            this.labelkoltukno.AutoSize = true;
            this.labelkoltukno.Location = new System.Drawing.Point(139, 201);
            this.labelkoltukno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelkoltukno.Name = "labelkoltukno";
            this.labelkoltukno.Size = new System.Drawing.Size(0, 17);
            this.labelkoltukno.TabIndex = 3;
            // 
            // grbxcinsiyet
            // 
            this.grbxcinsiyet.Controls.Add(this.radioButton2);
            this.grbxcinsiyet.Controls.Add(this.radioButton1);
            this.grbxcinsiyet.Location = new System.Drawing.Point(29, 92);
            this.grbxcinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbxcinsiyet.Name = "grbxcinsiyet";
            this.grbxcinsiyet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbxcinsiyet.Size = new System.Drawing.Size(189, 81);
            this.grbxcinsiyet.TabIndex = 2;
            this.grbxcinsiyet.TabStop = false;
            this.grbxcinsiyet.Text = "cinsiyet";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 37);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "kadın";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "erkek";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adsoyad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1317, 594);
            this.Controls.Add(this.gboxmüsteribilgi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxotbüstürü);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxmüsteribilgi.ResumeLayout(false);
            this.gboxmüsteribilgi.PerformLayout();
            this.grbxcinsiyet.ResumeLayout(false);
            this.grbxcinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxotbüstürü;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxmüsteribilgi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbxcinsiyet;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelkoltukno;
        private System.Windows.Forms.Label labelotobüstürü;
        private System.Windows.Forms.Button btnkydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

