
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOracle));
            this.nombres_pilots = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oracle_dataSet1 = new CLS_Juan_Paredes.Oracle_dataSet();
            this.pILOTSTableAdapter = new CLS_Juan_Paredes.Oracle_dataSetTableAdapters.PILOTSTableAdapter();
            this.tableAdapterManager = new CLS_Juan_Paredes.Oracle_dataSetTableAdapters.TableAdapterManager();
            this.iDPILOTTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            iDPILOTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oracle_dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDPILOTLabel
            // 
            iDPILOTLabel.AutoSize = true;
            iDPILOTLabel.Location = new System.Drawing.Point(116, 37);
            iDPILOTLabel.Name = "iDPILOTLabel";
            iDPILOTLabel.Size = new System.Drawing.Size(39, 17);
            iDPILOTLabel.TabIndex = 3;
            iDPILOTLabel.Text = "Pilot:";
            // 
            // nombres_pilots
            // 
            this.nombres_pilots.DataSource = this.bindingSource1;
            this.nombres_pilots.DisplayMember = "NAME";
            this.nombres_pilots.FormattingEnabled = true;
            this.nombres_pilots.Location = new System.Drawing.Point(118, 70);
            this.nombres_pilots.Name = "nombres_pilots";
            this.nombres_pilots.Size = new System.Drawing.Size(223, 24);
            this.nombres_pilots.TabIndex = 1;
            this.nombres_pilots.ValueMember = "IDPILOT";
            this.nombres_pilots.SelectedIndexChanged += new System.EventHandler(this.nombres_pilots_SelectedIndexChanged);
            this.nombres_pilots.Click += new System.EventHandler(this.nombres_pilots_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PILOTS";
            this.bindingSource1.DataSource = this.oracle_dataSet1;
            // 
            // oracle_dataSet1
            // 
            this.oracle_dataSet1.DataSetName = "Oracle_dataSet";
            this.oracle_dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // iDPILOTTextBox
            // 
            this.iDPILOTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IDPILOT", true));
            this.iDPILOTTextBox.Location = new System.Drawing.Point(119, 69);
            this.iDPILOTTextBox.Name = "iDPILOTTextBox";
            this.iDPILOTTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDPILOTTextBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 243);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Incidències pilot.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Punts de sanció";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmOracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(iDPILOTLabel);
            this.Controls.Add(this.nombres_pilots);
            this.Controls.Add(this.iDPILOTTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOracle";
            this.Text = "JuanParedes - Incidencias de un Piloto";
            this.Load += new System.EventHandler(this.frmOracle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oracle_dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox nombres_pilots;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Oracle_dataSet oracle_dataSet1;
        private Oracle_dataSetTableAdapters.PILOTSTableAdapter pILOTSTableAdapter;
        private Oracle_dataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDPILOTTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}