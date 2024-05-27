
namespace CLS_Leandro_Varas
{
    partial class oracle
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
            System.Windows.Forms.Label descGPLabel;
            this.gPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f1_CLS_Leandro = new CLS_Leandro_Varas.F1_CLS_Leandro();
            this.Resultados = new System.Windows.Forms.Button();
            this.Ganador = new System.Windows.Forms.Button();
            this.Nom_ganador = new System.Windows.Forms.TextBox();
            this.puestos_gp = new System.Windows.Forms.DataGridView();
            this.pilotsTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.PilotsTableAdapter();
            this.oracledb = new CLS_Leandro_Varas.oracledb();
            this.tableAdapterManager1 = new CLS_Leandro_Varas.oracledbTableAdapters.TableAdapterManager();
            this.dESCGPComboBox = new System.Windows.Forms.ComboBox();
            this.gPBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDGPTextBox = new System.Windows.Forms.TextBox();
            this.gPTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.GPTableAdapter();
            this.gPTableAdapter1 = new CLS_Leandro_Varas.oracledbTableAdapters.GPTableAdapter();
            descGPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestos_gp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oracledb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // descGPLabel
            // 
            descGPLabel.AutoSize = true;
            descGPLabel.Location = new System.Drawing.Point(135, 55);
            descGPLabel.Name = "descGPLabel";
            descGPLabel.Size = new System.Drawing.Size(84, 17);
            descGPLabel.TabIndex = 2;
            descGPLabel.Text = "Gran Premi:";
            descGPLabel.Click += new System.EventHandler(this.descGPLabel_Click);
            // 
            // gPBindingSource
            // 
            this.gPBindingSource.DataMember = "GP";
            this.gPBindingSource.DataSource = this.f1_CLS_Leandro;
            // 
            // f1_CLS_Leandro
            // 
            this.f1_CLS_Leandro.DataSetName = "F1_CLS_Leandro";
            this.f1_CLS_Leandro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Resultados
            // 
            this.Resultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultados.Location = new System.Drawing.Point(378, 65);
            this.Resultados.Margin = new System.Windows.Forms.Padding(0);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(121, 23);
            this.Resultados.TabIndex = 4;
            this.Resultados.Text = "Resultats GP";
            this.Resultados.UseVisualStyleBackColor = false;
            this.Resultados.Click += new System.EventHandler(this.Resultados_Click);
            // 
            // Ganador
            // 
            this.Ganador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ganador.Location = new System.Drawing.Point(378, 110);
            this.Ganador.Name = "Ganador";
            this.Ganador.Size = new System.Drawing.Size(121, 25);
            this.Ganador.TabIndex = 5;
            this.Ganador.Text = "Guanyador";
            this.Ganador.UseVisualStyleBackColor = false;
            // 
            // Nom_ganador
            // 
            this.Nom_ganador.Location = new System.Drawing.Point(194, 113);
            this.Nom_ganador.Name = "Nom_ganador";
            this.Nom_ganador.ReadOnly = true;
            this.Nom_ganador.Size = new System.Drawing.Size(121, 22);
            this.Nom_ganador.TabIndex = 7;
            // 
            // puestos_gp
            // 
            this.puestos_gp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.puestos_gp.Location = new System.Drawing.Point(20, 233);
            this.puestos_gp.Name = "puestos_gp";
            this.puestos_gp.RowHeadersWidth = 51;
            this.puestos_gp.RowTemplate.Height = 24;
            this.puestos_gp.Size = new System.Drawing.Size(784, 199);
            this.puestos_gp.TabIndex = 8;
            // 
            // pilotsTableAdapter
            // 
            this.pilotsTableAdapter.ClearBeforeFill = true;
            // 
            // oracledb
            // 
            this.oracledb.DataSetName = "oracledb";
            this.oracledb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CIRCUITSTableAdapter = null;
            this.tableAdapterManager1.CLASSIFICACIOGPTableAdapter = null;
            this.tableAdapterManager1.DETALLSINCIDENCIESTableAdapter = null;
            this.tableAdapterManager1.ESCUDERIESTableAdapter = null;
            this.tableAdapterManager1.GPTableAdapter = this.gPTableAdapter1;
            this.tableAdapterManager1.INCIDENCIESTableAdapter = null;
            this.tableAdapterManager1.PILOTSTableAdapter = null;
            this.tableAdapterManager1.PUNTUACIONSTableAdapter = null;
            this.tableAdapterManager1.TIPUSINCIDENCIATableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CLS_Leandro_Varas.oracledbTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dESCGPComboBox
            // 
            this.dESCGPComboBox.DataSource = this.gPBindingSource2;
            this.dESCGPComboBox.DisplayMember = "DESCGP";
            this.dESCGPComboBox.FormattingEnabled = true;
            this.dESCGPComboBox.Location = new System.Drawing.Point(138, 75);
            this.dESCGPComboBox.Name = "dESCGPComboBox";
            this.dESCGPComboBox.Size = new System.Drawing.Size(177, 24);
            this.dESCGPComboBox.TabIndex = 10;
            this.dESCGPComboBox.ValueMember = "IDGP";
            // 
            // gPBindingSource2
            // 
            this.gPBindingSource2.DataMember = "GP";
            this.gPBindingSource2.DataSource = this.oracledb;
            // 
            // iDGPTextBox
            // 
            this.iDGPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource2, "IDGP", true));
            this.iDGPTextBox.Location = new System.Drawing.Point(203, 75);
            this.iDGPTextBox.Name = "iDGPTextBox";
            this.iDGPTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDGPTextBox.TabIndex = 11;
            // 
            // gPTableAdapter
            // 
            this.gPTableAdapter.ClearBeforeFill = true;
            // 
            // gPTableAdapter1
            // 
            this.gPTableAdapter1.ClearBeforeFill = true;
            // 
            // oracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 458);
            this.Controls.Add(this.dESCGPComboBox);
            this.Controls.Add(this.puestos_gp);
            this.Controls.Add(this.Nom_ganador);
            this.Controls.Add(this.Ganador);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(descGPLabel);
            this.Controls.Add(this.iDGPTextBox);
            this.Name = "oracle";
            this.Text = "oracle";
            this.Load += new System.EventHandler(this.oracle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestos_gp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oracledb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private F1_CLS_Leandro f1_CLS_Leandro;
        private System.Windows.Forms.BindingSource gPBindingSource;
        private F1_CLS_LeandroTableAdapters.PilotsTableAdapter pilotsTableAdapter;
        private System.Windows.Forms.Button Resultados;
        private System.Windows.Forms.Button Ganador;
        private System.Windows.Forms.TextBox Nom_ganador;
        private System.Windows.Forms.DataGridView puestos_gp;
        private oracledb oracledb;
        private oracledbTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox dESCGPComboBox;
        private System.Windows.Forms.BindingSource gPBindingSource2;
        private System.Windows.Forms.TextBox iDGPTextBox;
        private F1_CLS_LeandroTableAdapters.GPTableAdapter gPTableAdapter;
        private oracledbTableAdapters.GPTableAdapter gPTableAdapter1;
    }
}