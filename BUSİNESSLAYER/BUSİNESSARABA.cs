
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using FACADELAYER;

namespace BUSİNESSLAYER
{
    public class BUSİNESSARABA
    {


        public static int Ekle(ENTİTYARABA deger) 
        {
            if (deger.Sase_No1!=null && deger.Marka1 != null && deger.Model1 != null &&deger.Kasa_tipi != null &&deger.Kapı_sayısı != null &&deger.Uretim_yili != null &&deger.Plaka != null &&deger.Kilometre != null &&deger.Satilikmi != null && deger.Fiyat != null )
            {
                return FACADEARABAEKLE.EKLE(deger);
            }

            return -1;
             
        }

        public static bool SIL(int deger)
        {
            if (deger!=null)
            {
                return FACADEARABAEKLE.SIL(deger);
            }
            return false;


        }

        public static List<ENTİTYARABA> LiSTELE()
        {
            return FACADEARABAEKLE.araba_goruntule();
        }



        public static List<ENTİTYARABA> sasenoluaraciguncelle(int  deger)
        {

            return FACADEARABAEKLE.sase_ile_goruntule(deger);
             
             
        }


        public static bool Guncelle(ENTİTYARABA deger)
        {
            if (deger.Sase_No1 != null && deger.Marka1 != null && deger.Model1 != null && deger.Kasa_tipi != null && deger.Kapı_sayısı != null && deger.Uretim_yili != null && deger.Plaka != null && deger.Kilometre != null && deger.Satilikmi != null && deger.Fiyat != null)
            {
                return FACADEARABAEKLE.Araba_Guncelle(deger);
            }
            return false;
        }

        
       
 
    }


}
