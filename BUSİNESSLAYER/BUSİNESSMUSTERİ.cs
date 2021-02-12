using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using FACADELAYER;

namespace BUSİNESSLAYER
{
   public  class BUSİNESSMUSTERİ
    {
        public static int Ekle(ENTİTYMUSTERİ deger)
        {
            if (deger.Tc_no!= null && deger.Isim != null && deger.Soyisim != null && deger.Cinsiyet != null && deger.Yasadigi_il != null && deger.Adress != null && deger.Sifre != null  )
            {
                return FACADEMUSTERİEKLE.EKLE(deger);
            }

            return -1;

        }

        public static bool Guncelle(ENTİTYMUSTERİ deger)
        {
            if (deger.Tc_no != null && deger.Isim != null && deger.Soyisim != null && deger.Cinsiyet != null && deger.Yasadigi_il != null && deger.Adress != null && deger.Sifre != null)
            {
                return FACADEMUSTERİEKLE.Guncelle(deger);
            }

            return false;

        }

        public static bool SIL(int deger)
        {
            if (deger != null)
            {
                return FACADEMUSTERİEKLE.SIL(deger);
            }
            return false;
             
        }
        public static List<ENTİTYMUSTERİ> LiSTELE()
        {
            return FACADEMUSTERİEKLE.musteri_goruntule();
        }

        public static List<ENTİTYMUSTERİ> tcnolistele(int deger)
        {

            return FACADEMUSTERİEKLE.tcnolistele(deger);


        }



    }
}
