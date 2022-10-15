using CrmPosKurİşlem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => this.WindowState = FormWindowState.Minimized;


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => Application.Exit();

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrFiskurdegis frmkurdegistir = new FrFiskurdegis();
            frmkurdegistir.MdiParent = this;
            frmkurdegistir.Show();
        }

        private void FrMain_Load(object sender, EventArgs e)
        {
            Program.owner = this;
            FrKurlar frkurlr = new FrKurlar();
           // frkurlr.source();
           // frkurlr.save();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FisTLkur frmfisTLkur = new FisTLkur();
            frmfisTLkur.MdiParent = this;
            frmfisTLkur.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frfifodetaystk frmfifostkdty = new Frfifodetaystk();
            frmfifostkdty.MdiParent = this;
            frmfifostkdty.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => this.WindowState = FormWindowState.Maximized;

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrKurlar frmkur = new FrKurlar();
            frmkur.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frfifoenvanter frenv = new Frfifoenvanter();
            frenv.MdiParent = this;
            frenv.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrKasaguntoplam frkasa = new FrKasaguntoplam();
            frkasa.MdiParent = this;
            frkasa.Show();
        }
    }
}
