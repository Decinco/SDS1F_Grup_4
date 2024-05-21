
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.f1DataSet_CLSMugueta1 = new CLS_Daniel_Mugueta.F1DataSet_CLSMugueta();
            this.BSPilots = new System.Windows.Forms.BindingSource(this.components);
            this.pilotsTableAdapter = new CLS_Daniel_Mugueta.F1DataSet_CLSMuguetaTableAdapters.PilotsTableAdapter();
            this.idPilotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEscuderiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntsCarnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dorsalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSEscuderies = new System.Windows.Forms.BindingSource(this.components);
            this.escuderiesTableAdapter = new CLS_Daniel_Mugueta.F1DataSet_CLSMuguetaTableAdapters.EscuderiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet_CLSMugueta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPilots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEscuderies)).BeginInit();
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 22);
            this.textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 22);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 22);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 15;
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(444, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // f1DataSet_CLSMugueta1
            // 
            this.f1DataSet_CLSMugueta1.DataSetName = "F1DataSet_CLSMugueta";
            this.f1DataSet_CLSMugueta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSPilots
            // 
            this.BSPilots.DataMember = "Pilots";
            this.BSPilots.DataSource = this.f1DataSet_CLSMugueta1;
            // 
            // pilotsTableAdapter
            // 
            this.pilotsTableAdapter.ClearBeforeFill = true;
            // 
            // idPilotDataGridViewTextBoxColumn
            // 
            this.idPilotDataGridViewTextBoxColumn.DataPropertyName = "idPilot";
            this.idPilotDataGridViewTextBoxColumn.HeaderText = "idPilot";
            this.idPilotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPilotDataGridViewTextBoxColumn.Name = "idPilotDataGridViewTextBoxColumn";
            this.idPilotDataGridViewTextBoxColumn.ReadOnly = true;
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
            // BSEscuderies
            // 
            this.BSEscuderies.DataMember = "Escuderies";
            this.BSEscuderies.DataSource = this.f1DataSet_CLSMugueta1;
            // 
            // escuderiesTableAdapter
            // 
            this.escuderiesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMantenimientoFK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMantenimientoFK";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMantenimientoFK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1DataSet_CLSMugueta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSPilots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSEscuderies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private F1DataSet_CLSMugueta f1DataSet_CLSMugueta1;
        private System.Windows.Forms.BindingSource BSPilots;
        private F1DataSet_CLSMuguetaTableAdapters.PilotsTableAdapter pilotsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPilotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEscuderiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntsCarnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dorsalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BSEscuderies;
        private F1DataSet_CLSMuguetaTableAdapters.EscuderiesTableAdapter escuderiesTableAdapter;
    }
}