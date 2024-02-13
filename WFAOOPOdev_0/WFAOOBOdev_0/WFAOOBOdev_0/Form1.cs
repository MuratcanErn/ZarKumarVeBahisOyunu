using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAOOBOdev_0
{
    public partial class Form1 : Form
    {//


        //OzelSaldırının özelligi gelen rastgele sayının 3. katını vursun...

        //Kullanıcı her level atladıgında +10 can alsın... Ve vurus hasarının aralıgı 10'ar sekilde artsın...

       
        public Form1()
        {
            InitializeComponent();
        }
        public void OzelSaldiri()
        {

            if (seviye == 1)
            {
                ozelSaldiri--;
                Dusman1.DusmanCani -= Kullanici1.KullaniciHasari = 3 * rnd.Next(10, 20);
                Kullanici1.KullaniciCani -= Dusman1.DusmanHasari = rnd.Next(10, 20);
                lblSonuc.Text = $"Kullanıcı{Kullanici1.KullaniciHasari} kadar hasar verdi ve {Dusman1.DusmanHasari} kadar hasar aldı";
                lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                lblDusmanCan.Text = Dusman1.DusmanCani.ToString();
                if (Dusman1.DusmanCani <= 0)
                {

                    seviye++;
                    lblLevel.Text = seviye.ToString();
                    MessageBox.Show($"Tebrikler {seviye}. geçtiniz");
                    Kullanici1.KullaniciCani = 100 + 10;
                    lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                    lblDusmanIsim.Text = Dusman2.DusmanAdi = "Garen";
                    Dusman2.DusmanCani = rnd.Next(80, 100);
                    lblDusmanCan.Text = Dusman2.DusmanCani.ToString();
                    ozelSaldiri = 3;
                }
                if (Kullanici1.KullaniciCani <= 0)
                {
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();
                }
            }
            else if (seviye == 2)
            {
                ozelSaldiri--;
                Dusman2.DusmanCani -= Kullanici1.KullaniciHasari =3* rnd.Next(10, 30);
                Kullanici1.KullaniciCani -= Dusman2.DusmanHasari = rnd.Next(10, 20);
                lblSonuc.Text = $"Kullanıcı{Kullanici1.KullaniciHasari} kadar hasar verdi ve {Dusman2.DusmanHasari} kadar hasar aldı";
                lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                lblDusmanCan.Text = Dusman2.DusmanCani.ToString();
                if (Dusman2.DusmanCani <= 0)
                {
                    seviye++;
                    lblLevel.Text = seviye.ToString();
                    MessageBox.Show($"Tebrikler {seviye}. geçtiniz");
                    Kullanici1.KullaniciCani = 100 + 10;
                    lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                    lblDusmanIsim.Text = Dusman3.DusmanAdi = "Zed";
                    Dusman3.DusmanCani = rnd.Next(100, 120);
                    lblDusmanCan.Text = Dusman3.DusmanCani.ToString();
                    ozelSaldiri = 3;
                }
                if (Kullanici1.KullaniciCani <= 0)
                {
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();
                }
            }
            else if (seviye == 3)
            {
                ozelSaldiri--;
                Dusman3.DusmanCani -= Kullanici1.KullaniciHasari = 3*rnd.Next(10, 40);
                Kullanici1.KullaniciCani -= Dusman3.DusmanHasari = rnd.Next(10, 20);
                lblSonuc.Text = $"Kullanıcı{Kullanici1.KullaniciHasari} kadar hasar verdi ve {Dusman3.DusmanHasari} kadar hasar aldı";
                lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                lblDusmanCan.Text = Dusman3.DusmanCani.ToString();
                if (Dusman3.DusmanCani <= 0)
                {
                    MessageBox.Show("Tebrikler Kazandınız");
                    Application.Exit();

                }
                else if (Kullanici1.KullaniciCani <= 0)
                {
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();
                }
            }
        }
        public void Seviyes()
        {
            if(seviye==1)
            {
                Dusman1.DusmanCani -= Kullanici1.KullaniciHasari = rnd.Next(10, 20);
                Kullanici1.KullaniciCani-=Dusman1.DusmanHasari=rnd.Next(10, 20);
                lblSonuc.Text = $"Kullanıcı{Kullanici1.KullaniciHasari} kadar hasar verdi ve {Dusman1.DusmanHasari} kadar hasar aldı";
                lblKullaniciCan.Text=Kullanici1.KullaniciCani.ToString();
                lblDusmanCan.Text=Dusman1.DusmanCani.ToString();
                if (Dusman1.DusmanCani<=0)
                {
                    
                    seviye++;
                    lblLevel.Text=seviye.ToString();
                    MessageBox.Show($"Tebrikler {seviye}. geçtiniz");
                    Kullanici1.KullaniciCani = 100 + 10;
                    lblKullaniciCan.Text=Kullanici1.KullaniciCani.ToString() ;
                    lblDusmanIsim.Text = Dusman2.DusmanAdi = "Garen";
                    Dusman2.DusmanCani= rnd.Next(80, 100);
                    lblDusmanCan.Text = Dusman2.DusmanCani.ToString();
                    ozelSaldiri = 3;
                }
                if (Kullanici1.KullaniciCani<=0)
                {
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();
                }
            }
            else if (seviye == 2)
            {
                
                Dusman2.DusmanCani -= Kullanici1.KullaniciHasari = rnd.Next(10, 30);
                Kullanici1.KullaniciCani -= Dusman2.DusmanHasari = rnd.Next(10, 20);
                lblSonuc.Text = $"Kullanıcı{Kullanici1.KullaniciHasari} kadar hasar verdi ve {Dusman2.DusmanHasari} kadar hasar aldı";
                lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                lblDusmanCan.Text = Dusman2.DusmanCani.ToString();
                if (Dusman2.DusmanCani<=0)
                {
                    seviye++;
                    lblLevel.Text = seviye.ToString();
                    MessageBox.Show($"Tebrikler {seviye}. geçtiniz");
                    Kullanici1.KullaniciCani = 100 + 10;
                    lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                    lblDusmanIsim.Text = Dusman3.DusmanAdi = "Zed";
                    Dusman3.DusmanCani = rnd.Next(100, 120);
                    lblDusmanCan.Text = Dusman3.DusmanCani.ToString();
                    ozelSaldiri = 3;
                }
                if (Kullanici1.KullaniciCani <= 0)
                {
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();
                }
            }
            else if (seviye == 3)
            {
                Dusman3.DusmanCani -= Kullanici1.KullaniciHasari = rnd.Next(10, 40);
                Kullanici1.KullaniciCani -= Dusman3.DusmanHasari = rnd.Next(10, 20);
                lblSonuc.Text = $"Kullanıcı{Kullanici1.KullaniciHasari} kadar hasar verdi ve {Dusman3.DusmanHasari} kadar hasar aldı";
                lblKullaniciCan.Text = Kullanici1.KullaniciCani.ToString();
                lblDusmanCan.Text=Dusman3.DusmanCani.ToString();
                if (Dusman3.DusmanCani<=0)
                {
                    MessageBox.Show("Tebrikler Kazandınız");
                    Application.Exit(); 

                }
                else if (Kullanici1.KullaniciCani<=0)
                {
                    MessageBox.Show("Kaybettiniz");
                    Application.Exit();
                }
            }
            
        }
        Kullanici Kullanici1= new Kullanici();
        Random rnd = new Random();
        Dusman Dusman1 = new Dusman();
        Dusman Dusman2= new Dusman();
        Dusman Dusman3 = new Dusman();
        int ozelSaldiri = 3, seviye;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnOzelSaldiri.Enabled = false;
            btnSaldir.Enabled = false;
        }

        private void btnBasla_Click(object sender, EventArgs e)

        {
            Kullanici1.KullaniciCani = 100;
            lblKullaniciCan.Text=Kullanici1.KullaniciCani.ToString();
            lblKullaniciIsim.Text = txtIsim.Text;
            lblDusmanIsim.Text = Dusman1.DusmanAdi = "Teemo";
            Dusman1.DusmanCani = rnd.Next(60, 80);
            lblDusmanCan.Text=Dusman1.DusmanCani.ToString();
            seviye =1;
            lblLevel.Text = seviye.ToString();
            btnSaldir.Enabled = true;
            btnOzelSaldiri.Enabled=true;
        }

        private void btnOzelSaldiri_Click(object sender, EventArgs e)
        {
            OzelSaldiri();
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            Seviyes();
        }
    }
}
