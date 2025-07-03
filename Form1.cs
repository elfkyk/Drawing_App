using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CizimUygulaması
{

    public partial class Form1 : Form
    {
        private Image yuklenecekResim;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new object[] { 1, 3, 5, 7, 10, 20, 30 }); 
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.BackgroundImage = bm;
        }
        
        
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black,1);

        Pen erase = new Pen(Color.White,50);
        int index;
        int x, y,cX,cY,sX,sY;
        ColorDialog cd = new ColorDialog();
        Color yeni_renk;
        

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {

            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;

          
        }


        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
           
                if (paint) //cizim yapılıyorsa
            {
                x = e.X; //fare ile tıklanan veya hareket ettirilen koordinatlar
                y = e.Y; // bu da oyle
                sX = x - cX;
                sY = y - cY;
               pictureBox1.Invalidate(); //her yeni çizgi veya silme işlemi ekranda anında görünmesi icin

                if (index == 1) 
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;

                }
                if (index == 2) 
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
               }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
         

            if (index==3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);

            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);

            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);


            }
            pictureBox1.Invalidate();

        }
        

        private void btn_sil_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.BackgroundImage = bm;
            pictureBox1.Refresh();
            index = 0;
        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            yeni_renk = cd.Color;
            secilen_renk.BackColor = cd.Color;
            p.Color = cd.Color;

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Resim Dosyaları(*.jpg)|*.jpg|(*.*|*.*)";
            if (sfd.ShowDialog()==DialogResult.OK)

            {
                Bitmap btm = bm.Clone(new Rectangle(0,0,pictureBox1.Width,pictureBox1.Height),bm.PixelFormat);
                 btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Dosya başarıyla kaydedildi !");

                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //elips butonu
            index = 3;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //dikdortgen butonu
            index = 4;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //cizgi butonu
            index = 5;

        }

        private void button1_Click(object sender, EventArgs e) //Dosya Seç butonu
        {
            
            OpenFileDialog ofd= new OpenFileDialog();
            ofd.Title = "Lütfen Aradığınız Dosyayı Seçiniz.";
            ofd.FileName = "Dosya Seç";
            // ofd.Filter= "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";
            //if (ofd.ShowDialog() == DialogResult.OK)
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                yuklenecekResim= Image.FromFile(ofd.FileName);

                pictureBox1.Invalidate();
            }
           


        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedWidth = Convert.ToInt32(comboBox1.SelectedItem);
            p.Width = selectedWidth;

           

        }

        private void btn_kalem_Click(object sender, EventArgs e)

        {
            index = 1;
            

        }

       

       
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pic_Paint(object sender, PaintEventArgs e)
        {
            if (yuklenecekResim != null)
            {
                int x = (pictureBox1.Width-yuklenecekResim.Width) / 2;
                int y = (pictureBox1.Height-yuklenecekResim.Height) / 2;
                e.Graphics.DrawImage(yuklenecekResim, x, y);
            }
            if (paint)
            {
                // Geçici çizim
                if (index == 3)
                {
                    e.Graphics.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    e.Graphics.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    e.Graphics.DrawLine(p, cX, cY, x, y);
                }
            }
        }


    }
}
