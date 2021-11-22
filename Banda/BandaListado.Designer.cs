
namespace oblig_csharp_2021_frontend_win.Banda
{
    partial class BandaListado
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
            this.labelTituloLista = new System.Windows.Forms.Label();
            this.labelOutPutMessage = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.buttonRefrescarLista = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.labelBuscarPorID = new System.Windows.Forms.Label();
            this.labelTituloDetalle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBuscarPorID = new System.Windows.Forms.TextBox();
            this.buttonBuscarPorID = new System.Windows.Forms.Button();
            this.textBoxAtt1 = new System.Windows.Forms.TextBox();
            this.labelAtt1 = new System.Windows.Forms.Label();
            this.labelAtt2 = new System.Windows.Forms.Label();
            this.textBoxAtt4 = new System.Windows.Forms.TextBox();
            this.labelAtt4 = new System.Windows.Forms.Label();
            this.labelAtt3 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxAtt2 = new System.Windows.Forms.TextBox();
            this.textBoxAtt3 = new System.Windows.Forms.ComboBox();
            this.buttonPageLast = new System.Windows.Forms.Button();
            this.buttonPageFirst = new System.Windows.Forms.Button();
            this.buttonPageNext = new System.Windows.Forms.Button();
            this.buttonPagePrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloLista
            // 
            this.labelTituloLista.AutoSize = true;
            this.labelTituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloLista.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTituloLista.Location = new System.Drawing.Point(10, 9);
            this.labelTituloLista.Name = "labelTituloLista";
            this.labelTituloLista.Size = new System.Drawing.Size(191, 25);
            this.labelTituloLista.TabIndex = 2;
            this.labelTituloLista.Text = "Listado de Bandas";
            // 
            // labelOutPutMessage
            // 
            this.labelOutPutMessage.AutoSize = true;
            this.labelOutPutMessage.Location = new System.Drawing.Point(61, 412);
            this.labelOutPutMessage.Name = "labelOutPutMessage";
            this.labelOutPutMessage.Size = new System.Drawing.Size(10, 13);
            this.labelOutPutMessage.TabIndex = 5;
            this.labelOutPutMessage.Text = ".";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(12, 412);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(43, 13);
            this.output.TabIndex = 6;
            this.output.Text = "OutPut:";
            // 
            // buttonRefrescarLista
            // 
            this.buttonRefrescarLista.Location = new System.Drawing.Point(15, 45);
            this.buttonRefrescarLista.Name = "buttonRefrescarLista";
            this.buttonRefrescarLista.Size = new System.Drawing.Size(75, 23);
            this.buttonRefrescarLista.TabIndex = 7;
            this.buttonRefrescarLista.Text = "Refrescar lista";
            this.buttonRefrescarLista.UseVisualStyleBackColor = true;
            this.buttonRefrescarLista.Click += new System.EventHandler(this.buttonRefrescarLista_Click);
            // 
            // listView
            // 
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(15, 74);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(950, 131);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // labelBuscarPorID
            // 
            this.labelBuscarPorID.AutoSize = true;
            this.labelBuscarPorID.Location = new System.Drawing.Point(12, 282);
            this.labelBuscarPorID.Name = "labelBuscarPorID";
            this.labelBuscarPorID.Size = new System.Drawing.Size(75, 13);
            this.labelBuscarPorID.TabIndex = 9;
            this.labelBuscarPorID.Text = "Buscar por ID:";
            // 
            // labelTituloDetalle
            // 
            this.labelTituloDetalle.AutoSize = true;
            this.labelTituloDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloDetalle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTituloDetalle.Location = new System.Drawing.Point(10, 244);
            this.labelTituloDetalle.Name = "labelTituloDetalle";
            this.labelTituloDetalle.Size = new System.Drawing.Size(188, 25);
            this.labelTituloDetalle.TabIndex = 10;
            this.labelTituloDetalle.Text = "Detalle de Bandas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(18, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(924, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "____________________________________________________________________________\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(924, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "____________________________________________________________________________\r\n";
            // 
            // textBoxBuscarPorID
            // 
            this.textBoxBuscarPorID.Location = new System.Drawing.Point(104, 278);
            this.textBoxBuscarPorID.Name = "textBoxBuscarPorID";
            this.textBoxBuscarPorID.Size = new System.Drawing.Size(75, 20);
            this.textBoxBuscarPorID.TabIndex = 13;
            // 
            // buttonBuscarPorID
            // 
            this.buttonBuscarPorID.Location = new System.Drawing.Point(313, 277);
            this.buttonBuscarPorID.Name = "buttonBuscarPorID";
            this.buttonBuscarPorID.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPorID.TabIndex = 14;
            this.buttonBuscarPorID.Text = "Buscar";
            this.buttonBuscarPorID.UseVisualStyleBackColor = true;
            this.buttonBuscarPorID.Click += new System.EventHandler(this.buttonBuscarPorID_Click);
            // 
            // textBoxAtt1
            // 
            this.textBoxAtt1.Enabled = false;
            this.textBoxAtt1.Location = new System.Drawing.Point(104, 328);
            this.textBoxAtt1.Name = "textBoxAtt1";
            this.textBoxAtt1.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtt1.TabIndex = 16;
            this.textBoxAtt1.Visible = false;
            // 
            // labelAtt1
            // 
            this.labelAtt1.AutoSize = true;
            this.labelAtt1.Location = new System.Drawing.Point(12, 332);
            this.labelAtt1.Name = "labelAtt1";
            this.labelAtt1.Size = new System.Drawing.Size(47, 13);
            this.labelAtt1.TabIndex = 15;
            this.labelAtt1.Text = "Nombre:";
            this.labelAtt1.Visible = false;
            // 
            // labelAtt2
            // 
            this.labelAtt2.AutoSize = true;
            this.labelAtt2.Location = new System.Drawing.Point(226, 332);
            this.labelAtt2.Name = "labelAtt2";
            this.labelAtt2.Size = new System.Drawing.Size(130, 13);
            this.labelAtt2.TabIndex = 17;
            this.labelAtt2.Text = "Genero Musical (Nombre):";
            this.labelAtt2.Visible = false;
            // 
            // textBoxAtt4
            // 
            this.textBoxAtt4.Enabled = false;
            this.textBoxAtt4.Location = new System.Drawing.Point(365, 366);
            this.textBoxAtt4.Name = "textBoxAtt4";
            this.textBoxAtt4.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtt4.TabIndex = 24;
            this.textBoxAtt4.Text = "0";
            this.textBoxAtt4.Visible = false;
            // 
            // labelAtt4
            // 
            this.labelAtt4.AutoSize = true;
            this.labelAtt4.Location = new System.Drawing.Point(270, 370);
            this.labelAtt4.Name = "labelAtt4";
            this.labelAtt4.Size = new System.Drawing.Size(86, 13);
            this.labelAtt4.TabIndex = 23;
            this.labelAtt4.Text = "Año Separacion:";
            this.labelAtt4.Visible = false;
            // 
            // labelAtt3
            // 
            this.labelAtt3.AutoSize = true;
            this.labelAtt3.Location = new System.Drawing.Point(12, 370);
            this.labelAtt3.Name = "labelAtt3";
            this.labelAtt3.Size = new System.Drawing.Size(74, 13);
            this.labelAtt3.TabIndex = 21;
            this.labelAtt3.Text = "Año Creacion:";
            this.labelAtt3.Visible = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(411, 277);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 25;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Visible = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(813, 45);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(152, 23);
            this.buttonInsertar.TabIndex = 28;
            this.buttonInsertar.Text = "Insertar Nueva Banda";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(497, 365);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(152, 23);
            this.buttonConfirmar.TabIndex = 29;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Visible = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(514, 277);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 30;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Visible = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxAtt2
            // 
            this.textBoxAtt2.Enabled = false;
            this.textBoxAtt2.Location = new System.Drawing.Point(104, 366);
            this.textBoxAtt2.Name = "textBoxAtt2";
            this.textBoxAtt2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtt2.TabIndex = 31;
            this.textBoxAtt2.Visible = false;
            // 
            // textBoxAtt3
            // 
            this.textBoxAtt3.FormattingEnabled = true;
            this.textBoxAtt3.Location = new System.Drawing.Point(365, 328);
            this.textBoxAtt3.Name = "textBoxAtt3";
            this.textBoxAtt3.Size = new System.Drawing.Size(121, 21);
            this.textBoxAtt3.Sorted = true;
            this.textBoxAtt3.TabIndex = 32;
            this.textBoxAtt3.Visible = false;
            // 
            // buttonPageLast
            // 
            this.buttonPageLast.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PageLast;
            this.buttonPageLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageLast.Location = new System.Drawing.Point(275, 277);
            this.buttonPageLast.Name = "buttonPageLast";
            this.buttonPageLast.Size = new System.Drawing.Size(20, 23);
            this.buttonPageLast.TabIndex = 36;
            this.buttonPageLast.UseVisualStyleBackColor = true;
            this.buttonPageLast.Click += new System.EventHandler(this.buttonPageLast_Click);
            // 
            // buttonPageFirst
            // 
            this.buttonPageFirst.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PageFirst;
            this.buttonPageFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageFirst.Location = new System.Drawing.Point(197, 277);
            this.buttonPageFirst.Name = "buttonPageFirst";
            this.buttonPageFirst.Size = new System.Drawing.Size(20, 23);
            this.buttonPageFirst.TabIndex = 35;
            this.buttonPageFirst.UseVisualStyleBackColor = true;
            this.buttonPageFirst.Click += new System.EventHandler(this.buttonPageFirst_Click);
            // 
            // buttonPageNext
            // 
            this.buttonPageNext.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PageNext;
            this.buttonPageNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPageNext.Location = new System.Drawing.Point(249, 277);
            this.buttonPageNext.Name = "buttonPageNext";
            this.buttonPageNext.Size = new System.Drawing.Size(20, 23);
            this.buttonPageNext.TabIndex = 34;
            this.buttonPageNext.UseVisualStyleBackColor = true;
            this.buttonPageNext.Click += new System.EventHandler(this.buttonPageNext_Click);
            // 
            // buttonPagePrevious
            // 
            this.buttonPagePrevious.BackgroundImage = global::oblig_csharp_2021_frontend_win.Properties.Resources.PagePrevious;
            this.buttonPagePrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPagePrevious.Location = new System.Drawing.Point(223, 277);
            this.buttonPagePrevious.Name = "buttonPagePrevious";
            this.buttonPagePrevious.Size = new System.Drawing.Size(20, 23);
            this.buttonPagePrevious.TabIndex = 33;
            this.buttonPagePrevious.UseVisualStyleBackColor = true;
            this.buttonPagePrevious.Click += new System.EventHandler(this.buttonPagePrevious_Click);
            // 
            // BandaListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPageLast);
            this.Controls.Add(this.buttonPageFirst);
            this.Controls.Add(this.buttonPageNext);
            this.Controls.Add(this.buttonPagePrevious);
            this.Controls.Add(this.textBoxAtt3);
            this.Controls.Add(this.textBoxAtt2);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.textBoxAtt4);
            this.Controls.Add(this.labelAtt4);
            this.Controls.Add(this.labelAtt3);
            this.Controls.Add(this.labelAtt2);
            this.Controls.Add(this.textBoxAtt1);
            this.Controls.Add(this.labelAtt1);
            this.Controls.Add(this.buttonBuscarPorID);
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
            this.Name = "BandaListado";
            this.Text = "Listado de Bandas";
            this.Load += new System.EventHandler(this.CargarLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTituloLista;
        public System.Windows.Forms.Label labelOutPutMessage;
        public System.Windows.Forms.Label output;
        private System.Windows.Forms.Button buttonRefrescarLista;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label labelBuscarPorID;
        private System.Windows.Forms.Label labelTituloDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBuscarPorID;
        private System.Windows.Forms.Button buttonBuscarPorID;
        private System.Windows.Forms.TextBox textBoxAtt1;
        private System.Windows.Forms.Label labelAtt1;
        private System.Windows.Forms.Label labelAtt2;
        private System.Windows.Forms.TextBox textBoxAtt4;
        private System.Windows.Forms.Label labelAtt4;
        private System.Windows.Forms.Label labelAtt3;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxAtt2;
        private System.Windows.Forms.ComboBox textBoxAtt3;
        private System.Windows.Forms.Button buttonPagePrevious;
        private System.Windows.Forms.Button buttonPageNext;
        private System.Windows.Forms.Button buttonPageFirst;
        private System.Windows.Forms.Button buttonPageLast;
    }
}