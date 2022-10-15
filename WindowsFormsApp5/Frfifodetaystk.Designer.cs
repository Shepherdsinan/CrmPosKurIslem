namespace CrmPosKurİşlem
{
    partial class Frfifodetaystk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frfifodetaystk));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK_ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAT_FIS_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAL_FIS_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAL_TOP_MIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAT_MIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAL_TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAT_TL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAL_DVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR_BUGUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAL_TL_DEGERI_BUGUN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAT_DVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOVIZ_KAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAL_KUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAT_KUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = typeof(CrmPosKurİşlem.Frfifodetaystk.ResultForFifostokdetay);
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(-2, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1209, 456);
            this.gridControl1.TabIndex = 3;
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
            this.colKOD,
            this.colBARKOD,
            this.colSTOK_ADI,
            this.colSATId,
            this.colALId,
            this.colSAT_FIS_TARIHI,
            this.colAL_FIS_TARIHI,
            this.colAL_TOP_MIK,
            this.colSAT_MIK,
            this.colAL_TL,
            this.colSAT_TL,
            this.colAL_DVZ,
            this.colKUR_BUGUN,
            this.colAL_TL_DEGERI_BUGUN,
            this.colSAT_DVZ,
            this.colDOVIZ_KAR,
            this.colAL_KUR,
            this.colSAT_KUR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colKOD
            // 
            this.colKOD.FieldName = "KOD";
            this.colKOD.Name = "colKOD";
            this.colKOD.Visible = true;
            this.colKOD.VisibleIndex = 0;
            this.colKOD.Width = 54;
            // 
            // colBARKOD
            // 
            this.colBARKOD.FieldName = "BARKOD";
            this.colBARKOD.Name = "colBARKOD";
            this.colBARKOD.Visible = true;
            this.colBARKOD.VisibleIndex = 1;
            this.colBARKOD.Width = 54;
            // 
            // colSTOK_ADI
            // 
            this.colSTOK_ADI.FieldName = "STOK_ADI";
            this.colSTOK_ADI.Name = "colSTOK_ADI";
            this.colSTOK_ADI.Visible = true;
            this.colSTOK_ADI.VisibleIndex = 2;
            this.colSTOK_ADI.Width = 54;
            // 
            // colSATId
            // 
            this.colSATId.FieldName = "SATId";
            this.colSATId.Name = "colSATId";
            this.colSATId.Visible = true;
            this.colSATId.VisibleIndex = 3;
            this.colSATId.Width = 54;
            // 
            // colALId
            // 
            this.colALId.FieldName = "ALId";
            this.colALId.Name = "colALId";
            this.colALId.Visible = true;
            this.colALId.VisibleIndex = 4;
            this.colALId.Width = 54;
            // 
            // colSAT_FIS_TARIHI
            // 
            this.colSAT_FIS_TARIHI.FieldName = "SAT_FIS_TARIHI";
            this.colSAT_FIS_TARIHI.Name = "colSAT_FIS_TARIHI";
            this.colSAT_FIS_TARIHI.Visible = true;
            this.colSAT_FIS_TARIHI.VisibleIndex = 5;
            this.colSAT_FIS_TARIHI.Width = 54;
            // 
            // colAL_FIS_TARIHI
            // 
            this.colAL_FIS_TARIHI.FieldName = "AL_FIS_TARIHI";
            this.colAL_FIS_TARIHI.Name = "colAL_FIS_TARIHI";
            this.colAL_FIS_TARIHI.Visible = true;
            this.colAL_FIS_TARIHI.VisibleIndex = 6;
            this.colAL_FIS_TARIHI.Width = 54;
            // 
            // colAL_TOP_MIK
            // 
            this.colAL_TOP_MIK.FieldName = "AL_TOP_MIK";
            this.colAL_TOP_MIK.Name = "colAL_TOP_MIK";
            this.colAL_TOP_MIK.Visible = true;
            this.colAL_TOP_MIK.VisibleIndex = 7;
            this.colAL_TOP_MIK.Width = 54;
            // 
            // colSAT_MIK
            // 
            this.colSAT_MIK.FieldName = "SAT_MIK";
            this.colSAT_MIK.Name = "colSAT_MIK";
            this.colSAT_MIK.Visible = true;
            this.colSAT_MIK.VisibleIndex = 8;
            this.colSAT_MIK.Width = 54;
            // 
            // colAL_TL
            // 
            this.colAL_TL.FieldName = "AL_TL";
            this.colAL_TL.Name = "colAL_TL";
            this.colAL_TL.Visible = true;
            this.colAL_TL.VisibleIndex = 9;
            this.colAL_TL.Width = 54;
            // 
            // colSAT_TL
            // 
            this.colSAT_TL.FieldName = "SAT_TL";
            this.colSAT_TL.Name = "colSAT_TL";
            this.colSAT_TL.Visible = true;
            this.colSAT_TL.VisibleIndex = 10;
            this.colSAT_TL.Width = 54;
            // 
            // colAL_DVZ
            // 
            this.colAL_DVZ.FieldName = "AL_DVZ";
            this.colAL_DVZ.Name = "colAL_DVZ";
            this.colAL_DVZ.Visible = true;
            this.colAL_DVZ.VisibleIndex = 11;
            this.colAL_DVZ.Width = 54;
            // 
            // colKUR_BUGUN
            // 
            this.colKUR_BUGUN.FieldName = "KUR_BUGUN";
            this.colKUR_BUGUN.Name = "colKUR_BUGUN";
            this.colKUR_BUGUN.Visible = true;
            this.colKUR_BUGUN.VisibleIndex = 15;
            // 
            // colAL_TL_DEGERI_BUGUN
            // 
            this.colAL_TL_DEGERI_BUGUN.FieldName = "AL_TL_DEGERI_BUGUN";
            this.colAL_TL_DEGERI_BUGUN.Name = "colAL_TL_DEGERI_BUGUN";
            this.colAL_TL_DEGERI_BUGUN.Visible = true;
            this.colAL_TL_DEGERI_BUGUN.VisibleIndex = 12;
            this.colAL_TL_DEGERI_BUGUN.Width = 77;
            // 
            // colSAT_DVZ
            // 
            this.colSAT_DVZ.FieldName = "SAT_DVZ";
            this.colSAT_DVZ.Name = "colSAT_DVZ";
            this.colSAT_DVZ.Visible = true;
            this.colSAT_DVZ.VisibleIndex = 13;
            this.colSAT_DVZ.Width = 43;
            // 
            // colDOVIZ_KAR
            // 
            this.colDOVIZ_KAR.FieldName = "DOVIZ_KAR";
            this.colDOVIZ_KAR.Name = "colDOVIZ_KAR";
            this.colDOVIZ_KAR.Visible = true;
            this.colDOVIZ_KAR.VisibleIndex = 14;
            this.colDOVIZ_KAR.Width = 56;
            // 
            // colAL_KUR
            // 
            this.colAL_KUR.FieldName = "AL_KUR";
            this.colAL_KUR.Name = "colAL_KUR";
            this.colAL_KUR.Visible = true;
            this.colAL_KUR.VisibleIndex = 16;
            // 
            // colSAT_KUR
            // 
            this.colSAT_KUR.FieldName = "SAT_KUR";
            this.colSAT_KUR.Name = "colSAT_KUR";
            this.colSAT_KUR.Visible = true;
            this.colSAT_KUR.VisibleIndex = 17;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(373, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 26);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Görüntüle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lokasyon";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EditValue = "<Seçiniz>";
            this.lookUpEdit1.Location = new System.Drawing.Point(73, 4);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "[EditValue is null]";
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Size = new System.Drawing.Size(294, 24);
            this.lookUpEdit1.TabIndex = 10;
            // 
            // Frfifodetaystk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 492);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lookUpEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frfifodetaystk";
            this.Text = "Detaylı Döviz Stok Fifo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frfifodetaystk_FormClosing);
            this.Load += new System.EventHandler(this.Frfifodetaystk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK_ADI;
        private DevExpress.XtraGrid.Columns.GridColumn colSATId;
        private DevExpress.XtraGrid.Columns.GridColumn colALId;
        private DevExpress.XtraGrid.Columns.GridColumn colSAT_FIS_TARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colAL_FIS_TARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colAL_TOP_MIK;
        private DevExpress.XtraGrid.Columns.GridColumn colSAT_MIK;
        private DevExpress.XtraGrid.Columns.GridColumn colAL_TL;
        private DevExpress.XtraGrid.Columns.GridColumn colSAT_TL;
        private DevExpress.XtraGrid.Columns.GridColumn colAL_DVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colSAT_DVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDOVIZ_KAR;
        private DevExpress.XtraGrid.Columns.GridColumn colAL_TL_DEGERI_BUGUN;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR_BUGUN;
        private DevExpress.XtraGrid.Columns.GridColumn colAL_KUR;
        private DevExpress.XtraGrid.Columns.GridColumn colSAT_KUR;
        private DevExpress.XtraEditors.CheckedComboBoxEdit lookUpEdit1;
    }
}