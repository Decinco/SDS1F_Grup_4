
namespace CLS_Daniel_Mugueta
{
    partial class FrmBBDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBBDD));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f1DataSetOracle_CLSMugueta = new CLS_Daniel_Mugueta.F1DataSetOracle_CLSMugueta();
            this.cmbPilots = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pILOTSTableAdapter = new CLS_Daniel_Mugueta.F1DataSetOracle_CLSMuguetaTableAdapters.PILOTSTableAdapter();
            this.imgF1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSetOracle_CLSMugueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 361);
            this.dataGridView1.TabIndex = 2;
            // 
            // f1DataSetOracle_CLSMugueta
            // 
            this.f1DataSetOracle_CLSMugueta.DataSetName = "F1DataSetOracle_CLSMugueta";
            this.f1DataSetOracle_CLSMugueta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPilots
            // 
            this.cmbPilots.DataSource = this.bindingSource1;
            this.cmbPilots.DisplayMember = "NAME";
            this.cmbPilots.FormattingEnabled = true;
            this.cmbPilots.Location = new System.Drawing.Point(143, 54);
            this.cmbPilots.Name = "cmbPilots";
            this.cmbPilots.Size = new System.Drawing.Size(256, 24);
            this.cmbPilots.TabIndex = 3;
            this.cmbPilots.ValueMember = "IDPILOT";
            this.cmbPilots.SelectedValueChanged += new System.EventHandler(this.cmbPilots_SelectedValueChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PILOTS";
            this.bindingSource1.DataSource = this.f1DataSetOracle_CLSMugueta;
            // 
            // pILOTSTableAdapter
            // 
            this.pILOTSTableAdapter.ClearBeforeFill = true;
            // 
            // imgF1
            // 
            this.imgF1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgF1.Image = global::CLS_Daniel_Mugueta.Properties.Resources.formula_1_logo_200;
            this.imgF1.Location = new System.Drawing.Point(435, 29);
            this.imgF1.Name = "imgF1";
            this.imgF1.Size = new System.Drawing.Size(215, 128);
            this.imgF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgF1.TabIndex = 4;
            this.imgF1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Piloto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Puntos Totales";
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(143, 108);
            this.txtPT.Name = "txtPT";
            this.txtPT.ReadOnly = true;
            this.txtPT.Size = new System.Drawing.Size(256, 22);
            this.txtPT.TabIndex = 7;
            // 
            // FrmBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.txtPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgF1);
            this.Controls.Add(this.cmbPilots);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBBDD";
            this.Text = "DanielMugueta - Clasificaciones por Piloto";
            this.Load += new System.EventHandler(this.FrmBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSetOracle_CLSMugueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private F1DataSetOracle_CLSMugueta f1DataSetOracle_CLSMugueta;
        private System.Windows.Forms.ComboBox cmbPilots;
        private System.Windows.Forms.BindingSource bindingSource1;
        private F1DataSetOracle_CLSMuguetaTableAdapters.PILOTSTableAdapter pILOTSTableAdapter;
        private System.Windows.Forms.PictureBox imgF1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPT;
    }
}