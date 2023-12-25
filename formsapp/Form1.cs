using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //bool OgrenciEkle( Ogrenci ogr)
        //{
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();

                bool sonuc =obl.OgrenciEkle(new Ogrenci
                {
                    Ad = txtad.Text.Trim(),
                    Soyad = txtsoyad.Text.Trim(),
                    Numara = txtnumara.Text.Trim()
                });
            }
            catch (SqlException ex)
            {

                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("bu numaralı öğrenci daha once kayıtlı");
                        break;

                    default:
                        MessageBox.Show("veri tabanı hatası");

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("bilinmeyen");
            }
        }


    }

    interface ITransfer
    {
        int Eft(string gondericiiban, string aliciiban, double tutar);
        int Havale(string gondericiiban, string aliciiban, double tutar);   
    }
    class Transfer : ITransfer
    {
        public int Eft(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }

        public int Havale(string gondericiiban, string aliciiban, double tutar)
        {
            throw new NotImplementedException();
        }
    }
}
// Garbage Collector