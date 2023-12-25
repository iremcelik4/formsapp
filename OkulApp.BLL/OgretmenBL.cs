using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            SqlParameter[] p =
                    {
                    new SqlParameter("@Ad",ogrt.Ad),
                    new SqlParameter("@Soyad",ogrt.Soyad),
                    new SqlParameter("@TC",ogrt.TC)
                    };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into DBogretmenler values (@Ad,@Soyad,@TC)", p) > 0;


        }
    }
}
