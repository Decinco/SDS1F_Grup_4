﻿
namespace SDS1F_Grup_4
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informaciónF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuitosYCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilPilotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónF1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informaciónF1ToolStripMenuItem
            // 
            this.informaciónF1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuitosYCarrerasToolStripMenuItem,
            this.clasificaciónToolStripMenuItem,
            this.perfilPilotosToolStripMenuItem});
            this.informaciónF1ToolStripMenuItem.Name = "informaciónF1ToolStripMenuItem";
            this.informaciónF1ToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.informaciónF1ToolStripMenuItem.Text = "Información F1";
            // 
            // circuitosYCarrerasToolStripMenuItem
            // 
            this.circuitosYCarrerasToolStripMenuItem.Name = "circuitosYCarrerasToolStripMenuItem";
            this.circuitosYCarrerasToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.circuitosYCarrerasToolStripMenuItem.Text = "Circuitos y Carreras";
            this.circuitosYCarrerasToolStripMenuItem.Click += new System.EventHandler(this.circuitosYCarrerasToolStripMenuItem_Click);
            // 
            // clasificaciónToolStripMenuItem
            // 
            this.clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            this.clasificaciónToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.clasificaciónToolStripMenuItem.Text = "Clasificación";
            this.clasificaciónToolStripMenuItem.Click += new System.EventHandler(this.clasificaciónToolStripMenuItem_Click);
            // 
            // perfilPilotosToolStripMenuItem
            // 
            this.perfilPilotosToolStripMenuItem.Name = "perfilPilotosToolStripMenuItem";
            this.perfilPilotosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.perfilPilotosToolStripMenuItem.Text = "Perfil Pilotos";
            this.perfilPilotosToolStripMenuItem.Click += new System.EventHandler(this.perfilPilotosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 206);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaciónF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuitosYCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilPilotosToolStripMenuItem;
    }
}

