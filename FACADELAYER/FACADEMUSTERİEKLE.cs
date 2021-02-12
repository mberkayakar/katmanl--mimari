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
   public class FACADEMUSTERİEKLE
    {
        public static int EKLE( ENTİTYMUSTERİ deger )
        {
            SqlCommand komut = new SqlCommand("musteri_ekle", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("tc_no", deger.Tc_no);
            komut.Parameters.AddWithValue("isim", deger.Isim);
            komut.Parameters.AddWithValue("soyisim", deger.Soyisim);
            komut.Parameters.AddWithValue("cinsiyet", deger.Cinsiyet);
            komut.Parameters.AddWithValue("yasadigi_il", deger.Yasadigi_il);
            komut.Parameters.AddWithValue("adress", deger.Adress);
            komut.Parameters.AddWithValue("sifre", deger.Sifre);
         
            return komut.ExecuteNonQuery();
        }

        public static bool Guncelle(ENTİTYMUSTERİ deger)
        {
            SqlCommand komut = new SqlCommand("MusteriGuncelle", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("tc_no", deger.Tc_no);
            komut.Parameters.AddWithValue("isim", deger.Isim);
            komut.Parameters.AddWithValue("soyisim", deger.Soyisim);
            komut.Parameters.AddWithValue("cinsiyet", deger.Cinsiyet);
            komut.Parameters.AddWithValue("yasadigi_il", deger.Yasadigi_il);
            komut.Parameters.AddWithValue("adress", deger.Adress);
            komut.Parameters.AddWithValue("sifre", deger.Sifre);

            return komut.ExecuteNonQuery()>0;
        }
      
        public static bool SIL(int deger)
        {
            SqlCommand komut = new SqlCommand("musteri_sil", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("tc_no", deger);
            return komut.ExecuteNonQuery() > 0;

        }

        public static List<ENTİTYMUSTERİ> musteri_goruntule()
        {
            List<ENTİTYMUSTERİ> tablodakidegerler = new List<ENTİTYMUSTERİ>();
            SqlCommand komut = new SqlCommand("musterigor", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTİTYMUSTERİ musteri = new ENTİTYMUSTERİ();
                musteri.Tc_no = Convert.ToInt32(dr["tc_no"]);
                musteri.Isim = dr["isim"].ToString();
                musteri.Soyisim= dr["soyisim"].ToString();
                musteri.Cinsiyet= dr["cinsiyet"].ToString();
                musteri.Yasadigi_il= dr["yasadigi_il"].ToString();
                musteri.Adress= dr["adress"].ToString();
                musteri.Sifre = Convert.ToInt32( dr["sifre"]) ;
                
                tablodakidegerler.Add(musteri);



            }
            dr.Close();
            return tablodakidegerler;

        }




        public static List<ENTİTYMUSTERİ> tcnolistele(int deger)
        {
            List<ENTİTYMUSTERİ> tablodakidegerler = new List<ENTİTYMUSTERİ>();
            SqlCommand komut = new SqlCommand("select * from musteri where tc_no="+deger, SQLBAGLANTİSİ.Baglanti);
             

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTİTYMUSTERİ musteri = new ENTİTYMUSTERİ();
 
                musteri.Isim = dr["isim"].ToString();
                musteri.Soyisim = dr["soyisim"].ToString();
                musteri.Cinsiyet = dr["cinsiyet"].ToString();
                musteri.Yasadigi_il = dr["yasadigi_il"].ToString();
                musteri.Adress = dr["adress"].ToString();
                musteri.Sifre = Convert.ToInt32(dr["sifre"]);

                tablodakidegerler.Add(musteri);



            }
            dr.Close();
            return tablodakidegerler;
 

        }

        public static List<ENTİTYMUSTERİ> sifregiris(int tc,int sifre)
        {
            List<ENTİTYMUSTERİ> tablodakidegerler = new List<ENTİTYMUSTERİ>();
            SqlCommand komut = new SqlCommand("select * from musteri where tc_no=" + tc + "and sifre"+ sifre, SQLBAGLANTİSİ.Baglanti);


            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTİTYMUSTERİ musteri = new ENTİTYMUSTERİ();

                musteri.Tc_no = Convert.ToInt32( dr["tc_no"]);
                musteri.Sifre = Convert.ToInt32( dr["sifre"]);

                tablodakidegerler.Add(musteri);



            }
            dr.Close();
            return tablodakidegerler;


        }




    }
}


 