
namespace oblig_csharp_2021_frontend_win
{
    partial class InicioMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioMenuPrincipal));
            this.PanelFrame = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarBandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarIntegrantesDeBandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlbumesDeBandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCancionesDeAlbumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoMusicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFrame
            // 
            this.PanelFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelFrame.AutoScroll = true;
            this.PanelFrame.AutoSize = true;
            this.PanelFrame.BackColor = System.Drawing.Color.Transparent;
            this.PanelFrame.Location = new System.Drawing.Point(0, 27);
            this.PanelFrame.Name = "PanelFrame";
            this.PanelFrame.Size = new System.Drawing.Size(981, 430);
            this.PanelFrame.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bandaToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.cancionToolStripMenuItem,
            this.personaToolStripMenuItem,
            this.generoMusicalToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bandaToolStripMenuItem
            // 
            this.bandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarBandasToolStripMenuItem,
            this.listarIntegrantesDeBandaToolStripMenuItem,
            this.listarAlbumesDeBandaToolStripMenuItem});
            this.bandaToolStripMenuItem.Name = "bandaToolStripMenuItem";
            this.bandaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.bandaToolStripMenuItem.Text = "Bandas";
            // 
            // listarBandasToolStripMenuItem
            // 
            this.listarBandasToolStripMenuItem.Name = "listarBandasToolStripMenuItem";
            this.listarBandasToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.listarBandasToolStripMenuItem.Text = "Listar Bandas";
            this.listarBandasToolStripMenuItem.Click += new System.EventHandler(this.BandaListar_click);
            // 
            // listarIntegrantesDeBandaToolStripMenuItem
            // 
            this.listarIntegrantesDeBandaToolStripMenuItem.Name = "listarIntegrantesDeBandaToolStripMenuItem";
            this.listarIntegrantesDeBandaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.listarIntegrantesDeBandaToolStripMenuItem.Text = "Listar Integrantes de Banda";
            this.listarIntegrantesDeBandaToolStripMenuItem.Click += new System.EventHandler(this.BandaIntegranteListar_click);
            // 
            // listarAlbumesDeBandaToolStripMenuItem
            // 
            this.listarAlbumesDeBandaToolStripMenuItem.Name = "listarAlbumesDeBandaToolStripMenuItem";
            this.listarAlbumesDeBandaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.listarAlbumesDeBandaToolStripMenuItem.Text = "Listar Albumes de Banda";
            this.listarAlbumesDeBandaToolStripMenuItem.Click += new System.EventHandler(this.listarAlbumesDeBandaToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarAlbumToolStripMenuItem,
            this.listarCancionesDeAlbumToolStripMenuItem1});
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.albumToolStripMenuItem.Text = "Albumes";
            // 
            // listarAlbumToolStripMenuItem
            // 
            this.listarAlbumToolStripMenuItem.Name = "listarAlbumToolStripMenuItem";
            this.listarAlbumToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.listarAlbumToolStripMenuItem.Text = "Listar Album";
            this.listarAlbumToolStripMenuItem.Click += new System.EventHandler(this.AlbumListar_click);
            // 
            // listarCancionesDeAlbumToolStripMenuItem1
            // 
            this.listarCancionesDeAlbumToolStripMenuItem1.Name = "listarCancionesDeAlbumToolStripMenuItem1";
            this.listarCancionesDeAlbumToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.listarCancionesDeAlbumToolStripMenuItem1.Text = "Listar Canciones de Album";
            this.listarCancionesDeAlbumToolStripMenuItem1.Click += new System.EventHandler(this.listarCancionesDeAlbumToolStripMenuItem1_Click);
            // 
            // cancionToolStripMenuItem
            // 
            this.cancionToolStripMenuItem.Name = "cancionToolStripMenuItem";
            this.cancionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.cancionToolStripMenuItem.Text = "Canciones";
            this.cancionToolStripMenuItem.Click += new System.EventHandler(this.cancionToolStripMenuItem_Click_1);
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.personaToolStripMenuItem.Text = "Cantantes";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // generoMusicalToolStripMenuItem
            // 
            this.generoMusicalToolStripMenuItem.Name = "generoMusicalToolStripMenuItem";
            this.generoMusicalToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.generoMusicalToolStripMenuItem.Text = "Generos Musicales";
            this.generoMusicalToolStripMenuItem.Click += new System.EventHandler(this.generoMusicalToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.AboutUs_click);
            // 
            // InicioMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 463);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PanelFrame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioMenuPrincipal";
            this.Text = "Sistema de Gestión Musical";
            this.Load += new System.EventHandler(this.InicioMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Panel PanelFrame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarBandasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoMusicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarIntegrantesDeBandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCancionesDeAlbumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarAlbumesDeBandaToolStripMenuItem;
    }
}