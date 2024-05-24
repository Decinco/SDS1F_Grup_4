
namespace CLS_Juan_Paredes
{
    partial class frmOracle
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
            System.Windows.Forms.Label iDPILOTLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oracle_dataSet1 = new CLS_Juan_Paredes.Oracle_dataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pILOTSTableAdapter = new CLS_Juan_Paredes.Oracle_dataSetTableAdapters.PILOTSTableAdapter();
            this.tableAdapterManager = new CLS_Juan_Paredes.Oracle_dataSetTableAdapters.TableAdapterManager();
            this.iDPILOTTextBox = new System.Windows.Forms.TextBox();
            iDPILOTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oracle_dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilots";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bindingSource1;
            this.comboBox1.DisplayMember = "NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "IDPILOT";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // oracle_dataSet1
            // 
            this.oracle_dataSet1.DataSetName = "Oracle_dataSet";
            this.oracle_dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PILOTS";
            this.bindingSource1.DataSource = this.oracle_dataSet1;
            // 
            // pILOTSTableAdapter
            // 
            this.pILOTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CIRCUITSTableAdapter = null;
            this.tableAdapterManager.CLASSIFICACIOGPTableAdapter = null;
            this.tableAdapterManager.DETALLSINCIDENCIESTableAdapter = null;
            this.tableAdapterManager.ESCUDERIESTableAdapter = null;
            this.tableAdapterManager.GPTableAdapter = null;
            this.tableAdapterManager.INCIDENCIESTableAdapter = null;
            this.tableAdapterManager.PILOTSTableAdapter = this.pILOTSTableAdapter;
            this.tableAdapterManager.PUNTUACIONSTableAdapter = null;
            this.tableAdapterManager.TIPUSINCIDENCIATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CLS_Juan_Paredes.Oracle_dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDPILOTLabel
            // 
            iDPILOTLabel.AutoSize = true;
            iDPILOTLabel.Location = new System.Drawing.Point(36, 109);
            iDPILOTLabel.Name = "iDPILOTLabel";
            iDPILOTLabel.Size = new System.Drawing.Size(65, 17);
            iDPILOTLabel.TabIndex = 3;
            iDPILOTLabel.Text = "IDPILOT:";
            // 
            // iDPILOTTextBox
            // 
            this.iDPILOTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IDPILOT", true));
            this.iDPILOTTextBox.Location = new System.Drawing.Point(119, 104);
            this.iDPILOTTextBox.Name = "iDPILOTTextBox";
            this.iDPILOTTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDPILOTTextBox.TabIndex = 4;
            // 
            // frmOracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iDPILOTLabel);
            this.Controls.Add(this.iDPILOTTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmOracle";
            this.Text = "frmOracle";
            this.Load += new System.EventHandler(this.frmOracle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oracle_dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Oracle_dataSet oracle_dataSet1;
        private Oracle_dataSetTableAdapters.PILOTSTableAdapter pILOTSTableAdapter;
        private Oracle_dataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDPILOTTextBox;
    }
}