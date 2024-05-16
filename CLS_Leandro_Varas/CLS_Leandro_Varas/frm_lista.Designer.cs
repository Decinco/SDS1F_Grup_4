
namespace CLS_Leandro_Varas
{
    partial class frm_lista
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
            System.Windows.Forms.Label idDetallIncidenciaLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.f1DataSet = new CLS_Leandro_Varas.F1DataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detallsIncidenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallsIncidenciesTableAdapter = new CLS_Leandro_Varas.F1DataSetTableAdapters.DetallsIncidenciesTableAdapter();
            this.tableAdapterManager = new CLS_Leandro_Varas.F1DataSetTableAdapters.TableAdapterManager();
            this.idDetallIncidenciaTextBox = new System.Windows.Forms.TextBox();
            idDetallIncidenciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallsIncidenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // f1DataSet
            // 
            this.f1DataSet.DataSetName = "F1DataSet";
            this.f1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.f1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // detallsIncidenciesBindingSource
            // 
            this.detallsIncidenciesBindingSource.DataMember = "DetallsIncidencies";
            this.detallsIncidenciesBindingSource.DataSource = this.f1DataSet;
            // 
            // detallsIncidenciesTableAdapter
            // 
            this.detallsIncidenciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CircuitsTableAdapter = null;
            this.tableAdapterManager.ClassificacioGPTableAdapter = null;
            this.tableAdapterManager.DetallsIncidenciesTableAdapter = this.detallsIncidenciesTableAdapter;
            this.tableAdapterManager.EscuderiesTableAdapter = null;
            this.tableAdapterManager.GPTableAdapter = null;
            this.tableAdapterManager.IncidenciesTableAdapter = null;
            this.tableAdapterManager.PilotsTableAdapter = null;
            this.tableAdapterManager.PuntuacionsTableAdapter = null;
            this.tableAdapterManager.TipusIncidenciaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CLS_Leandro_Varas.F1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDetallIncidenciaLabel
            // 
            idDetallIncidenciaLabel.AutoSize = true;
            idDetallIncidenciaLabel.Location = new System.Drawing.Point(144, 72);
            idDetallIncidenciaLabel.Name = "idDetallIncidenciaLabel";
            idDetallIncidenciaLabel.Size = new System.Drawing.Size(130, 17);
            idDetallIncidenciaLabel.TabIndex = 1;
            idDetallIncidenciaLabel.Text = "id Detall Incidencia:";
            // 
            // idDetallIncidenciaTextBox
            // 
            this.idDetallIncidenciaTextBox.Location = new System.Drawing.Point(280, 69);
            this.idDetallIncidenciaTextBox.Name = "idDetallIncidenciaTextBox";
            this.idDetallIncidenciaTextBox.Size = new System.Drawing.Size(100, 22);
            this.idDetallIncidenciaTextBox.TabIndex = 2;
            // 
            // frm_lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idDetallIncidenciaLabel);
            this.Controls.Add(this.idDetallIncidenciaTextBox);
            this.Controls.Add(this.button1);
            this.Name = "frm_lista";
            this.Text = "frm_lista";
            this.Load += new System.EventHandler(this.frm_lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallsIncidenciesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private F1DataSet f1DataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource detallsIncidenciesBindingSource;
        private F1DataSetTableAdapters.DetallsIncidenciesTableAdapter detallsIncidenciesTableAdapter;
        private F1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idDetallIncidenciaTextBox;
    }
}