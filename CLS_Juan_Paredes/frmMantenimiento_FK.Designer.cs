
namespace CLS_Juan_Paredes
{
    partial class frmMantenimiento_FK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento_FK));
            this.f1_Paredes1 = new CLS_Juan_Paredes.F1_Paredes();
            this.BSIncidencias = new System.Windows.Forms.BindingSource(this.components);
            this.incidenciesTableAdapter = new CLS_Juan_Paredes.F1_ParedesTableAdapters.IncidenciesTableAdapter();
            this.BSTiposIncidencias = new System.Windows.Forms.BindingSource(this.components);
            this.tipusIncidenciaTableAdapter = new CLS_Juan_Paredes.F1_ParedesTableAdapters.TipusIncidenciaTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Incidencias = new System.Windows.Forms.TextBox();
            this.desc_incidencias = new System.Windows.Forms.TextBox();
            this.cmb_descIncidencias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuardarYCerrar = new System.Windows.Forms.ToolStripButton();
            this.idTipusIncidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescTipusIncidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idIncidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descIncidenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.f1_Paredes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSIncidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTiposIncidencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // f1_Paredes1
            // 
            this.f1_Paredes1.DataSetName = "F1_Paredes";
            this.f1_Paredes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSIncidencias
            // 
            this.BSIncidencias.DataMember = "Incidencies";
            this.BSIncidencias.DataSource = this.f1_Paredes1;
            // 
            // incidenciesTableAdapter
            // 
            this.incidenciesTableAdapter.ClearBeforeFill = true;
            // 
            // BSTiposIncidencias
            // 
            this.BSTiposIncidencias.DataMember = "TipusIncidencia";
            this.BSTiposIncidencias.DataSource = this.f1_Paredes1;
            // 
            // tipusIncidenciaTableAdapter
            // 
            this.tipusIncidenciaTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.BSIncidencias;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.GuardarYCerrar});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1002, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipusIncidenciaDataGridViewTextBoxColumn,
            this.DescTipusIncidencia,
            this.idIncidenciaDataGridViewTextBoxColumn,
            this.descIncidenciaDataGridViewTextBoxColumn,
            this.idGPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BSIncidencias;
            this.dataGridView1.Location = new System.Drawing.Point(357, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(633, 366);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // id_Incidencias
            // 
            this.id_Incidencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSIncidencias, "idTipusIncidencia", true));
            this.id_Incidencias.Location = new System.Drawing.Point(49, 228);
            this.id_Incidencias.Name = "id_Incidencias";
            this.id_Incidencias.ReadOnly = true;
            this.id_Incidencias.Size = new System.Drawing.Size(100, 22);
            this.id_Incidencias.TabIndex = 2;
            this.id_Incidencias.TextChanged += new System.EventHandler(this.id_Incidencias_TextChanged);
            // 
            // desc_incidencias
            // 
            this.desc_incidencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSIncidencias, "DescIncidencia", true));
            this.desc_incidencias.Location = new System.Drawing.Point(49, 110);
            this.desc_incidencias.Name = "desc_incidencias";
            this.desc_incidencias.Size = new System.Drawing.Size(258, 22);
            this.desc_incidencias.TabIndex = 3;
            // 
            // cmb_descIncidencias
            // 
            this.cmb_descIncidencias.DataSource = this.BSTiposIncidencias;
            this.cmb_descIncidencias.DisplayMember = "DescTipusIncidencia";
            this.cmb_descIncidencias.FormattingEnabled = true;
            this.cmb_descIncidencias.Location = new System.Drawing.Point(49, 228);
            this.cmb_descIncidencias.Name = "cmb_descIncidencias";
            this.cmb_descIncidencias.Size = new System.Drawing.Size(223, 24);
            this.cmb_descIncidencias.TabIndex = 4;
            this.cmb_descIncidencias.ValueMember = "idTipusIncidencia";
            this.cmb_descIncidencias.SelectedValueChanged += new System.EventHandler(this.cmb_descIncidencias_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipos de Incidencias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incidencias:";
            // 
            // GuardarYCerrar
            // 
            this.GuardarYCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GuardarYCerrar.Image = ((System.Drawing.Image)(resources.GetObject("GuardarYCerrar.Image")));
            this.GuardarYCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarYCerrar.Name = "GuardarYCerrar";
            this.GuardarYCerrar.Size = new System.Drawing.Size(29, 24);
            this.GuardarYCerrar.Text = "Guardar";
            this.GuardarYCerrar.Click += new System.EventHandler(this.GuardarYCerrar_Click);
            // 
            // idTipusIncidenciaDataGridViewTextBoxColumn
            // 
            this.idTipusIncidenciaDataGridViewTextBoxColumn.DataPropertyName = "idTipusIncidencia";
            this.idTipusIncidenciaDataGridViewTextBoxColumn.HeaderText = "idTipusIncidencia";
            this.idTipusIncidenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTipusIncidenciaDataGridViewTextBoxColumn.Name = "idTipusIncidenciaDataGridViewTextBoxColumn";
            this.idTipusIncidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipusIncidenciaDataGridViewTextBoxColumn.Visible = false;
            this.idTipusIncidenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // DescTipusIncidencia
            // 
            this.DescTipusIncidencia.HeaderText = "Tipos de Incidencias";
            this.DescTipusIncidencia.MinimumWidth = 6;
            this.DescTipusIncidencia.Name = "DescTipusIncidencia";
            this.DescTipusIncidencia.ReadOnly = true;
            this.DescTipusIncidencia.Width = 125;
            // 
            // idIncidenciaDataGridViewTextBoxColumn
            // 
            this.idIncidenciaDataGridViewTextBoxColumn.DataPropertyName = "idIncidencia";
            this.idIncidenciaDataGridViewTextBoxColumn.HeaderText = "idIncidencia";
            this.idIncidenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idIncidenciaDataGridViewTextBoxColumn.Name = "idIncidenciaDataGridViewTextBoxColumn";
            this.idIncidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idIncidenciaDataGridViewTextBoxColumn.Visible = false;
            this.idIncidenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // descIncidenciaDataGridViewTextBoxColumn
            // 
            this.descIncidenciaDataGridViewTextBoxColumn.DataPropertyName = "DescIncidencia";
            this.descIncidenciaDataGridViewTextBoxColumn.HeaderText = "Incidencia";
            this.descIncidenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descIncidenciaDataGridViewTextBoxColumn.Name = "descIncidenciaDataGridViewTextBoxColumn";
            this.descIncidenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descIncidenciaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idGPDataGridViewTextBoxColumn
            // 
            this.idGPDataGridViewTextBoxColumn.DataPropertyName = "idGP";
            this.idGPDataGridViewTextBoxColumn.HeaderText = "idGP";
            this.idGPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGPDataGridViewTextBoxColumn.Name = "idGPDataGridViewTextBoxColumn";
            this.idGPDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGPDataGridViewTextBoxColumn.Visible = false;
            this.idGPDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmMantenimiento_FK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_descIncidencias);
            this.Controls.Add(this.desc_incidencias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.id_Incidencias);
            this.Name = "frmMantenimiento_FK";
            this.Text = "frmMantenimiento_FK";
            this.Load += new System.EventHandler(this.frmMantenimiento_FK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1_Paredes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSIncidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSTiposIncidencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private F1_Paredes f1_Paredes1;
        private System.Windows.Forms.BindingSource BSIncidencias;
        private F1_ParedesTableAdapters.IncidenciesTableAdapter incidenciesTableAdapter;
        private System.Windows.Forms.BindingSource BSTiposIncidencias;
        private F1_ParedesTableAdapters.TipusIncidenciaTableAdapter tipusIncidenciaTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id_Incidencias;
        private System.Windows.Forms.TextBox desc_incidencias;
        private System.Windows.Forms.ComboBox cmb_descIncidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton GuardarYCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipusIncidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescTipusIncidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIncidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descIncidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGPDataGridViewTextBoxColumn;
    }
}