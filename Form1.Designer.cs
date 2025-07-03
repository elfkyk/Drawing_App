
namespace CizimUygulaması
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cember = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_renk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.secilen_renk = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kalem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_kaydet);
            this.panel2.Controls.Add(this.btn_cember);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_renk);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.secilen_renk);
            this.panel2.Controls.Add(this.btn_temizle);
            this.panel2.Controls.Add(this.btn_sil);
            this.panel2.Controls.Add(this.btn_kalem);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 99);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::CizimUygulaması.Properties.Resources.line_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(786, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 82);
            this.button2.TabIndex = 15;
            this.button2.Text = "Çizgi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_cember
            // 
            this.btn_cember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cember.Image = global::CizimUygulaması.Properties.Resources.circle_iconn;
            this.btn_cember.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cember.Location = new System.Drawing.Point(587, 8);
            this.btn_cember.Name = "btn_cember";
            this.btn_cember.Size = new System.Drawing.Size(77, 82);
            this.btn_cember.TabIndex = 14;
            this.btn_cember.Text = "Elips";
            this.btn_cember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cember.UseVisualStyleBackColor = true;
            this.btn_cember.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = global::CizimUygulaması.Properties.Resources.rectangle_icon4;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(679, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 80);
            this.button3.TabIndex = 13;
            this.button3.Text = "Dikdörtgen";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_renk
            // 
            this.btn_renk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_renk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_renk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_renk.Image = global::CizimUygulaması.Properties.Resources._2024_12_06_21_18_58;
            this.btn_renk.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_renk.Location = new System.Drawing.Point(293, 6);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(90, 82);
            this.btn_renk.TabIndex = 1;
            this.btn_renk.Text = "Renkler";
            this.btn_renk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_renk.UseVisualStyleBackColor = false;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kalınlık:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(883, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dosya Seç";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secilen_renk
            // 
            this.secilen_renk.Location = new System.Drawing.Point(10, 14);
            this.secilen_renk.Name = "secilen_renk";
            this.secilen_renk.Size = new System.Drawing.Size(58, 54);
            this.secilen_renk.TabIndex = 8;
            this.secilen_renk.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kaydet.Image = global::CizimUygulaması.Properties.Resources._2024_12_07_21_52_54;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(883, 6);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(111, 38);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "         Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_temizle.Image = global::CizimUygulaması.Properties.Resources.clr2;
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_temizle.Location = new System.Drawing.Point(499, 6);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(73, 80);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.Image = global::CizimUygulaması.Properties.Resources.eraser2;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sil.Location = new System.Drawing.Point(405, 6);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 80);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Silgi";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kalem
            // 
            this.btn_kalem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_kalem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kalem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kalem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kalem.Image = global::CizimUygulaması.Properties.Resources.pencil2;
            this.btn_kalem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kalem.Location = new System.Drawing.Point(200, 6);
            this.btn_kalem.Name = "btn_kalem";
            this.btn_kalem.Size = new System.Drawing.Size(77, 82);
            this.btn_kalem.TabIndex = 3;
            this.btn_kalem.Text = "Kalem";
            this.btn_kalem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kalem.UseVisualStyleBackColor = false;
            this.btn_kalem.Click += new System.EventHandler(this.btn_kalem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(2, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 44);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1091, 345);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_renk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_kalem;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button secilen_renk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_cember;
        private System.Windows.Forms.Button button2;
    }
}

