
namespace SDS1F_Grup_4
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danielMuguetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informePerfilPilotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEscuderíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escuderíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisisClasificaciónPorPilotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danielMuguetaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danielMuguetaToolStripMenuItem
            // 
            this.danielMuguetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informePerfilPilotosToolStripMenuItem,
            this.mantenimientoEscuderíasToolStripMenuItem,
            this.análisisClasificaciónPorPilotoToolStripMenuItem});
            this.danielMuguetaToolStripMenuItem.Name = "danielMuguetaToolStripMenuItem";
            this.danielMuguetaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.danielMuguetaToolStripMenuItem.Text = "DanielMugueta";
            // 
            // informePerfilPilotosToolStripMenuItem
            // 
            this.informePerfilPilotosToolStripMenuItem.Name = "informePerfilPilotosToolStripMenuItem";
            this.informePerfilPilotosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.informePerfilPilotosToolStripMenuItem.Text = "Informe Perfil Pilotos";
            this.informePerfilPilotosToolStripMenuItem.Click += new System.EventHandler(this.informePerfilPilotosToolStripMenuItem_Click);
            // 
            // mantenimientoEscuderíasToolStripMenuItem
            // 
            this.mantenimientoEscuderíasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escuderíasToolStripMenuItem,
            this.pilotosToolStripMenuItem});
            this.mantenimientoEscuderíasToolStripMenuItem.Name = "mantenimientoEscuderíasToolStripMenuItem";
            this.mantenimientoEscuderíasToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.mantenimientoEscuderíasToolStripMenuItem.Text = "Mantenimiento";
            // 
            // escuderíasToolStripMenuItem
            // 
            this.escuderíasToolStripMenuItem.Name = "escuderíasToolStripMenuItem";
            this.escuderíasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.escuderíasToolStripMenuItem.Text = "Escuderías";
            this.escuderíasToolStripMenuItem.Click += new System.EventHandler(this.escuderíasToolStripMenuItem_Click);
            // 
            // pilotosToolStripMenuItem
            // 
            this.pilotosToolStripMenuItem.Name = "pilotosToolStripMenuItem";
            this.pilotosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pilotosToolStripMenuItem.Text = "Pilotos";
            this.pilotosToolStripMenuItem.Click += new System.EventHandler(this.pilotosToolStripMenuItem_Click_1);
            // 
            // análisisClasificaciónPorPilotoToolStripMenuItem
            // 
            this.análisisClasificaciónPorPilotoToolStripMenuItem.Name = "análisisClasificaciónPorPilotoToolStripMenuItem";
            this.análisisClasificaciónPorPilotoToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.análisisClasificaciónPorPilotoToolStripMenuItem.Text = "Clasificación por Piloto";
            this.análisisClasificaciónPorPilotoToolStripMenuItem.Click += new System.EventHandler(this.análisisClasificaciónPorPilotoToolStripMenuItem_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 293);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Launcher";
            this.Text = "SDS1F - Grupo 4 - Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danielMuguetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informePerfilPilotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEscuderíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisClasificaciónPorPilotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escuderíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilotosToolStripMenuItem;
    }
}

