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
    public partial class Frhareket : DevExpress.XtraEditors.XtraForm
    {
        public Frhareket()
        {
            InitializeComponent();
        }
        MRTREntities db = new MRTREntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            


            if (string.IsNullOrEmpty(comboBox1.SelectedItem as string) || string.IsNullOrEmpty(txtKur.Text) || string.IsNullOrEmpty(txttutar.Text) || string.IsNullOrEmpty(lookUpEdit2.Text) || string.IsNullOrEmpty(dateEdit1.Text))
            {
                XtraMessageBox.Show("Tüm alanların dolu olduğundan emin olun", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kaydet();
            }
        }

        private void kaydet()
        {
            decimal tutar;
            DateTime tarih = DateTime.Parse(dateEdit1.DateTime.ToString("yyyy.MM.dd") + " 23:59");
            long dkodid = long.Parse(lookUpEdit2.EditValue.ToString());
            decimal kur = Decimal.Parse(txtKur.Text.Trim());

            if (comboBox1.SelectedItem.ToString() == "Giriş")
            {
                tutar = Decimal.Parse(txttutar.Text.Trim());
                db.crmpos_kasa_hareketi(dkodid, kur, tutar, txtaciklama.Text, tarih);
            }
            else if (comboBox1.SelectedItem.ToString() == "Çıkış")
            {
                tutar = Decimal.Parse(txttutar.Text.Trim()) * -1;
                db.crmpos_kasa_hareketi(dkodid, kur, tutar, txtaciklama.Text, tarih);
            }
            this.Close();
            XtraMessageBox.Show("İşlem tamamlandı", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frhareket_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = db.DOVIZ_AD.ToList();
            lookUpEdit2.Properties.DisplayMember = "AD";
            lookUpEdit2.Properties.ValueMember = "ID";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo loc;
            loc = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "Döviz Seçiniz", 100);            
            lookUpEdit2.Properties.Columns.Add(loc);
        }
    }
}
