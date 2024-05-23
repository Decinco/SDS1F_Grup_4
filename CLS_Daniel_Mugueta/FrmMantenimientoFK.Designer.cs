
namespace CLS_Daniel_Mugueta
{
    partial class FrmMantenimientoFK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoFK));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPilotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEscuderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntsCarnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dorsalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSPilots = new System.Windows.Forms.BindingSource(this.components);
            this.f1DataSet_CLSMugueta1 = new CLS_Daniel_Mugueta.F1DataSet_CLSMugueta();
            this.txtDorsal = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtPilot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgF1 = new System.Windows.Forms.PictureBox();
            this.pilotsTableAdapter = new CLS_Daniel_Mugueta.F1DataSet_CLSMuguetaTableAdapters.PilotsTableAdapter();
            this.BSEscuderies = new System.Windows.Forms.BindingSource(this.components);
            this.escuderiesTableAdapter = new CLS_Daniel_Mugueta.F1DataSet_CLSMuguetaTableAdapters.EscuderiesTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbEscuderia = new System.Windows.Forms.ComboBox();
            this.txtEscuderia = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet_CLSMugueta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEscuderies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPilotDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idEscuderiaDataGridViewTextBoxColumn,
            this.puntsCarnetDataGridViewTextBoxColumn,
            this.dorsalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BSPilots;
            this.dataGridView1.Location = new System.Drawing.Point(0, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 361);
            this.dataGridView1.TabIndex = 1;
            // 
            // idPilotDataGridViewTextBoxColumn
            // 
            this.idPilotDataGridViewTextBoxColumn.DataPropertyName = "idPilot";
            this.idPilotDataGridViewTextBoxColumn.HeaderText = "idPilot";
            this.idPilotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPilotDataGridViewTextBoxColumn.Name = "idPilotDataGridViewTextBoxColumn";
            this.idPilotDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPilotDataGridViewTextBoxColumn.Visible = false;
            this.idPilotDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEscuderiaDataGridViewTextBoxColumn
            // 
            this.idEscuderiaDataGridViewTextBoxColumn.DataPropertyName = "idEscuderia";
            this.idEscuderiaDataGridViewTextBoxColumn.HeaderText = "idEscuderia";
            this.idEscuderiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEscuderiaDataGridViewTextBoxColumn.Name = "idEscuderiaDataGridViewTextBoxColumn";
            this.idEscuderiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // puntsCarnetDataGridViewTextBoxColumn
            // 
            this.puntsCarnetDataGridViewTextBoxColumn.DataPropertyName = "PuntsCarnet";
            this.puntsCarnetDataGridViewTextBoxColumn.HeaderText = "PuntsCarnet";
            this.puntsCarnetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puntsCarnetDataGridViewTextBoxColumn.Name = "puntsCarnetDataGridViewTextBoxColumn";
            this.puntsCarnetDataGridViewTextBoxColumn.Width = 125;
            // 
            // dorsalDataGridViewTextBoxColumn
            // 
            this.dorsalDataGridViewTextBoxColumn.DataPropertyName = "Dorsal";
            this.dorsalDataGridViewTextBoxColumn.HeaderText = "Dorsal";
            this.dorsalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dorsalDataGridViewTextBoxColumn.Name = "dorsalDataGridViewTextBoxColumn";
            this.dorsalDataGridViewTextBoxColumn.Width = 125;
            // 
            // BSPilots
            // 
            this.BSPilots.DataMember = "Pilots";
            this.BSPilots.DataSource = this.f1DataSet_CLSMugueta1;
            // 
            // f1DataSet_CLSMugueta1
            // 
            this.f1DataSet_CLSMugueta1.DataSetName = "F1DataSet_CLSMugueta";
            this.f1DataSet_CLSMugueta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDorsal
            // 
            this.txtDorsal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSPilots, "Dorsal", true));
            this.txtDorsal.Location = new System.Drawing.Point(144, 141);
            this.txtDorsal.Name = "txtDorsal";
            this.txtDorsal.Size = new System.Drawing.Size(250, 22);
            this.txtDorsal.TabIndex = 18;
            // 
            // txtCarnet
            // 
            this.txtCarnet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSPilots, "PuntsCarnet", true));
            this.txtCarnet.Location = new System.Drawing.Point(144, 113);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(250, 22);
            this.txtCarnet.TabIndex = 17;
            // 
            // txtPilot
            // 
            this.txtPilot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSPilots, "Name", true));
            this.txtPilot.Location = new System.Drawing.Point(144, 53);
            this.txtPilot.Name = "txtPilot";
            this.txtPilot.Size = new System.Drawing.Size(250, 22);
            this.txtPilot.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dorsal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puntos Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escuderia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Piloto";
            // 
            // imgF1
            // 
            this.imgF1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgF1.Image = global::CLS_Daniel_Mugueta.Properties.Resources.formula_1_logo_200;
            this.imgF1.Location = new System.Drawing.Point(444, 44);
            this.imgF1.Name = "imgF1";
            this.imgF1.Size = new System.Drawing.Size(215, 128);
            this.imgF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgF1.TabIndex = 2;
            this.imgF1.TabStop = false;
            // 
            // pilotsTableAdapter
            // 
            this.pilotsTableAdapter.ClearBeforeFill = true;
            // 
            // BSEscuderies
            // 
            this.BSEscuderies.DataMember = "Escuderies";
            this.BSEscuderies.DataSource = this.f1DataSet_CLSMugueta1;
            // 
            // escuderiesTableAdapter
            // 
            this.escuderiesTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.BSPilots;
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
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(682, 31);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cmbEscuderia
            // 
            this.cmbEscuderia.DataSource = this.BSEscuderies;
            this.cmbEscuderia.DisplayMember = "DescEscuderia";
            this.cmbEscuderia.FormattingEnabled = true;
            this.cmbEscuderia.Location = new System.Drawing.Point(144, 83);
            this.cmbEscuderia.Name = "cmbEscuderia";
            this.cmbEscuderia.Size = new System.Drawing.Size(189, 24);
            this.cmbEscuderia.TabIndex = 20;
            this.cmbEscuderia.ValueMember = "idEscuderia";
            this.cmbEscuderia.SelectedValueChanged += new System.EventHandler(this.cmbEscuderia_SelectedValueChanged);
            // 
            // txtEscuderia
            // 
            this.txtEscuderia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSPilots, "idEscuderia", true));
            this.txtEscuderia.Location = new System.Drawing.Point(339, 83);
            this.txtEscuderia.Name = "txtEscuderia";
            this.txtEscuderia.ReadOnly = true;
            this.txtEscuderia.Size = new System.Drawing.Size(55, 22);
            this.txtEscuderia.TabIndex = 21;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 28);
            this.toolStripButton1.Text = "Guardar Cambios";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmMantenimientoFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.txtEscuderia);
            this.Controls.Add(this.cmbEscuderia);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtDorsal);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.txtPilot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgF1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMantenimientoFK";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMantenimientoFK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet_CLSMugueta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEscuderies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox imgF1;
        private System.Windows.Forms.TextBox txtDorsal;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtPilot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private F1DataSet_CLSMugueta f1DataSet_CLSMugueta1;
        private System.Windows.Forms.BindingSource BSPilots;
        private F1DataSet_CLSMuguetaTableAdapters.PilotsTableAdapter pilotsTableAdapter;
        private System.Windows.Forms.BindingSource BSEscuderies;
        private F1DataSet_CLSMuguetaTableAdapters.EscuderiesTableAdapter escuderiesTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idPilotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscuderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntsCarnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dorsalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbEscuderia;
        private System.Windows.Forms.TextBox txtEscuderia;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}