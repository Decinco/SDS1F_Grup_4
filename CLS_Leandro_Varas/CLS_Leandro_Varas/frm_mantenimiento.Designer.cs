
namespace CLS_Leandro_Varas
{
    partial class frm_mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mantenimiento));
            this.f1_CLS_Leandro1 = new CLS_Leandro_Varas.F1_CLS_Leandro();
            this.DbCircuits = new System.Windows.Forms.BindingSource(this.components);
            this.CirucitsTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.CircuitsTableAdapter();
            this.tabla_inf_circuits = new System.Windows.Forms.DataGridView();
            this.idCircuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.circuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esquemaCircuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llargadaCircuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitzacioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.img_pistas = new System.Windows.Forms.PictureBox();
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selec_img = new System.Windows.Forms.Button();
            this.tableAdapterManager = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.TableAdapterManager();
            this.esquemaCircuitTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbCircuits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_inf_circuits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_pistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // f1_CLS_Leandro1
            // 
            this.f1_CLS_Leandro1.DataSetName = "F1_CLS_Leandro";
            this.f1_CLS_Leandro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DbCircuits
            // 
            this.DbCircuits.DataMember = "Circuits";
            this.DbCircuits.DataSource = this.f1_CLS_Leandro1;
            // 
            // CirucitsTableAdapter
            // 
            this.CirucitsTableAdapter.ClearBeforeFill = true;
            // 
            // tabla_inf_circuits
            // 
            this.tabla_inf_circuits.AutoGenerateColumns = false;
            this.tabla_inf_circuits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tabla_inf_circuits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tabla_inf_circuits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_inf_circuits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCircuitDataGridViewTextBoxColumn,
            this.circuitDataGridViewTextBoxColumn,
            this.esquemaCircuitDataGridViewTextBoxColumn,
            this.llargadaCircuitDataGridViewTextBoxColumn,
            this.localitzacioDataGridViewTextBoxColumn});
            this.tabla_inf_circuits.DataSource = this.DbCircuits;
            this.tabla_inf_circuits.Location = new System.Drawing.Point(25, 267);
            this.tabla_inf_circuits.Name = "tabla_inf_circuits";
            this.tabla_inf_circuits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tabla_inf_circuits.RowHeadersWidth = 51;
            this.tabla_inf_circuits.RowTemplate.Height = 24;
            this.tabla_inf_circuits.Size = new System.Drawing.Size(798, 301);
            this.tabla_inf_circuits.TabIndex = 3;
            this.tabla_inf_circuits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_inf_circuits_CellClick);
            this.tabla_inf_circuits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_inf_circuits_CellClick);
            // 
            // idCircuitDataGridViewTextBoxColumn
            // 
            this.idCircuitDataGridViewTextBoxColumn.DataPropertyName = "idCircuit";
            this.idCircuitDataGridViewTextBoxColumn.HeaderText = "idCircuit";
            this.idCircuitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCircuitDataGridViewTextBoxColumn.Name = "idCircuitDataGridViewTextBoxColumn";
            this.idCircuitDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCircuitDataGridViewTextBoxColumn.Visible = false;
            this.idCircuitDataGridViewTextBoxColumn.Width = 125;
            // 
            // circuitDataGridViewTextBoxColumn
            // 
            this.circuitDataGridViewTextBoxColumn.DataPropertyName = "Circuit";
            this.circuitDataGridViewTextBoxColumn.HeaderText = "Circuit";
            this.circuitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.circuitDataGridViewTextBoxColumn.Name = "circuitDataGridViewTextBoxColumn";
            this.circuitDataGridViewTextBoxColumn.Width = 125;
            // 
            // esquemaCircuitDataGridViewTextBoxColumn
            // 
            this.esquemaCircuitDataGridViewTextBoxColumn.DataPropertyName = "EsquemaCircuit";
            this.esquemaCircuitDataGridViewTextBoxColumn.HeaderText = "EsquemaCircuit";
            this.esquemaCircuitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.esquemaCircuitDataGridViewTextBoxColumn.Name = "esquemaCircuitDataGridViewTextBoxColumn";
            this.esquemaCircuitDataGridViewTextBoxColumn.Width = 125;
            // 
            // llargadaCircuitDataGridViewTextBoxColumn
            // 
            this.llargadaCircuitDataGridViewTextBoxColumn.DataPropertyName = "LlargadaCircuit";
            this.llargadaCircuitDataGridViewTextBoxColumn.HeaderText = "LlargadaCircuit";
            this.llargadaCircuitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.llargadaCircuitDataGridViewTextBoxColumn.Name = "llargadaCircuitDataGridViewTextBoxColumn";
            this.llargadaCircuitDataGridViewTextBoxColumn.Width = 125;
            // 
            // localitzacioDataGridViewTextBoxColumn
            // 
            this.localitzacioDataGridViewTextBoxColumn.DataPropertyName = "Localitzacio";
            this.localitzacioDataGridViewTextBoxColumn.HeaderText = "Localitzacio";
            this.localitzacioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.localitzacioDataGridViewTextBoxColumn.Name = "localitzacioDataGridViewTextBoxColumn";
            this.localitzacioDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DbCircuits, "Circuit", true));
            this.textBox1.Location = new System.Drawing.Point(139, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Circuit: ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Localització: ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DbCircuits, "Localitzacio", true));
            this.textBox4.Location = new System.Drawing.Point(139, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(284, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(36, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(93, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Largada: ";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DbCircuits, "LlargadaCircuit", true));
            this.textBox6.Location = new System.Drawing.Point(139, 129);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(85, 22);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(46, 193);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(81, 22);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Esquema: ";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // img_pistas
            // 
            this.img_pistas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_pistas.Cursor = System.Windows.Forms.Cursors.Default;
            this.img_pistas.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.DbCircuits, "EsquemaCircuit", true));
            this.img_pistas.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.DbCircuits, "EsquemaCircuit", true));
            this.img_pistas.Location = new System.Drawing.Point(490, 73);
            this.img_pistas.Name = "img_pistas";
            this.img_pistas.Size = new System.Drawing.Size(274, 114);
            this.img_pistas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_pistas.TabIndex = 11;
            this.img_pistas.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.DbCircuits;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(843, 27);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // selec_img
            // 
            this.selec_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selec_img.Location = new System.Drawing.Point(357, 192);
            this.selec_img.Name = "selec_img";
            this.selec_img.Size = new System.Drawing.Size(75, 23);
            this.selec_img.TabIndex = 13;
            this.selec_img.Text = "...";
            this.selec_img.UseVisualStyleBackColor = true;
            this.selec_img.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CircuitsTableAdapter = this.CirucitsTableAdapter;
            this.tableAdapterManager.ClassificacioGPTableAdapter = null;
            this.tableAdapterManager.DetallsIncidenciesTableAdapter = null;
            this.tableAdapterManager.EscuderiesTableAdapter = null;
            this.tableAdapterManager.GPTableAdapter = null;
            this.tableAdapterManager.IncidenciesTableAdapter = null;
            this.tableAdapterManager.PilotsTableAdapter = null;
            this.tableAdapterManager.PuntuacionsTableAdapter = null;
            this.tableAdapterManager.TipusIncidenciaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // esquemaCircuitTextBox
            // 
            this.esquemaCircuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DbCircuits, "EsquemaCircuit", true));
            this.esquemaCircuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.DbCircuits, "EsquemaCircuit", true));
            this.esquemaCircuitTextBox.Location = new System.Drawing.Point(139, 192);
            this.esquemaCircuitTextBox.Name = "esquemaCircuitTextBox";
            this.esquemaCircuitTextBox.Size = new System.Drawing.Size(212, 22);
            this.esquemaCircuitTextBox.TabIndex = 15;
            // 
            // frm_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 588);
            this.Controls.Add(this.esquemaCircuitTextBox);
            this.Controls.Add(this.selec_img);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.img_pistas);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabla_inf_circuits);
            this.Name = "frm_mantenimiento";
            this.Text = "frm_mantenimiento";
            this.Load += new System.EventHandler(this.frm_mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbCircuits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_inf_circuits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_pistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private F1_CLS_Leandro f1_CLS_Leandro1;
        private System.Windows.Forms.BindingSource DbCircuits;
        private F1_CLS_LeandroTableAdapters.CircuitsTableAdapter CirucitsTableAdapter;
        private System.Windows.Forms.DataGridView tabla_inf_circuits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCircuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn circuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esquemaCircuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn llargadaCircuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitzacioDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox img_pistas;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selec_img;
        private F1_CLS_LeandroTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox esquemaCircuitTextBox;
    }
}