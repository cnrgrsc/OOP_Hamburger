using OOP_Hamburger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<HamburgerMenusu> menuler = new List<HamburgerMenusu>
            {
                new HamburgerMenusu{Ad="Texas Smokhouse",Fiyat=15,Description="Gurme Menusunden Enfez bir Lezzet"},
                new HamburgerMenusu{Ad="Tavuk Burger",Fiyat=17,Description="Yiii Benii"},
                new HamburgerMenusu{Ad="Double Burger",Fiyat=18,Description="Double Yiii Benii"},
                new HamburgerMenusu{Ad="MacBurger",Fiyat=20,Description="Bandir Bandir Yii Beni"},
                new HamburgerMenusu{Ad="Pastirmani",Fiyat=15,Description="Cig Etim Kadar Cekicimisin"}
            };
            foreach (HamburgerMenusu item in menuler)
            {
                cmbMenuler.Items.Add(item);
            }
        }

        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDurum.Text = (cmbMenuler.SelectedItem as HamburgerMenusu).Description;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.SecilenMenu = cmbMenuler.SelectedItem as HamburgerMenusu;

            s.Adet = Convert.ToInt16(nmrAdet.Value);
            if (rndBuyuk.Checked) s.Buyukluk = Enum.Boyut.Buyuk;
            else if (rndOrta.Checked) s.Buyukluk = Enum.Boyut.Orta;
            else s.Buyukluk = Enum.Boyut.Kucuk;

            foreach (CheckBox item in grbMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    ExtraMalzeme ex = new ExtraMalzeme();
                    ex.Ad = item.Text;
                    ex.Fiyat = Convert.ToDecimal(item.Tag);
                    s.Malzemeleri.Add(ex);
                }
            }
            s.TutarHesapla();
            lstSiparisler.Items.Add(s);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal toplam = 0;
            foreach (Siparis item in lstSiparisler.Items)
            {
                toplam += item.ToplamTutar;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
