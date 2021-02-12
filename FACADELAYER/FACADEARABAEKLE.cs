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
    public class FACADEARABAEKLE
    {



        public static int EKLE(ENTİTYARABA deger)
        {
            SqlCommand komut = new SqlCommand("araba_Ekle", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("sase_no", deger.Sase_No1);
            komut.Parameters.AddWithValue("marka", deger.Marka1);
            komut.Parameters.AddWithValue("model", deger.Model1);
            komut.Parameters.AddWithValue("kasa_tipi", deger.Kasa_tipi);
            komut.Parameters.AddWithValue("kapı_sayısı", deger.Kapı_sayısı);
            komut.Parameters.AddWithValue("uretim_yili", deger.Uretim_yili);
            komut.Parameters.AddWithValue("plaka", deger.Plaka);
            komut.Parameters.AddWithValue("kilometre", deger.Kilometre);
            komut.Parameters.AddWithValue("satilikmi", deger.Satilikmi);
            komut.Parameters.AddWithValue("fiyat", deger.Fiyat);
            return komut.ExecuteNonQuery();
        }

        public static bool SIL(int deger)
        {
            SqlCommand komut = new SqlCommand("arabasil", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("sase_no", deger);
            return komut.ExecuteNonQuery() > 0;

        }

        public static List<ENTİTYARABA> araba_goruntule()
        {
            List<ENTİTYARABA> tablodakidegerler = new List<ENTİTYARABA>();
            SqlCommand komut = new SqlCommand("satilik_aracları_gor", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTİTYARABA araba = new ENTİTYARABA();
                araba.Sase_No1 = Convert.ToInt32(dr["sase_no"]);
                araba.Marka1 = dr["marka"].ToString();
                araba.Model1 = dr["model"].ToString();
                araba.Kasa_tipi = dr["kasa_tipi"].ToString();
                araba.Kapı_sayısı = Convert.ToInt16(dr["kapı_sayısı"]);
                araba.Uretim_yili = Convert.ToInt16(dr["uretim_yili"]);
                araba.Plaka = dr["plaka"].ToString();
                araba.Kilometre = Convert.ToInt32(dr["kilometre"]);
                araba.Satilikmi = dr["satilikmi"].ToString();
                araba.Fiyat = Convert.ToInt32(dr["fiyat"]);

                tablodakidegerler.Add(araba);



            }
            dr.Close();
            return tablodakidegerler;
        }
        
        public static bool Araba_Guncelle(ENTİTYARABA deger)
        {
            SqlCommand komut = new SqlCommand("ArabaGuncelle", SQLBAGLANTİSİ.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("sase_no", deger.Sase_No1);
            komut.Parameters.AddWithValue("marka", deger.Marka1);
            komut.Parameters.AddWithValue("model", deger.Model1);
            komut.Parameters.AddWithValue("kasa_tipi", deger.Kasa_tipi);
            komut.Parameters.AddWithValue("kapı_sayısı", deger.Kapı_sayısı);
            komut.Parameters.AddWithValue("uretim_yili", deger.Uretim_yili);
            komut.Parameters.AddWithValue("plaka", deger.Plaka);
            komut.Parameters.AddWithValue("kilometre", deger.Kilometre);
            komut.Parameters.AddWithValue("satilikmi", deger.Satilikmi);
            komut.Parameters.AddWithValue("fiyat", deger.Fiyat);
            return komut.ExecuteNonQuery() > 0;

        }

        public static List<ENTİTYARABA> sase_ile_goruntule(int deger)
        {
            List<ENTİTYARABA> tablodakidegerler = new List<ENTİTYARABA>();
            SqlCommand komut = new SqlCommand("  select * from araba_tablo where sase_no="+deger, SQLBAGLANTİSİ.Baglanti);
            komut.Parameters.AddWithValue("sase_no", deger);

 

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTİTYARABA araba = new ENTİTYARABA();
 
                araba.Marka1 = dr["marka"].ToString();
                araba.Model1 = dr["model"].ToString();
                araba.Kasa_tipi = dr["kasa_tipi"].ToString();
                araba.Kapı_sayısı = Convert.ToInt16(dr["kapı_sayısı"]);
                araba.Uretim_yili = Convert.ToInt16(dr["uretim_yili"]);
                araba.Plaka = dr["plaka"].ToString();
                araba.Kilometre = Convert.ToInt32(dr["kilometre"]);
                araba.Satilikmi = dr["satilikmi"].ToString();
                araba.Fiyat = Convert.ToInt32(dr["fiyat"]);

                tablodakidegerler.Add(araba);



            }
            dr.Close();
            return tablodakidegerler;


        }
    }
}