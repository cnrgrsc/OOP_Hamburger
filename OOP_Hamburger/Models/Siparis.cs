using OOP_Hamburger.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburger.Models
{
    public class Siparis
    {
        public Siparis()
        {
            Malzemeleri = new List<ExtraMalzeme>();
        }
        public HamburgerMenusu SecilenMenu { get; set; }
        public short Adet { get; set; }
        public Boyut Buyukluk { get; set; }
        public List<ExtraMalzeme> Malzemeleri { get; set; }
        public decimal ToplamTutar { get; set; }

        public void TutarHesapla()
        {
            ToplamTutar = SecilenMenu.Fiyat;

            switch (Buyukluk)
            {
                
                case Boyut.Orta:
                    ToplamTutar += 1;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += 2;
                    break;
                
            }
            foreach (ExtraMalzeme item in Malzemeleri)
            {
                ToplamTutar += item.Fiyat;
            }
            ToplamTutar *= Adet;

        }
        public override string ToString()
        {
            if (Malzemeleri.Count<1)
            {
                return $"{SecilenMenu.Ad} Menusu,x{Adet},{Buyukluk} boy, Topla:{ToplamTutar:C2}";
            }
            else
            {
                string malzemesi = null;
                foreach (ExtraMalzeme item in Malzemeleri)
                {
                    malzemesi += $"{item.Ad},";
                }
                malzemesi = malzemesi.TrimEnd(',');
                return $"{SecilenMenu.Ad} menusu,{Buyukluk} boy,x{Adet},malzemleri:{malzemesi},Toplam Tutar=>{ToplamTutar:C2}";
            }
        }

    }
}
