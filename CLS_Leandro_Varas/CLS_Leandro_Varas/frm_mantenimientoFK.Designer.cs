
namespace CLS_Leandro_Varas
{
    partial class frm_mantenimientoFK
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
            System.Windows.Forms.Label temporadaLabel;
            System.Windows.Forms.Label dataGPLabel;
            System.Windows.Forms.Label circuitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mantenimientoFK));
            this.f1_CLS_Leandro = new CLS_Leandro_Varas.F1_CLS_Leandro();
            this.gPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.GPTableAdapter();
            this.tableAdapterManager = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.TableAdapterManager();
            this.circuitsTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.CircuitsTableAdapter();
            this.gPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descGPTextBox = new System.Windows.Forms.TextBox();
            this.temporadaTextBox = new System.Windows.Forms.TextBox();
            this.dataGPDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.circuitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circuitComboBox = new System.Windows.Forms.ComboBox();
            this.DatosGP_circuit = new System.Windows.Forms.DataGridView();
            this.f1_CLS_Leandro1 = new CLS_Leandro_Varas.F1_CLS_Leandro();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCircuitTextBox = new System.Windows.Forms.TextBox();
            this.idGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCircuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Circuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descGPLabel = new System.Windows.Forms.Label();
            temporadaLabel = new System.Windows.Forms.Label();
            dataGPLabel = new System.Windows.Forms.Label();
            circuitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingNavigator)).BeginInit();
            this.gPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosGP_circuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descGPLabel
            // 
            descGPLabel.AutoSize = true;
            descGPLabel.Location = new System.Drawing.Point(78, 76);
            descGPLabel.Name = "descGPLabel";
            descGPLabel.Size = new System.Drawing.Size(28, 17);
            descGPLabel.TabIndex = 1;
            descGPLabel.Text = "GP";
            descGPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            descGPLabel.Click += new System.EventHandler(this.descGPLabel_Click);
            // 
            // temporadaLabel
            // 
            temporadaLabel.AutoSize = true;
            temporadaLabel.Location = new System.Drawing.Point(25, 119);
            temporadaLabel.Name = "temporadaLabel";
            temporadaLabel.Size = new System.Drawing.Size(81, 17);
            temporadaLabel.TabIndex = 3;
            temporadaLabel.Text = "Temporada";
            temporadaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGPLabel
            // 
            dataGPLabel.AutoSize = true;
            dataGPLabel.Location = new System.Drawing.Point(44, 166);
            dataGPLabel.Name = "dataGPLabel";
            dataGPLabel.Size = new System.Drawing.Size(62, 17);
            dataGPLabel.TabIndex = 5;
            dataGPLabel.Text = "Data GP";
            dataGPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // circuitLabel
            // 
            circuitLabel.AutoSize = true;
            circuitLabel.Location = new System.Drawing.Point(533, 69);
            circuitLabel.Name = "circuitLabel";
            circuitLabel.Size = new System.Drawing.Size(51, 17);
            circuitLabel.TabIndex = 7;
            circuitLabel.Text = "Circuit:";
            // 
            // f1_CLS_Leandro
            // 
            this.f1_CLS_Leandro.DataSetName = "F1_CLS_Leandro";
            this.f1_CLS_Leandro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gPBindingSource
            // 
            this.gPBindingSource.DataMember = "GP";
            this.gPBindingSource.DataSource = this.f1_CLS_Leandro;
            // 
            // gPTableAdapter
            // 
            this.gPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CircuitsTableAdapter = this.circuitsTableAdapter;
            this.tableAdapterManager.ClassificacioGPTableAdapter = null;
            this.tableAdapterManager.DetallsIncidenciesTableAdapter = null;
            this.tableAdapterManager.EscuderiesTableAdapter = null;
            this.tableAdapterManager.GPTableAdapter = this.gPTableAdapter;
            this.tableAdapterManager.IncidenciesTableAdapter = null;
            this.tableAdapterManager.PilotsTableAdapter = null;
            this.tableAdapterManager.PuntuacionsTableAdapter = null;
            this.tableAdapterManager.TipusIncidenciaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // circuitsTableAdapter
            // 
            this.circuitsTableAdapter.ClearBeforeFill = true;
            // 
            // gPBindingNavigator
            // 
            this.gPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gPBindingNavigator.BindingSource = this.gPBindingSource;
            this.gPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gPBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gPBindingNavigatorSaveItem});
            this.gPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gPBindingNavigator.Name = "gPBindingNavigator";
            this.gPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gPBindingNavigator.Size = new System.Drawing.Size(1020, 31);
            this.gPBindingNavigator.TabIndex = 0;
            this.gPBindingNavigator.Text = "bindingNavigator1";
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
            // gPBindingNavigatorSaveItem
            // 
            this.gPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gPBindingNavigatorSaveItem.Image")));
            this.gPBindingNavigatorSaveItem.Name = "gPBindingNavigatorSaveItem";
            this.gPBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.gPBindingNavigatorSaveItem.Text = "Guardar datos";
            this.gPBindingNavigatorSaveItem.Click += new System.EventHandler(this.gPBindingNavigatorSaveItem_Click);
            // 
            // descGPTextBox
            // 
            this.descGPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource1, "DescGP", true));
            this.descGPTextBox.Location = new System.Drawing.Point(116, 73);
            this.descGPTextBox.Name = "descGPTextBox";
            this.descGPTextBox.Size = new System.Drawing.Size(139, 22);
            this.descGPTextBox.TabIndex = 2;
            this.descGPTextBox.TextChanged += new System.EventHandler(this.descGPTextBox_TextChanged);
            // 
            // temporadaTextBox
            // 
            this.temporadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource1, "Temporada", true));
            this.temporadaTextBox.Location = new System.Drawing.Point(116, 114);
            this.temporadaTextBox.Name = "temporadaTextBox";
            this.temporadaTextBox.Size = new System.Drawing.Size(139, 22);
            this.temporadaTextBox.TabIndex = 4;
            // 
            // dataGPDateTimePicker
            // 
            this.dataGPDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gPBindingSource1, "DataGP", true));
            this.dataGPDateTimePicker.Location = new System.Drawing.Point(116, 162);
            this.dataGPDateTimePicker.Name = "dataGPDateTimePicker";
            this.dataGPDateTimePicker.Size = new System.Drawing.Size(256, 22);
            this.dataGPDateTimePicker.TabIndex = 6;
            // 
            // circuitsBindingSource
            // 
            this.circuitsBindingSource.DataMember = "Circuits";
            this.circuitsBindingSource.DataSource = this.f1_CLS_Leandro;
            // 
            // circuitComboBox
            // 
            this.circuitComboBox.DataSource = this.circuitsBindingSource;
            this.circuitComboBox.DisplayMember = "Circuit";
            this.circuitComboBox.FormattingEnabled = true;
            this.circuitComboBox.Location = new System.Drawing.Point(590, 66);
            this.circuitComboBox.Name = "circuitComboBox";
            this.circuitComboBox.Size = new System.Drawing.Size(339, 24);
            this.circuitComboBox.TabIndex = 8;
            this.circuitComboBox.ValueMember = "idCircuit";
            this.circuitComboBox.SelectedValueChanged += new System.EventHandler(this.circuitComboBox_SelectedValueChanged);
            // 
            // DatosGP_circuit
            // 
            this.DatosGP_circuit.AllowUserToAddRows = false;
            this.DatosGP_circuit.AllowUserToDeleteRows = false;
            this.DatosGP_circuit.AutoGenerateColumns = false;
            this.DatosGP_circuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosGP_circuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGPDataGridViewTextBoxColumn,
            this.descGPDataGridViewTextBoxColumn,
            this.temporadaDataGridViewTextBoxColumn,
            this.dataGPDataGridViewTextBoxColumn,
            this.idCircuitDataGridViewTextBoxColumn,
            this.Circuit});
            this.DatosGP_circuit.DataSource = this.gPBindingSource1;
            this.DatosGP_circuit.Location = new System.Drawing.Point(28, 245);
            this.DatosGP_circuit.Name = "DatosGP_circuit";
            this.DatosGP_circuit.ReadOnly = true;
            this.DatosGP_circuit.RowHeadersWidth = 51;
            this.DatosGP_circuit.RowTemplate.Height = 24;
            this.DatosGP_circuit.Size = new System.Drawing.Size(961, 193);
            this.DatosGP_circuit.TabIndex = 9;
            this.DatosGP_circuit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // f1_CLS_Leandro1
            // 
            this.f1_CLS_Leandro1.DataSetName = "F1_CLS_Leandro";
            this.f1_CLS_Leandro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // gPBindingSource1
            // 
            this.gPBindingSource1.DataMember = "GP";
            this.gPBindingSource1.DataSource = this.f1_CLS_Leandro;
            // 
            // idCircuitTextBox
            // 
            this.idCircuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource1, "idCircuit", true));
            this.idCircuitTextBox.Location = new System.Drawing.Point(600, 66);
            this.idCircuitTextBox.Name = "idCircuitTextBox";
            this.idCircuitTextBox.Size = new System.Drawing.Size(10, 22);
            this.idCircuitTextBox.TabIndex = 11;
            this.idCircuitTextBox.TextChanged += new System.EventHandler(this.idCircuitTextBox_TextChanged);
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
            // descGPDataGridViewTextBoxColumn
            // 
            this.descGPDataGridViewTextBoxColumn.DataPropertyName = "DescGP";
            this.descGPDataGridViewTextBoxColumn.HeaderText = "DescGP";
            this.descGPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descGPDataGridViewTextBoxColumn.Name = "descGPDataGridViewTextBoxColumn";
            this.descGPDataGridViewTextBoxColumn.ReadOnly = true;
            this.descGPDataGridViewTextBoxColumn.Width = 125;
            // 
            // temporadaDataGridViewTextBoxColumn
            // 
            this.temporadaDataGridViewTextBoxColumn.DataPropertyName = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.HeaderText = "Temporada";
            this.temporadaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temporadaDataGridViewTextBoxColumn.Name = "temporadaDataGridViewTextBoxColumn";
            this.temporadaDataGridViewTextBoxColumn.ReadOnly = true;
            this.temporadaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGPDataGridViewTextBoxColumn
            // 
            this.dataGPDataGridViewTextBoxColumn.DataPropertyName = "DataGP";
            this.dataGPDataGridViewTextBoxColumn.HeaderText = "DataGP";
            this.dataGPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataGPDataGridViewTextBoxColumn.Name = "dataGPDataGridViewTextBoxColumn";
            this.dataGPDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataGPDataGridViewTextBoxColumn.Width = 125;
            // 
            // idCircuitDataGridViewTextBoxColumn
            // 
            this.idCircuitDataGridViewTextBoxColumn.DataPropertyName = "idCircuit";
            this.idCircuitDataGridViewTextBoxColumn.HeaderText = "idCircuit";
            this.idCircuitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCircuitDataGridViewTextBoxColumn.Name = "idCircuitDataGridViewTextBoxColumn";
            this.idCircuitDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCircuitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCircuitDataGridViewTextBoxColumn.Width = 125;
            // 
            // Circuit
            // 
            this.Circuit.HeaderText = "Circuit";
            this.Circuit.MinimumWidth = 6;
            this.Circuit.Name = "Circuit";
            this.Circuit.ReadOnly = true;
            this.Circuit.Width = 125;
            // 
            // frm_mantenimientoFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 458);
            this.Controls.Add(this.DatosGP_circuit);
            this.Controls.Add(circuitLabel);
            this.Controls.Add(this.circuitComboBox);
            this.Controls.Add(dataGPLabel);
            this.Controls.Add(this.dataGPDateTimePicker);
            this.Controls.Add(temporadaLabel);
            this.Controls.Add(this.temporadaTextBox);
            this.Controls.Add(descGPLabel);
            this.Controls.Add(this.descGPTextBox);
            this.Controls.Add(this.gPBindingNavigator);
            this.Controls.Add(this.idCircuitTextBox);
            this.Name = "frm_mantenimientoFK";
            this.Text = "3";
            this.Load += new System.EventHandler(this.frm_mantenimientoFK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingNavigator)).EndInit();
            this.gPBindingNavigator.ResumeLayout(false);
            this.gPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosGP_circuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private F1_CLS_Leandro f1_CLS_Leandro;
        private System.Windows.Forms.BindingSource gPBindingSource;
        private F1_CLS_LeandroTableAdapters.GPTableAdapter gPTableAdapter;
        private F1_CLS_LeandroTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gPBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gPBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descGPTextBox;
        private F1_CLS_LeandroTableAdapters.CircuitsTableAdapter circuitsTableAdapter;
        private System.Windows.Forms.TextBox temporadaTextBox;
        private System.Windows.Forms.DateTimePicker dataGPDateTimePicker;
        private System.Windows.Forms.BindingSource circuitsBindingSource;
        private System.Windows.Forms.ComboBox circuitComboBox;
        private System.Windows.Forms.DataGridView DatosGP_circuit;
        private F1_CLS_Leandro f1_CLS_Leandro1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource gPBindingSource1;
        private System.Windows.Forms.TextBox idCircuitTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descGPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCircuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Circuit;
    }
}