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