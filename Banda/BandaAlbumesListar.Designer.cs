
namespace oblig_csharp_2021_frontend_win.Banda
{
    partial class BandaAlbumesListar
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
            this.textBoxSubElementoID = new System.Windows.Forms.TextBox();
            this.labelSubElementoID = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.textBoxBuscarPorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTituloDetalle = new System.Windows.Forms.Label();
            this.labelBuscarPorID = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.buttonRefrescarLista = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.labelOutPutMessage = new System.Windows.Forms.Label();
            this.labelTituloLista = new System.Windows.Forms.Label();
            this.buttonPageLast = new System.Windows.Forms.Button();
            this.buttonPageFirst = new System.Windows.Forms.Button();
            this.buttonPageNext = new System.Windows.Forms.Button();
            this.buttonPagePrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSubElementoID
            // 
            this.textBoxSubElementoID.Location = new System.Drawing.Point(116, 280);
            this.textBoxSubElementoID.Name = "textBoxSubElementoID";
            this.textBoxSubElementoID.Size = new System.Drawing.Size(75, 20);
            this.textBoxSubElementoID.TabIndex = 70;
            this.textBoxSubElementoID.Visible = false;
            // 
            // labelSubElementoID
            // 
            this.labelSubElementoID.AutoSize = true;
            this.labelSubElementoID.Location = new System.Drawing.Point(14, 284);
            this.labelSubElementoID.Name = "labelSubElementoID";
            this.labelSubElementoID.Size = new System.Drawing.Size(76, 13);
            this.labelSubElementoID.TabIndex = 69;
            this.labelSubElementoID.Text = "ID de Albumes";
            this.labelSubElementoID.Visible = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(412, 279);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(185, 23);
            this.buttonEliminar.TabIndex = 68;
            this.buttonEliminar.Text = "Eliminar asociación con banda";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Visible = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(209, 279);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(185, 23);
            this.buttonInsertar.TabIndex = 67;
            this.buttonInsertar.Text = "Insertar asociación con banda";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Visible = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // textBoxBuscarPorID
            // 
            this.textBoxBuscarPorID.Location = new System.Drawing.Point(150, 44);
            this.textBoxBuscarPorID.Name = "textBoxBuscarPorID";
            this.textBoxBuscarPorID.Size = new System.Drawing.Size(75, 20);
            this.textBoxBuscarPorID.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(14, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(924, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "____________________________________________________________________________\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(20, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(924, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "____________________________________________________________________________\r\n";
            // 
            // labelTituloDetalle
            // 
            this.labelTituloDetalle.AutoSize = true;
            this.labelTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloDetalle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTituloDetalle.Location = new System.Drawing.Point(12, 244);
            this.labelTituloDetalle.Name = "labelTituloDetalle";
            this.labelTituloDetalle.Size = new System.Drawing.Size(272, 25);
            this.labelTituloDetalle.TabIndex = 63;
            this.labelTituloDetalle.Text = "Agregar / Eliminar Albumes";
            this.labelTituloDetalle.Visible = false;
            // 
            // labelBuscarPorID
            // 
            this.labelBuscarPorID.AutoSize = true;
            this.labelBuscarPorID.Location = new System.Drawing.Point(12, 48);
            this.labelBuscarPorID.Name = "labelBuscarPorID";
            this.labelBuscarPorID.Size = new System.Drawing.Size(122, 13);
            this.labelBuscarPorID.TabIndex = 62;
            this.labelBuscarPorID.Text = "Buscar por Id de Banda:";
            // 
            // listView
            // 
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(17, 74);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(950, 131);
            this.listView.TabIndex = 61;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // buttonRefrescarLista
            // 
            this.buttonRefrescarLista.Location = new System.Drawing.Point(345, 43);
            this.buttonRefrescarLista.Name = "buttonRefrescarLista";
            this.buttonRefrescarLista.Size = new System.Drawing.Size(185, 23);
            this.buttonRefrescarLista.TabIndex = 60;
            this.buttonRefrescarLista.Text = "Cargar albumes de la banda";
            this.buttonRefrescarLista.UseVisualStyleBackColor = true;
            this.buttonRefrescarLista.Click += new System.EventHandler(this.buttonBuscarPorID_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(14, 412);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(43, 13);
            this.output.TabIndex = 59;
            this.output.Text = "OutPut:";
            // 
            // labelOutPutMessage
            // 
            this.labelOutPutMessage.AutoSize = true;
            this.labelOutPutMessage.Location = new System.Drawing.Point(63, 412);
            this.labelOutPutMessage.Name = "labelOutPutMessage";
            this.labelOutPutMessage.Size = new System.Drawing.Size(10, 13);
            this.labelOutPutMessage.TabIndex = 58;
            this.labelOutPutMessage.Text = ".";
            // 
            // labelTituloLista
            // 
            this.labelTituloLista.AutoSize = true;
            this.labelTituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloLista.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTituloLista.Location = new System.Drawing.Point(12, 9);
            this.labelTituloLista.Name = "labelTituloLista";
            this.labelTituloLista.Size = new System.Drawing.Size(310, 25);
            this.labelTituloLista.TabIndex = 57;
            this.labelTituloLista.Text = "Listado de Albumes de Bandas";
            // 
            // buttonPageLast
            // 
            this.buttonPageLast.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PageLast;
            this.buttonPageLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageLast.Location = new System.Drawing.Point(309, 43);
            this.buttonPageLast.Name = "buttonPageLast";
            this.buttonPageLast.Size = new System.Drawing.Size(20, 23);
            this.buttonPageLast.TabIndex = 74;
            this.buttonPageLast.UseVisualStyleBackColor = true;
            this.buttonPageLast.Click += new System.EventHandler(this.buttonPageLast_Click);
            // 
            // buttonPageFirst
            // 
            this.buttonPageFirst.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PageFirst;
            this.buttonPageFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageFirst.Location = new System.Drawing.Point(231, 43);
            this.buttonPageFirst.Name = "buttonPageFirst";
            this.buttonPageFirst.Size = new System.Drawing.Size(20, 23);
            this.buttonPageFirst.TabIndex = 73;
            this.buttonPageFirst.UseVisualStyleBackColor = true;
            this.buttonPageFirst.Click += new System.EventHandler(this.buttonPageFirst_Click);
            // 
            // buttonPageNext
            // 
            this.buttonPageNext.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PageNext;
            this.buttonPageNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageNext.Location = new System.Drawing.Point(283, 43);
            this.buttonPageNext.Name = "buttonPageNext";
            this.buttonPageNext.Size = new System.Drawing.Size(20, 23);
            this.buttonPageNext.TabIndex = 72;
            this.buttonPageNext.UseVisualStyleBackColor = true;
            this.buttonPageNext.Click += new System.EventHandler(this.buttonPageNext_Click);
            // 
            // buttonPagePrevious
            // 
            this.buttonPagePrevious.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PagePrevious;
            this.buttonPagePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPagePrevious.Location = new System.Drawing.Point(257, 43);
            this.buttonPagePrevious.Name = "buttonPagePrevious";
            this.buttonPagePrevious.Size = new System.Drawing.Size(20, 23);
            this.buttonPagePrevious.TabIndex = 71;
            this.buttonPagePrevious.UseVisualStyleBackColor = true;
            this.buttonPagePrevious.Click += new System.EventHandler(this.buttonPagePrevious_Click);
            // 
            // BandaAlbumesListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.buttonPageLast);
            this.Controls.Add(this.buttonPageFirst);
            this.Controls.Add(this.buttonPageNext);
            this.Controls.Add(this.buttonPagePrevious);
            this.Controls.Add(this.textBoxSubElementoID);
            this.Controls.Add(this.labelSubElementoID);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.textBoxBuscarPorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTituloDetalle);
            this.Controls.Add(this.labelBuscarPorID);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonRefrescarLista);
            this.Controls.Add(this.output);
            this.Controls.Add(this.labelOutPutMessage);
            this.Controls.Add(this.labelTituloLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BandaAlbumesListar";
            this.Text = "BandaAlbumesListar";
            this.Load += new System.EventHandler(this.BandaAlbumesListar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubElementoID;
        private System.Windows.Forms.Label labelSubElementoID;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.TextBox textBoxBuscarPorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTituloDetalle;
        private System.Windows.Forms.Label labelBuscarPorID;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button buttonRefrescarLista;
        public System.Windows.Forms.Label output;
        public System.Windows.Forms.Label labelOutPutMessage;
        private System.Windows.Forms.Label labelTituloLista;
        private System.Windows.Forms.Button buttonPageLast;
        private System.Windows.Forms.Button buttonPageFirst;
        private System.Windows.Forms.Button buttonPageNext;
        private System.Windows.Forms.Button buttonPagePrevious;
    }
}