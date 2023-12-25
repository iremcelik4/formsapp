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
    public partial class ogretmenekle : Form
    {
        public ogretmenekle()
        {
            InitializeComponent();
        }

        private void btnokayit_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();

                bool sonuc = obl.OgretmenEkle(new Ogretmen
                {
                    Ad = txtoad.Text.Trim(),
                    Soyad = txtosoyad.Text.Trim(),
                    TC = txttc.Text.Trim()
                });
            }
            catch (SqlException ex)
            {

                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("bu tc daha once kayıtlı");
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
}
