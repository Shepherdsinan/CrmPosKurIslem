namespace CrmPosKurİşlem
{
    partial class FrKasaguntoplam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrKasaguntoplam));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAREKET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR_DOVIZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOVIZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAKIYE_DOVIZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTL_DEGER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTL_DEGER_FARKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAREKET_KURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR_BUGUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR_FARKI_DOVIZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKF_BAKIYE_DOVIZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOKASYON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKASADAKI_TL_DEGER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKF_TL_BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGIRLIKLI_ORT_KUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KUR_FARKI_TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = typeof(CrmPosKurİşlem.FrKasaguntoplam.ResultForkasa);
            this.gridControl1.Location = new System.Drawing.Point(0, 49);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1208, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exceleAktarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 26);
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.Image = global::CrmPosKurİşlem.Properties.Resources.table_excel;
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exceleAktarToolStripMenuItem.Text = "Excel\'e Aktar";
            this.exceleAktarToolStripMenuItem.Click += new System.EventHandler(this.exceleAktarToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTARIH,
            this.colHAREKET,
            this.colTUTAR_DOVIZ,
            this.colDOVIZ,
            this.colBAKIYE_DOVIZ,
            this.colTL_DEGER,
            this.colTL_DEGER_FARKI,
            this.colHAREKET_KURU,
            this.colKUR_BUGUN,
            this.colKUR_FARKI_DOVIZ,
            this.colKF_BAKIYE_DOVIZ,
            this.colACIKLAMA,
            this.colLOKASYON,
            this.colKASADAKI_TL_DEGER,
            this.colKF_TL_BAKIYE,
            this.colAGIRLIKLI_ORT_KUR,
            this.KUR_FARKI_TL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTARIH
            // 
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 0;
            // 
            // colHAREKET
            // 
            this.colHAREKET.FieldName = "HAREKET";
            this.colHAREKET.Name = "colHAREKET";
            this.colHAREKET.Visible = true;
            this.colHAREKET.VisibleIndex = 1;
            // 
            // colTUTAR_DOVIZ
            // 
            this.colTUTAR_DOVIZ.Caption = "TUTAR_DOVIZ";
            this.colTUTAR_DOVIZ.FieldName = "TUTAR_DOVIZ";
            this.colTUTAR_DOVIZ.Name = "colTUTAR_DOVIZ";
            this.colTUTAR_DOVIZ.Visible = true;
            this.colTUTAR_DOVIZ.VisibleIndex = 2;
            // 
            // colDOVIZ
            // 
            this.colDOVIZ.FieldName = "DOVIZ";
            this.colDOVIZ.Name = "colDOVIZ";
            this.colDOVIZ.Visible = true;
            this.colDOVIZ.VisibleIndex = 3;
            // 
            // colBAKIYE_DOVIZ
            // 
            this.colBAKIYE_DOVIZ.Caption = "BAKIYE_DOVIZ";
            this.colBAKIYE_DOVIZ.FieldName = "BAKIYE_DOVIZ";
            this.colBAKIYE_DOVIZ.Name = "colBAKIYE_DOVIZ";
            this.colBAKIYE_DOVIZ.Visible = true;
            this.colBAKIYE_DOVIZ.VisibleIndex = 4;
            // 
            // colTL_DEGER
            // 
            this.colTL_DEGER.FieldName = "TL_DEGER";
            this.colTL_DEGER.Name = "colTL_DEGER";
            this.colTL_DEGER.Visible = true;
            this.colTL_DEGER.VisibleIndex = 5;
            // 
            // colTL_DEGER_FARKI
            // 
            this.colTL_DEGER_FARKI.FieldName = "TL_DEGER_FARKI";
            this.colTL_DEGER_FARKI.Name = "colTL_DEGER_FARKI";
            this.colTL_DEGER_FARKI.Visible = true;
            this.colTL_DEGER_FARKI.VisibleIndex = 6;
            // 
            // colHAREKET_KURU
            // 
            this.colHAREKET_KURU.FieldName = "HAREKET_KURU";
            this.colHAREKET_KURU.Name = "colHAREKET_KURU";
            this.colHAREKET_KURU.Visible = true;
            this.colHAREKET_KURU.VisibleIndex = 7;
            // 
            // colKUR_BUGUN
            // 
            this.colKUR_BUGUN.FieldName = "KUR_BUGUN";
            this.colKUR_BUGUN.Name = "colKUR_BUGUN";
            this.colKUR_BUGUN.Visible = true;
            this.colKUR_BUGUN.VisibleIndex = 8;
            // 
            // colKUR_FARKI_DOVIZ
            // 
            this.colKUR_FARKI_DOVIZ.FieldName = "KUR_FARKI_DOVIZ";
            this.colKUR_FARKI_DOVIZ.Name = "colKUR_FARKI_DOVIZ";
            this.colKUR_FARKI_DOVIZ.Visible = true;
            this.colKUR_FARKI_DOVIZ.VisibleIndex = 9;
            // 
            // colKF_BAKIYE_DOVIZ
            // 
            this.colKF_BAKIYE_DOVIZ.Caption = "KF_BAKIYE_DOVIZ";
            this.colKF_BAKIYE_DOVIZ.FieldName = "KF_BAKIYE_DOVIZ";
            this.colKF_BAKIYE_DOVIZ.Name = "colKF_BAKIYE_DOVIZ";
            this.colKF_BAKIYE_DOVIZ.Visible = true;
            this.colKF_BAKIYE_DOVIZ.VisibleIndex = 10;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 11;
            // 
            // colLOKASYON
            // 
            this.colLOKASYON.FieldName = "LOKASYON";
            this.colLOKASYON.Name = "colLOKASYON";
            this.colLOKASYON.Visible = true;
            this.colLOKASYON.VisibleIndex = 12;
            // 
            // colKASADAKI_TL_DEGER
            // 
            this.colKASADAKI_TL_DEGER.FieldName = "KASADAKI_TL_DEGER";
            this.colKASADAKI_TL_DEGER.Name = "colKASADAKI_TL_DEGER";
            this.colKASADAKI_TL_DEGER.Visible = true;
            this.colKASADAKI_TL_DEGER.VisibleIndex = 13;
            // 
            // colKF_TL_BAKIYE
            // 
            this.colKF_TL_BAKIYE.FieldName = "KF_TL_BAKIYE";
            this.colKF_TL_BAKIYE.Name = "colKF_TL_BAKIYE";
            this.colKF_TL_BAKIYE.Visible = true;
            this.colKF_TL_BAKIYE.VisibleIndex = 14;
            // 
            // colAGIRLIKLI_ORT_KUR
            // 
            this.colAGIRLIKLI_ORT_KUR.FieldName = "AGIRLIKLI_ORT_KUR";
            this.colAGIRLIKLI_ORT_KUR.Name = "colAGIRLIKLI_ORT_KUR";
            this.colAGIRLIKLI_ORT_KUR.Visible = true;
            this.colAGIRLIKLI_ORT_KUR.VisibleIndex = 15;
            // 
            // KUR_FARKI_TL
            // 
            this.KUR_FARKI_TL.Caption = "KUR_FARKI_TL";
            this.KUR_FARKI_TL.FieldName = "KUR_FARKI_TL";
            this.KUR_FARKI_TL.Name = "KUR_FARKI_TL";
            this.KUR_FARKI_TL.Visible = true;
            this.KUR_FARKI_TL.VisibleIndex = 16;
            // 
            // BtnListele
            // 
            this.BtnListele.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.BtnListele.Appearance.Options.UseBackColor = true;
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(519, 10);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(106, 31);
            this.BtnListele.TabIndex = 8;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lokasyon";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "";
            this.lookUpEdit1.Location = new System.Drawing.Point(82, 14);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "[EditValue is null]";
            this.lookUpEdit1.Size = new System.Drawing.Size(155, 24);
            this.lookUpEdit1.TabIndex = 10;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.EditValue = "<Seçiniz>";
            this.lookUpEdit2.Location = new System.Drawing.Point(311, 13);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Size = new System.Drawing.Size(173, 24);
            this.lookUpEdit2.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(249, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "DövizTürü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(697, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 31);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Hareket Girişi";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrKasaguntoplam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 492);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lookUpEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrKasaguntoplam";
            this.Text = "Günlük Kasa Toplamları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrKasaguntoplam_FormClosing);
            this.Load += new System.EventHandler(this.FrKasaguntoplam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colHAREKET;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR_DOVIZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDOVIZ;
        private DevExpress.XtraGrid.Columns.GridColumn colBAKIYE_DOVIZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTL_DEGER;
        private DevExpress.XtraGrid.Columns.GridColumn colTL_DEGER_FARKI;
        private DevExpress.XtraGrid.Columns.GridColumn colHAREKET_KURU;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR_BUGUN;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR_FARKI_DOVIZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKF_BAKIYE_DOVIZ;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colLOKASYON;
        private DevExpress.XtraGrid.Columns.GridColumn colKASADAKI_TL_DEGER;
        private DevExpress.XtraGrid.Columns.GridColumn colKF_TL_BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn colAGIRLIKLI_ORT_KUR;
        private DevExpress.XtraGrid.Columns.GridColumn KUR_FARKI_TL;
    }
}