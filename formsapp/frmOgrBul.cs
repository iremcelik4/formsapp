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
    public partial class frmOgrBul : Form
    {
        Form1 frm;
        public frmOgrBul(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
                if (ogr != null)
                {

                    frm.txtad.Text = ogr.Ad;
                    frm.txtsoyad.Text = ogr.Soyad;
                    frm.txtnumara.Text = ogr.Numara;
                    frm.Ogrenciid = ogr.Ogrenciid;

                    frm.btnSil.Enabled = true;
                    frm.btnGuncelle.Enabled = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Öğrenci Bulunamadı!");
                    frm.btnSil.Enabled = false;
                    frm.btnGuncelle.Enabled = false;
                }

            }


            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı Hatası!" + ex.Message);

            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}
