
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oracle));
            System.Windows.Forms.Label descGPLabel;
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
            this.descGPComboBox = new System.Windows.Forms.ComboBox();
            this.Resultados = new System.Windows.Forms.Button();
            this.Ganador = new System.Windows.Forms.Button();
            this.pilotsTableAdapter = new CLS_Leandro_Varas.F1_CLS_LeandroTableAdapters.PilotsTableAdapter();
            this.Nom_ganador = new System.Windows.Forms.TextBox();
            this.pilotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            descGPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingNavigator)).BeginInit();
            this.gPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tableAdapterManager.CircuitsTableAdapter = null;
            this.tableAdapterManager.ClassificacioGPTableAdapter = null;
            this.tableAdapterManager.DetallsIncidenciesTableAdapter = null;
            this.tableAdapterManager.EscuderiesTableAdapter = null;
            this.tableAdapterManager.GPTableAdapter = this.gPTableAdapter;
            this.tableAdapterManager.IncidenciesTableAdapter = null;
            this.tableAdapterManager.PilotsTableAdapter = this.pilotsTableAdapter;
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
            this.gPBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.gPBindingNavigator.TabIndex = 1;
            this.gPBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
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
            // descGPLabel
            // 
            descGPLabel.AutoSize = true;
            descGPLabel.Location = new System.Drawing.Point(191, 45);
            descGPLabel.Name = "descGPLabel";
            descGPLabel.Size = new System.Drawing.Size(84, 17);
            descGPLabel.TabIndex = 2;
            descGPLabel.Text = "Gran Premi:";
            descGPLabel.Click += new System.EventHandler(this.descGPLabel_Click);
            // 
            // descGPComboBox
            // 
            this.descGPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gPBindingSource, "DescGP", true));
            this.descGPComboBox.FormattingEnabled = true;
            this.descGPComboBox.Location = new System.Drawing.Point(194, 65);
            this.descGPComboBox.Name = "descGPComboBox";
            this.descGPComboBox.Size = new System.Drawing.Size(121, 24);
            this.descGPComboBox.TabIndex = 3;
            this.descGPComboBox.SelectedIndexChanged += new System.EventHandler(this.descGPComboBox_SelectedIndexChanged);
            // 
            // Resultados
            // 
            this.Resultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultados.Location = new System.Drawing.Point(378, 65);
            this.Resultados.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(121, 23);
            this.Resultados.TabIndex = 4;
            this.Resultados.Text = "Resultats GP";
            this.Resultados.UseVisualStyleBackColor = false;
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
            // pilotsTableAdapter
            // 
            this.pilotsTableAdapter.ClearBeforeFill = true;
            // 
            // Nom_ganador
            // 
            this.Nom_ganador.Location = new System.Drawing.Point(215, 113);
            this.Nom_ganador.Name = "Nom_ganador";
            this.Nom_ganador.ReadOnly = true;
            this.Nom_ganador.Size = new System.Drawing.Size(100, 22);
            this.Nom_ganador.TabIndex = 7;
            // 
            // pilotsBindingSource
            // 
            this.pilotsBindingSource.DataMember = "Pilots";
            this.pilotsBindingSource.DataSource = this.f1_CLS_Leandro;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 199);
            this.dataGridView1.TabIndex = 8;
            // 
            // oracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Nom_ganador);
            this.Controls.Add(this.Ganador);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(descGPLabel);
            this.Controls.Add(this.descGPComboBox);
            this.Controls.Add(this.gPBindingNavigator);
            this.Name = "oracle";
            this.Text = "oracle";
            this.Load += new System.EventHandler(this.oracle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1_CLS_Leandro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPBindingNavigator)).EndInit();
            this.gPBindingNavigator.ResumeLayout(false);
            this.gPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox descGPComboBox;
        private F1_CLS_LeandroTableAdapters.PilotsTableAdapter pilotsTableAdapter;
        private System.Windows.Forms.Button Resultados;
        private System.Windows.Forms.Button Ganador;
        private System.Windows.Forms.TextBox Nom_ganador;
        private System.Windows.Forms.BindingSource pilotsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}