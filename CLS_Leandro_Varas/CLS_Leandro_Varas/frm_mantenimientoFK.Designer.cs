
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mantenimientoFK));
            System.Windows.Forms.Label descGPLabel;
            System.Windows.Forms.Label temporadaLabel;
            System.Windows.Forms.Label dataGPLabel;
            System.Windows.Forms.Label circuitLabel;
            this.f1_CLS_Leandro = new CLS_Leandro_Varas.F1_CLS_Leandro();
            this.gPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.GPTableAdapter();
            this.tableAdapterManager = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.TableAdapterManager();
            this.gPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.descGPTextBox = new System.Windows.Forms.TextBox();
            this.temporadaTextBox = new System.Windows.Forms.TextBox();
            this.dataGPDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.circuitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circuitsTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.CircuitsTableAdapter();
            this.circuitComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f1_CLS_Leandro1 = new CLS_Leandro_Varas.F1_CLS_Leandro();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            descGPLabel = new System.Windows.Forms.Label();
            temporadaLabel = new System.Windows.Forms.Label();
            dataGPLabel = new System.Windows.Forms.Label();
            circuitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingNavigator)).BeginInit();
            this.gPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
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
            this.gPBindingNavigator.Size = new System.Drawing.Size(1020, 27);
            this.gPBindingNavigator.TabIndex = 0;
            this.gPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // gPBindingNavigatorSaveItem
            // 
            this.gPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gPBindingNavigatorSaveItem.Image")));
            this.gPBindingNavigatorSaveItem.Name = "gPBindingNavigatorSaveItem";
            this.gPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.gPBindingNavigatorSaveItem.Text = "Guardar datos";
            this.gPBindingNavigatorSaveItem.Click += new System.EventHandler(this.gPBindingNavigatorSaveItem_Click);
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
            // descGPTextBox
            // 
            this.descGPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource, "DescGP", true));
            this.descGPTextBox.Location = new System.Drawing.Point(116, 73);
            this.descGPTextBox.Name = "descGPTextBox";
            this.descGPTextBox.Size = new System.Drawing.Size(100, 22);
            this.descGPTextBox.TabIndex = 2;
            this.descGPTextBox.TextChanged += new System.EventHandler(this.descGPTextBox_TextChanged);
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
            // temporadaTextBox
            // 
            this.temporadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource, "Temporada", true));
            this.temporadaTextBox.Location = new System.Drawing.Point(116, 114);
            this.temporadaTextBox.Name = "temporadaTextBox";
            this.temporadaTextBox.Size = new System.Drawing.Size(100, 22);
            this.temporadaTextBox.TabIndex = 4;
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
            // dataGPDateTimePicker
            // 
            this.dataGPDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gPBindingSource, "DataGP", true));
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
            // circuitsTableAdapter
            // 
            this.circuitsTableAdapter.ClearBeforeFill = true;
            // 
            // circuitLabel
            // 
            circuitLabel.AutoSize = true;
            circuitLabel.Location = new System.Drawing.Point(533, 72);
            circuitLabel.Name = "circuitLabel";
            circuitLabel.Size = new System.Drawing.Size(51, 17);
            circuitLabel.TabIndex = 7;
            circuitLabel.Text = "Circuit:";
            // 
            // circuitComboBox
            // 
            this.circuitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.circuitsBindingSource, "Circuit", true));
            this.circuitComboBox.FormattingEnabled = true;
            this.circuitComboBox.Location = new System.Drawing.Point(590, 69);
            this.circuitComboBox.Name = "circuitComboBox";
            this.circuitComboBox.Size = new System.Drawing.Size(339, 24);
            this.circuitComboBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 193);
            this.dataGridView1.TabIndex = 9;
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
            // frm_mantenimientoFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(circuitLabel);
            this.Controls.Add(this.circuitComboBox);
            this.Controls.Add(dataGPLabel);
            this.Controls.Add(this.dataGPDateTimePicker);
            this.Controls.Add(temporadaLabel);
            this.Controls.Add(this.temporadaTextBox);
            this.Controls.Add(descGPLabel);
            this.Controls.Add(this.descGPTextBox);
            this.Controls.Add(this.gPBindingNavigator);
            this.Name = "frm_mantenimientoFK";
            this.Text = "frm_mantenimientoFK";
            this.Load += new System.EventHandler(this.frm_mantenimientoFK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingNavigator)).EndInit();
            this.gPBindingNavigator.ResumeLayout(false);
            this.gPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private F1_CLS_Leandro f1_CLS_Leandro1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}