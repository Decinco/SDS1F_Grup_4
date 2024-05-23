
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.f1DataSetOracle_CLSMugueta = new CLS_Daniel_Mugueta.F1DataSetOracle_CLSMugueta();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUNTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSetOracle_CLSMugueta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.gPDataGridViewTextBoxColumn,
            this.pUNTSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 361);
            this.dataGridView1.TabIndex = 2;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "RESULTATS_PILOT.CURSOR_PILOT";
            this.bindingSource1.DataSource = this.f1DataSetOracle_CLSMugueta;
            // 
            // f1DataSetOracle_CLSMugueta
            // 
            this.f1DataSetOracle_CLSMugueta.DataSetName = "F1DataSetOracle_CLSMugueta";
            this.f1DataSetOracle_CLSMugueta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gPDataGridViewTextBoxColumn
            // 
            this.gPDataGridViewTextBoxColumn.DataPropertyName = "GP";
            this.gPDataGridViewTextBoxColumn.HeaderText = "GP";
            this.gPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPDataGridViewTextBoxColumn.Name = "gPDataGridViewTextBoxColumn";
            this.gPDataGridViewTextBoxColumn.Width = 125;
            // 
            // pUNTSDataGridViewTextBoxColumn
            // 
            this.pUNTSDataGridViewTextBoxColumn.DataPropertyName = "PUNTS";
            this.pUNTSDataGridViewTextBoxColumn.HeaderText = "PUNTS";
            this.pUNTSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pUNTSDataGridViewTextBoxColumn.Name = "pUNTSDataGridViewTextBoxColumn";
            this.pUNTSDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBBDD";
            this.Text = "FrmBBDD";
            this.Load += new System.EventHandler(this.FrmBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSetOracle_CLSMugueta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUNTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private F1DataSetOracle_CLSMugueta f1DataSetOracle_CLSMugueta;
    }
}