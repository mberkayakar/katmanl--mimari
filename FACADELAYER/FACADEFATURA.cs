using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTİTYLAYER;
using System.Data.SqlClient;
using System.Data;


namespace FACADELAYER
{
   public class FACADEFATURA
    {
        public static int FaturaEKLE(ENTİTYFATURA deger)
        {
            SqlCommand komut = new SqlCommand("satısfatura", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("sase_no", deger.Saseno);
            komut.Parameters.AddWithValue("tc_no", deger.Tcno);
            komut.Parameters.AddWithValue("fiyat", deger.Fiyat);
             
            return komut.ExecuteNonQuery();
        }



    }
}
