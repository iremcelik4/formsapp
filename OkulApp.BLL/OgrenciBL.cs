﻿
using model;
using System;
using formsapp;
using System.Data.SqlClient;
using DAL;


namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        Helper hlp = Helper.Instance;

        private static OgrenciBL _instance;
        private OgrenciBL()
        {

        }
        public static OgrenciBL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OgrenciBL();
                }
                return _instance;
            }
        }
        public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlParameter[] p =
                    {
                    new SqlParameter("@Ad",ogr.Ad),
                    new SqlParameter("@Soyad",ogr.Soyad),
                    new SqlParameter("@Numara",ogr.Numara)
                    };

            Helper hlp= new Helper();
             return hlp.ExecuteNonQuery("Insert into DBogrenciler values (@Ad,@Soyad,@Numara)",p) >0;


        }





        public Ogrenci OgrenciBul(string numara)
        {
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            Helper hlp = new Helper();
            var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tblOgrenciler where Numara=@Numara", p);
            Ogrenci ogr = null;
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Numara = dr["Numara"].ToString();
            }
            dr.Close();
            return ogr;
        }

        public bool OgrenciSil(int id)
        {
            SqlParameter[] p = { new SqlParameter("@OgrenciId", id) };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Delete from tblOgrenciler where OgrenciId=@OgrenciId", p) > 0;
        }


        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara),
                             new SqlParameter("@Ogrenciid",ogr.Ogrenciid)
                         };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@Ogrenciid", p) > 0;
        }





        //    SqlConnection cn = null;
        //    SqlCommand cmd = null;
        //    try
        //    {
        //        using (cn = new SqlConnection(@"Data Source=.;Initial Catalog=Okuldb;Integrated Security=true"))

        //        using (cmd = new SqlCommand($"Insert into DBogrenciler values (@Ad,@Soyad,@Numara)", cn))
        //        {

        //            SqlParameter[] p =
        //            {
        //            new SqlParameter("@Ad",ogr.Ad),
        //            new SqlParameter("@Soyad",ogr.Soyad),
        //            new SqlParameter("@Numara",ogr.Numara)
        //            };
        //            cmd.Parameters.AddRange(p);

        //            cn.Open();
        //            int sonuc = cmd.ExecuteNonQuery();

        //            return sonuc > 0;
        //        }
        //    }
        //    catch (SqlException ex)
        //    {

        //        throw ex;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    //finally
        //    //{
        //    //    if (cn != null && cn.State != ConnectionState.Closed)
        //    //    {
        //    //        cn.Close();
        //    //        cn.Dispose();
        //    //        cmd.Dispose();
        //    //    }

        //    //}
        //}


    }
    }
// n katmanlı mimari yapısı