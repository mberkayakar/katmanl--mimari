using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
   public class ENTİTYMUSTERİ
    {
        int tc_no;
        string isim;
        string soyisim;
        string cinsiyet;
        string yasadigi_il;
        string adress;
        int sifre;
        public int Tc_no { get { return tc_no; } set { tc_no = value; } }

        public string Isim  { get { return isim; }

            set
            {
                isim = value;
            }
        }

        public string Soyisim
        {
            get
            {
                return soyisim;
            }

            set
            {
                soyisim = value;
            }
        }

        public string Cinsiyet
        {
            get
            {
                return cinsiyet;
            }

            set
            {
                cinsiyet = value;
            }
        }

        public string Yasadigi_il
        {
            get
            {
                return yasadigi_il;
            }

            set
            {
                yasadigi_il = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public int Sifre
        {
            get
            {
                return sifre;
            }

            set
            {
                sifre = value;
            }
        }
    }
}
