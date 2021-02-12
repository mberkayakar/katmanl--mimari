using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using FACADELAYER;

namespace BUSİNESSLAYER
{
    public class BUSİNESSFATURA
    {
        public static int FaturaEkle(ENTİTYFATURA deger)
        {
            if (deger.Saseno != null && deger.Tcno!= null && deger.Fiyat!= null )
            {
                return FACADEFATURA.FaturaEKLE(deger);
            }

            return -1;

        }

    }
}
