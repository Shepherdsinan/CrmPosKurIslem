using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CrmPosKurİşlem
{
    public partial class FrKurlar : DevExpress.XtraEditors.XtraForm
    {
        public FrKurlar()
        {
            InitializeComponent();
        }
        MRTREntities db = new MRTREntities();
        private void FrKurlar_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
            gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = db.TCMB_KUR_CRMPOS.ToList();
        }
        
        DataTable dt = new DataTable();
        // DataTable nesnemizi yaratıyoruz
        DataRow dr;
        public DateTime ActualCurrencyDate { get; set; }
        string url;
        XmlTextReader rdr;
        XmlDocument XmlDoc;
        
        private void GenerateApiUrl()
        {
            url = string.Empty;

            var datesys = DateTime.Parse(DateTime.Now.ToString("yyyy.MM.dd"));
            if (ActualCurrencyDate == datesys)
            {
                url = "http://www.tcmb.gov.tr/kurlar/today.xml";
            }
            else
            {
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}/{1}.xml", ActualCurrencyDate.ToString("yyyyMM"), ActualCurrencyDate.ToString("ddMMyyyy"));
            }
            rdr = new XmlTextReader(url);
        }
        public DataTable source()
        {

            


            dt.Rows.Clear();
            try
            {
                
                


                // XmlTextReader nesnesini yaratıyoruz ve parametre olarak xml dokümanın urlsini veriyoruz
                // XmlTextReader urlsi belirtilen xml dokümanlarına hızlı ve forward-only giriş imkanı sağlar.
                 
                // XmlDocument nesnesini yaratıyoruz.

                for (int attempts = 0; attempts <= 5; attempts++)
                {
                    try
                    {
                        GenerateApiUrl();
                        XmlDoc = new XmlDocument();
                        XmlDoc.Load(rdr);

                        break;
                    }
                    catch (WebException ex)
                    {
                        if (ex.Response != null)
                        {
                            // 404 not found
                            HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
                            if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                            {
                                // bir gün öncesi kontrol edilir
                                ActualCurrencyDate = ActualCurrencyDate.AddDays(-1);
                            }
                            else
                            {
                                throw new Exception("Kur bilgisi bulunamadı.");
                            }
                        }
                        else
                        {
                            throw new Exception("Kur bilgisi bulunamadı.");
                        }
                    }
                }                

                // Load metodu ile xml yüklüyoruz
                XmlNode tarih = XmlDoc.SelectSingleNode("/Tarih_Date/@Tarih");
                XmlNodeList mylist = XmlDoc.SelectNodes("/Tarih_Date/Currency");
                XmlNodeList adi = XmlDoc.SelectNodes("/Tarih_Date/Currency/Isim");
                XmlNodeList kod = XmlDoc.SelectNodes("/Tarih_Date/Currency/@Kod");
                XmlNodeList doviz_alis = XmlDoc.SelectNodes("/Tarih_Date/Currency/ForexBuying");
                XmlNodeList doviz_satis = XmlDoc.SelectNodes("/Tarih_Date/Currency/ForexSelling");
                XmlNodeList efektif_alis = XmlDoc.SelectNodes("/Tarih_Date/Currency/BanknoteBuying");
                XmlNodeList efektif_satis = XmlDoc.SelectNodes("/Tarih_Date/Currency/BanknoteSelling");

                // XmlNodeList cinsinden her bir nodu, SelectSingleNode metoduna nodların xpathini parametre olarak
                // göndererek tanımlıyoruz.
                //gridControl1. = tarih.InnerText.ToString() + " tarihli merkez bankası kur bilgileri";
                // datagridimin captionu ayarlıyoruz.
                int x = 17;
                /*  Burada xmlde bahsettiğim - bence-  mantık hatasından dolayı x gibi bir değişken tanımladım.
                bu x =19  DataTable a sadece 19 satır eklenmesini sağlıyor. çünkü xml dökümanında 19. node dan sonra
                güncel kur bilgileri değil Euro dönüşüm kurları var ve bu node dan sonra yapı ilk 18 node ile tutmuyor
                Bence ayrı bir xml dökümanda tutulması gerekirdi.
                */
                for (int i = 0; i < x; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = (i + 1);
                    dr[1] = dateEdit1.DateTime.Date; //.ToString("dd.MM.yyyy");
                    //dr[1] = adi.Item(i).InnerText.ToString(); // i. adi nodunun içeriği
                    // Adı isimli DataColumn un satırlarını  /Tarih_Date/Currency/Isim node ları ile dolduruyoruz.
                    dr[2] = kod.Item(i).InnerText.ToString();
                    // Kod satırları
                    dr[3] = decimal.Parse(doviz_alis.Item(i).InnerText,CultureInfo.InvariantCulture);
                    // Döviz Alış
                    dr[4] = decimal.Parse(doviz_satis.Item(i).InnerText, CultureInfo.InvariantCulture);
                    // Döviz  Satış
                    //dr[5] = efektif_alis.Item(i).InnerText.ToString();
                    //// Efektif Alış
                    //dr[6] = efektif_satis.Item(i).InnerText.ToString();
                    // Efektif Satış.
                    dt.Rows.Add(dr);
                }
            }
            catch (Exception expc)
            {
                XtraMessageBox.Show(expc.ToString(), "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // DataTableımıza 6 sütün ekliyoruz ve değişken tiplerini tanımlıyoruz.
           
            
            // DataTable ımızın satırlarını 18 satır olacak şekilde dolduruyoruz
            // gerçi yine web mastırın insafı devreye giriyor:).
            // yukarıda bahsettiğim sorun.
            return dt;
            // DataTable ı döndürüyoruz.
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {         
            gridControl1.DataSource = source();
        }
        int dvzid;

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ActualCurrencyDate = dateEdit1.DateTime.Date;
            var tatarih = dateEdit1.DateTime.Date;
            int count = db.TCMB_KUR_CRMPOS.Count(a => a.TARIH == tatarih);
            if (count>0)
            {
                listele();
            }
            else
            {
                
                dt.Rows.Clear();
                dt.Columns.Clear();
                // DataTable ın satırlarını tanımlıyoruz.
                dt.Columns.Add(new DataColumn("Sıra", typeof(int)));
                dt.Columns.Add(new DataColumn("Tarih", typeof(DateTime)));
                dt.Columns.Add(new DataColumn("Kod", typeof(string)));
                dt.Columns.Add(new DataColumn("Döviz_alış", typeof(decimal)));
                dt.Columns.Add(new DataColumn("Döviz_satış", typeof(decimal)));
                //dt.Columns.Add(new DataColumn("Efektif alış", typeof(string)));
                //dt.Columns.Add(new DataColumn("Efektif Satış", typeof(string)));
                int x = 17;
                for (int i = 0; i < x; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = (i + 1);
                    dr[1] = dateEdit1.DateTime.Date;//.ToString("dd.MM.yyyy");
                    dt.Rows.Add(dr);
                }
                gridControl1.DataSource = dt;
            }
            
        }
        private void listele()
        {
            var tatarih = dateEdit1.DateTime.Date;

            var value = (from u in db.DOVIZ_AD
                         join k in db.TCMB_KUR_CRMPOS on u.ID equals k.DOVIZ_AD
                         where k.TARIH == tatarih
                         orderby (k.SIRA)
                         select new 
                         {
                             Sıra = k.SIRA,
                             Tarih = k.TARIH ,
                             Kod=u.AD,
                             Döviz_alış = k.ALIS,
                             Döviz_satış = k.SATIS
                         }).ToList();
            
            
            gridControl1.DataSource = value;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en-US", true);            

            // en-US kültüründe ondalık ayracı zaten "." olduğu için değerlendirmeye gerek yok.          

            
            for (int i = 0; i < source().Rows.Count; i++)
            {
                DataRow dr = source().Rows[i];
                switch (dr["Kod"].ToString())
                {
                    case "USD":
                        dvzid = 2;
                        break;
                    case "EUR":
                        dvzid = 3;
                        break;
                    case "AUD":
                        dvzid = 4;
                        break;
                    case "DKK":
                        dvzid = 5;
                        break;
                    case "GBP":
                        dvzid = 6;
                        break;
                    case "CHF":
                        dvzid = 7;
                        break;
                    case "SEK":
                        dvzid = 8;
                        break;
                    case "CAD":
                        dvzid = 9;
                        break;
                    case "KWD":
                        dvzid = 10;
                        break;
                    case "NOK":
                        dvzid = 11;
                        break;
                    case "SAR":
                        dvzid = 12;
                        break;
                    case "JPY":
                        dvzid = 13;
                        break;
                    case "BGN":
                        dvzid = 14;
                        break;
                    case "RUB":
                        dvzid = 15;
                        break;
                    case "IRR":
                        dvzid = 16;
                        break;
                    case "CNY":
                        dvzid = 17;
                        break;
                    case "RON":
                        dvzid = 18;
                        break;
                    default:
                        dvzid = 0;
                        break;
                }               

                
                var dcalis = dr.Field<decimal>("Döviz_alış");
                var dcsatis = dr.Field<decimal>("Döviz_satış");
                var tatarih = dateEdit1.DateTime.Date;
                int count = db.TCMB_KUR_CRMPOS.Count(a => a.TARIH == tatarih);

                if (count > 0)
                {
                    var x = db.TCMB_KUR_CRMPOS.Where(a => a.DOVIZ_AD == dvzid && a.TARIH == tatarih).First();
                    x.TARIH = dr.Field<DateTime>("Tarih");
                    x.ALIS = dcalis;
                    x.SATIS = dcsatis;
                    x.DOVIZ_AD = dvzid;
                    x.SIRA = dr.Field<int>("Sıra");
                }
                else
                {
                    db.TCMB_KUR_CRMPOS.Add(new TCMB_KUR_CRMPOS()
                    { //add data to class objects variable
                        TARIH = dr.Field<DateTime>("Tarih"),
                        ALIS = dcalis,
                        SATIS = dcsatis,
                        DOVIZ_AD = dvzid,
                        SIRA = dr.Field<int>("Sıra")
                    });
                }
            }
            db.SaveChanges();
            XtraMessageBox.Show("İşlem tamamlandı", "İnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
