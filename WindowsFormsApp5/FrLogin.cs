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

namespace WindowsFormsApp5
{
    public partial class FrLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit2.Text == "3320")
            {
                this.Hide();
                FrMain anaform = new FrMain();
                anaform.Show();
            }
            else
            {
                XtraMessageBox.Show("Geçersiz Şifre veya Kullanıcı Adı", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textEdit2.Text == "3320")
                {
                    this.Hide();
                    FrMain anaform = new FrMain();
                    anaform.Show();
                }
                else
                {
                    XtraMessageBox.Show("Geçersiz Şifre veya Kullanıcı Adı", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            
        }
    }
}
