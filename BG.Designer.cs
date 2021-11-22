
namespace oblig_csharp_2021_frontend_win
{
    partial class BG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BG));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRan1 = new System.Windows.Forms.Label();
            this.labelRan2 = new System.Windows.Forms.Label();
            this.pictureBoxFlecha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlecha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "© Grupo 3 // 2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UDE, Lic. En Informática, Curso 2021 - Nocturno - Electiva: Nuevas Tech - Docente" +
    ": Ing. Ron, Ariel. ";
            // 
            // labelRan1
            // 
            this.labelRan1.AutoSize = true;
            this.labelRan1.Location = new System.Drawing.Point(12, 381);
            this.labelRan1.Name = "labelRan1";
            this.labelRan1.Size = new System.Drawing.Size(323, 13);
            this.labelRan1.TabIndex = 2;
            this.labelRan1.Text = "Falcón, Gustavo 3.824.439-9 // Garciarena, Sebastian\t5.205.441-7";
            // 
            // labelRan2
            // 
            this.labelRan2.AutoSize = true;
            this.labelRan2.Location = new System.Drawing.Point(12, 397);
            this.labelRan2.Name = "labelRan2";
            this.labelRan2.Size = new System.Drawing.Size(298, 13);
            this.labelRan2.TabIndex = 3;
            this.labelRan2.Text = "Ramos, Nicolas \t5.332-705-3 // Segovia, \tJoaquín\t\t4.739.544-4";
            // 
            // pictureBoxFlecha
            // 
            this.pictureBoxFlecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFlecha.InitialImage = null;
            this.pictureBoxFlecha.Location = new System.Drawing.Point(1, -18);
            this.pictureBoxFlecha.Name = "pictureBoxFlecha";
            this.pictureBoxFlecha.Size = new System.Drawing.Size(65, 66);
            this.pictureBoxFlecha.TabIndex = 4;
            this.pictureBoxFlecha.TabStop = false;
            // 
            // BG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(818, 414);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxFlecha);
            this.Controls.Add(this.labelRan2);
            this.Controls.Add(this.labelRan1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BG";
            this.Load += new System.EventHandler(this.BG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRan1;
        private System.Windows.Forms.Label labelRan2;
        private System.Windows.Forms.PictureBox pictureBoxFlecha;
    }
}