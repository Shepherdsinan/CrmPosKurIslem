namespace CrmPosKurİşlem
{
    partial class FrChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrChange));
            this.lbltutar = new DevExpress.XtraEditors.LabelControl();
            this.btnnakit = new DevExpress.XtraEditors.SimpleButton();
            this.btnkredi = new DevExpress.XtraEditors.SimpleButton();
            this.lblfisid = new DevExpress.XtraEditors.LabelControl();
            this.cmbdoviz = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbldvzcins = new DevExpress.XtraEditors.LabelControl();
            this.lblpara = new DevExpress.XtraEditors.LabelControl();
            this.txtodeme = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txttutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtparaustu = new DevExpress.XtraEditors.TextEdit();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.lbldolar = new DevExpress.XtraEditors.LabelControl();
            this.lbleuro = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbdoviz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtodeme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtparaustu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltutar
            // 
            this.lbltutar.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.Appearance.ForeColor = System.Drawing.Color.Lavender;
            this.lbltutar.Appearance.Options.UseFont = true;
            this.lbltutar.Appearance.Options.UseForeColor = true;
            this.lbltutar.Location = new System.Drawing.Point(238, 13);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(99, 42);
            this.lbltutar.TabIndex = 0;
            this.lbltutar.Text = "00.00";
            // 
            // btnnakit
            // 
            this.btnnakit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnnakit.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnakit.Appearance.Options.UseBackColor = true;
            this.btnnakit.Appearance.Options.UseFont = true;
            this.btnnakit.Location = new System.Drawing.Point(12, 296);
            this.btnnakit.Name = "btnnakit";
            this.btnnakit.Size = new System.Drawing.Size(209, 59);
            this.btnnakit.TabIndex = 3;
            this.btnnakit.Text = "NAKİT";
            this.btnnakit.Click += new System.EventHandler(this.btnnakit_Click);
            // 
            // btnkredi
            // 
            this.btnkredi.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.btnkredi.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkredi.Appearance.Options.UseBackColor = true;
            this.btnkredi.Appearance.Options.UseFont = true;
            this.btnkredi.Location = new System.Drawing.Point(264, 296);
            this.btnkredi.Name = "btnkredi";
            this.btnkredi.Size = new System.Drawing.Size(209, 59);
            this.btnkredi.TabIndex = 4;
            this.btnkredi.Text = "KREDİ";
            this.btnkredi.Click += new System.EventHandler(this.btnkredi_Click);
            // 
            // lblfisid
            // 
            this.lblfisid.Location = new System.Drawing.Point(13, 13);
            this.lblfisid.Name = "lblfisid";
            this.lblfisid.Size = new System.Drawing.Size(19, 13);
            this.lblfisid.TabIndex = 6;
            this.lblfisid.Text = "fisid";
            // 
            // cmbdoviz
            // 
            this.cmbdoviz.EditValue = "TRY";
            this.cmbdoviz.Location = new System.Drawing.Point(131, 98);
            this.cmbdoviz.Name = "cmbdoviz";
            this.cmbdoviz.Properties.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.cmbdoviz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdoviz.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmbdoviz.Properties.Appearance.Options.UseBackColor = true;
            this.cmbdoviz.Properties.Appearance.Options.UseFont = true;
            this.cmbdoviz.Properties.Appearance.Options.UseForeColor = true;
            this.cmbdoviz.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cmbdoviz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbdoviz.Properties.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR"});
            this.cmbdoviz.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbdoviz.Size = new System.Drawing.Size(84, 24);
            this.cmbdoviz.TabIndex = 5;
            this.cmbdoviz.SelectedIndexChanged += new System.EventHandler(this.cmbdoviz_SelectedIndexChanged);
            // 
            // lbldvzcins
            // 
            this.lbldvzcins.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldvzcins.Appearance.Options.UseFont = true;
            this.lbldvzcins.Location = new System.Drawing.Point(396, 100);
            this.lbldvzcins.Name = "lbldvzcins";
            this.lbldvzcins.Size = new System.Drawing.Size(8, 16);
            this.lbldvzcins.TabIndex = 7;
            this.lbldvzcins.Text = "1";
            // 
            // lblpara
            // 
            this.lblpara.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpara.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblpara.Appearance.Options.UseFont = true;
            this.lblpara.Appearance.Options.UseForeColor = true;
            this.lblpara.Location = new System.Drawing.Point(131, 142);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(87, 23);
            this.lblpara.TabIndex = 8;
            this.lblpara.Text = "TRY Para";
            // 
            // txtodeme
            // 
            this.txtodeme.Location = new System.Drawing.Point(245, 138);
            this.txtodeme.Name = "txtodeme";
            this.txtodeme.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtodeme.Properties.Appearance.Options.UseFont = true;
            this.txtodeme.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtodeme.Size = new System.Drawing.Size(159, 30);
            this.txtodeme.TabIndex = 9;
            this.txtodeme.EditValueChanged += new System.EventHandler(this.txtodeme_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(131, 190);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 23);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Tutar";
            // 
            // txttutar
            // 
            this.txttutar.Enabled = false;
            this.txttutar.Location = new System.Drawing.Point(245, 188);
            this.txttutar.Name = "txttutar";
            this.txttutar.Properties.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.txttutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Properties.Appearance.Options.UseBackColor = true;
            this.txttutar.Properties.Appearance.Options.UseFont = true;
            this.txttutar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txttutar.Size = new System.Drawing.Size(159, 30);
            this.txttutar.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(131, 240);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 23);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Para üstü";
            // 
            // txtparaustu
            // 
            this.txtparaustu.Location = new System.Drawing.Point(245, 233);
            this.txtparaustu.Name = "txtparaustu";
            this.txtparaustu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparaustu.Properties.Appearance.Options.UseFont = true;
            this.txtparaustu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtparaustu.Size = new System.Drawing.Size(159, 30);
            this.txtparaustu.TabIndex = 13;
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(443, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnclose.Size = new System.Drawing.Size(42, 27);
            this.btnclose.TabIndex = 14;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbldolar
            // 
            this.lbldolar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldolar.Appearance.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbldolar.Appearance.Options.UseFont = true;
            this.lbldolar.Appearance.Options.UseForeColor = true;
            this.lbldolar.Location = new System.Drawing.Point(145, 61);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(5, 19);
            this.lbldolar.TabIndex = 15;
            this.lbldolar.Text = ".";
            // 
            // lbleuro
            // 
            this.lbleuro.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleuro.Appearance.ForeColor = System.Drawing.Color.Salmon;
            this.lbleuro.Appearance.Options.UseFont = true;
            this.lbleuro.Appearance.Options.UseForeColor = true;
            this.lbleuro.Location = new System.Drawing.Point(252, 61);
            this.lbleuro.Name = "lbleuro";
            this.lbleuro.Size = new System.Drawing.Size(5, 19);
            this.lbleuro.TabIndex = 16;
            this.lbleuro.Text = ".";
            // 
            // FrChange
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 366);
            this.Controls.Add(this.lbleuro);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtparaustu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtodeme);
            this.Controls.Add(this.lblpara);
            this.Controls.Add(this.lbldvzcins);
            this.Controls.Add(this.lblfisid);
            this.Controls.Add(this.btnkredi);
            this.Controls.Add(this.btnnakit);
            this.Controls.Add(this.lbltutar);
            this.Controls.Add(this.cmbdoviz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrChange";
            this.Load += new System.EventHandler(this.FrChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbdoviz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtodeme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtparaustu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbltutar;
        private DevExpress.XtraEditors.SimpleButton btnnakit;
        private DevExpress.XtraEditors.SimpleButton btnkredi;
        private DevExpress.XtraEditors.LabelControl lblfisid;
        private DevExpress.XtraEditors.ComboBoxEdit cmbdoviz;
        private DevExpress.XtraEditors.LabelControl lbldvzcins;
        private DevExpress.XtraEditors.LabelControl lblpara;
        private DevExpress.XtraEditors.TextEdit txtodeme;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txttutar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtparaustu;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.LabelControl lbldolar;
        private DevExpress.XtraEditors.LabelControl lbleuro;
    }
}