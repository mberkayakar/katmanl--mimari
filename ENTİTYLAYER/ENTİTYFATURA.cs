using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTİTYLAYER
{
    public class ENTİTYFATURA
    {
        int saseno;
        int tcno;
        int fiyat;

        public int Saseno
        {
            get
            {
                return saseno;
            }

            set
            {
                saseno = value;
            }
        }

        public int Tcno
        {
            get
            {
                return tcno;
            }

            set
            {
                tcno = value;
            }
        }

        public int Fiyat
        {
            get
            {
                return fiyat;
            }

            set
            {
                fiyat = value;
            }
        }
    }
}
