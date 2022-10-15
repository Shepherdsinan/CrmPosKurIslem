using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmPosKurİşlem
{
    public partial class FrChange : DevExpress.XtraEditors.XtraForm
    {
        public FrChange()
        {
            InitializeComponent();
        }
        MRTREntities db = new MRTREntities();
        
        private void btnnakit_Click(object sender, EventArgs e)
        {
            var praustu = txtparaustu.Text;
            decimal cntrolprustu = decimal.Parse(praustu); 

            if (cmbdoviz.Text == "TRY")
            {
                db.crmpos_odeme_guncelle(1, id, tgirodeme, 1);
                db.crmpos_paraustu_guncelle(fis_id, 0);
            }
            else if (cmbdoviz.Text == "USD")
            {
                db.crmpos_odeme_guncelle(1, id, tgirodeme, 2);
                db.crmpos_paraustu_guncelle(fis_id, cntrolprustu);
            }
            else if (cmbdoviz.Text == "EUR")
            {
                db.crmpos_odeme_guncelle(1, id, tgirodeme, 3);
                db.crmpos_paraustu_guncelle(fis_id, cntrolprustu);

            }
            this.Close();
        }

        private void btnkredi_Click(object sender, EventArgs e)
        {
            db.crmpos_odeme_guncelle(15, id, tgirodeme, 1);
            db.crmpos_paraustu_guncelle(fis_id, 0);
            this.Close();
        }

        private void cmbdoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            string trhislem = islemtarihi.ToString("yyyy.MM.dd");
            if (cmbdoviz.Text == "TRY")
            {
                lbldvzcins.Text = "1";
                btnkredi.Enabled = true;
                lblpara.Text = "TRY Para";
                txtodeme.Text = txttutar.Text;
                txtparaustu.Text = (tgirodeme - tfistoptut).ToString();
            }
            else if(cmbdoviz.Text == "USD")
            {
                lbldvzcins.Text = "2";
                btnkredi.Enabled = false;
                lblpara.Text = "USD Para";
                var krdeger = db.wwwDOVIZ_KUR.Where(x => x.TARIH == trhislem && x.DOVIZ_AD == 2).Select(u => u.ALIS).SingleOrDefault();
                if (krdeger !=null)
                {
                    txtodeme.Text = Math.Round((double)(tfistoptut / krdeger), 3).ToString();
                    txtparaustu.Text = ((tgirodeme * krdeger) - tfistoptut).ToString();
                }
                else
                {
                    txtodeme.Text = Math.Round((double)(tfistoptut / 1), 3).ToString();
                    txtparaustu.Text = ((tgirodeme * 1) - tfistoptut).ToString();
                }
                 
                
            }
            else if(cmbdoviz.Text == "EUR")
            {
                lbldvzcins.Text = "3";
                btnkredi.Enabled = false;
                lblpara.Text = "EUR Para";
                var krdeger = db.wwwDOVIZ_KUR.Where(x => x.TARIH == trhislem && x.DOVIZ_AD == 3).Select(u => u.ALIS).SingleOrDefault();
                if (krdeger != null)
                {
                    txtodeme.Text = Math.Round((double)(tfistoptut / krdeger), 3).ToString();
                    txtparaustu.Text = ((tgirodeme * krdeger) - tfistoptut).ToString();
                }
                else
                {
                    txtodeme.Text = Math.Round((double)(tfistoptut / 1), 3).ToString();
                    txtparaustu.Text = ((tgirodeme * 1) - tfistoptut).ToString();
                }
                
            }
        }
        public DateTime islemtarihi { get; set; }
        public decimal kur { get; set; }
        public long fis_id { get; set; }
        public long id { get; set; }
        public string fistutar { get; set; }
        public string doviz { get; set; }
        public string nakit { get; set; }
        public string kredi { get; set; }

        private void FrChange_Load(object sender, EventArgs e)
        {
            string trhislem = islemtarihi.ToString("yyyy.MM.dd");
            lblfisid.Text = id.ToString();
            lbltutar.Text = fistutar;
            txttutar.Text = fistutar;
            cmbdoviz.Text = doviz;
            if (nakit != null)
            {
                txtodeme.Text = nakit;
            }
            else if (kredi != null)
            {
                txtodeme.Text = kredi;
            }
            var krdolar = db.wwwDOVIZ_KUR.Where(x => x.TARIH == trhislem && x.DOVIZ_AD == 2).Select(u => u.ALIS).SingleOrDefault();
            if (krdolar != null)
            {
                lbldolar.Text = "$ "+ Math.Round((double)(tfistoptut / krdolar), 3).ToString();
                txtodeme.Text = Math.Round((double)(tfistoptut / krdolar), 3).ToString();
            }
            else
            {
                lbldolar.Text = "$ "+ Math.Round((double)(tfistoptut / 1), 3).ToString();
            }
            var kreuro = db.wwwDOVIZ_KUR.Where(x => x.TARIH == trhislem && x.DOVIZ_AD == 3).Select(u => u.ALIS).SingleOrDefault();
            if (kreuro != null)
            {
                lbleuro.Text = "€ " + Math.Round((double)(tfistoptut / kreuro), 3).ToString();
                txtparaustu.Text = ((tgirodeme * kreuro) - tfistoptut).ToString();
            }
            else
            {
                lbleuro.Text = "€ " + Math.Round((double)(tfistoptut / 1), 3).ToString();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        decimal tgirodeme;
        decimal tfistoptut;
        private void txtodeme_EditValueChanged(object sender, EventArgs e)
        {
            if (txtodeme.Text != "")
            {
                try
                {

                    string trhislem = islemtarihi.ToString("yyyy.MM.dd");
                    var sayi1 = txtodeme.Text.Trim();
                    var sayi2 = txttutar.Text.Trim();
                    tgirodeme = decimal.Parse(sayi1);
                    tfistoptut = decimal.Parse(sayi2);

                    if (cmbdoviz.Text == "TRY")
                    {
                        txtparaustu.Text = (tgirodeme - tfistoptut).ToString();
                    }
                    else if (cmbdoviz.Text == "USD")
                    {
                        var krdeger = db.wwwDOVIZ_KUR.Where(x => x.TARIH == trhislem && x.DOVIZ_AD == 2).Select(u => u.ALIS).SingleOrDefault();
                        if (krdeger != null)
                        {                            
                            txtparaustu.Text = ((tgirodeme * krdeger) - tfistoptut).ToString();
                        }
                        else
                        {                            
                            txtparaustu.Text = ((tgirodeme * 1) - tfistoptut).ToString();
                        }
                    }
                    else if (cmbdoviz.Text == "EUR")
                    {
                        var krdeger = db.wwwDOVIZ_KUR.Where(x => x.TARIH == trhislem && x.DOVIZ_AD == 3).Select(u => u.ALIS).SingleOrDefault();
                        if (krdeger != null)
                        {
                            txtparaustu.Text = ((tgirodeme * krdeger) - tfistoptut).ToString();
                        }
                        else
                        {                            
                            txtparaustu.Text = ((tgirodeme * 1) - tfistoptut).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            }
            
        }

    }
}
