
namespace CLS_Juan_Paredes
{
    partial class frmManteniment
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.f1DataSet1 = new cls_Paredes.F1DataSet();
            this.tipusIncidenciaTableAdapter = new cls_Paredes.F1DataSetTableAdapters.TipusIncidenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TipusIncidencia";
            this.bindingSource1.DataSource = this.f1DataSet1;
            // 
            // f1DataSet1
            // 
            this.f1DataSet1.DataSetName = "F1DataSet";
            this.f1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipusIncidenciaTableAdapter
            // 
            this.tipusIncidenciaTableAdapter.ClearBeforeFill = true;
            // 
            // frmManteniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 582);
            this.Name = "frmManteniment";
            this.Text = "frmMantenimiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private cls_Paredes.F1DataSet f1DataSet1;
        private cls_Paredes.F1DataSetTableAdapters.TipusIncidenciaTableAdapter tipusIncidenciaTableAdapter;
    }
}

