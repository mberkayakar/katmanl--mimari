using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
   public class ENTİTYARABA
    {
        int sase_No;
        string marka;
        string Model;
        string kasa_tipi;
        int kapı_sayısı;
        int uretim_yili;
        string plaka;
        string renk;
        int kilometre;
        string satilikmi;
        int fiyat;
        


        public int Sase_No1 { get { return sase_No; } set{ sase_No =   value;}}

        public string Marka1 { get { return marka; } set { marka = value; }}

        public string Model1 { get { return Model; } set { Model = value; } }

        public string Kasa_tipi{ get { return kasa_tipi; } set { kasa_tipi = value; } }

        public int Kapı_sayısı { get { return kapı_sayısı;  } set { kapı_sayısı = value; } }

        public int Uretim_yili { get { return uretim_yili; } set { uretim_yili = value; } }

        public string Plaka { get { return plaka; } set { plaka = value;} }

        public string Renk { get { return renk; } set { renk = value; } }

        public int Kilometre { get { return kilometre; } set { kilometre = value; } }

        public string Satilikmi { get { return satilikmi; } set { satilikmi = value; } }

        public int Fiyat {  get { return fiyat; } set { fiyat = value;} }
    }
}
