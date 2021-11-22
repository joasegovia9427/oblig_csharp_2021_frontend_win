
namespace oblig_csharp_2021_frontend_win
{
    partial class ProcsMasivos
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
            this.output = new System.Windows.Forms.Label();
            this.labelOutPutMessage = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiarBaseDatos = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonInicializarBaseDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(14, 412);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(43, 13);
            this.output.TabIndex = 39;
            this.output.Text = "OutPut:";
            // 
            // labelOutPutMessage
            // 
            this.labelOutPutMessage.AutoSize = true;
            this.labelOutPutMessage.Location = new System.Drawing.Point(63, 412);
            this.labelOutPutMessage.Name = "labelOutPutMessage";
            this.labelOutPutMessage.Size = new System.Drawing.Size(10, 13);
            this.labelOutPutMessage.TabIndex = 38;
            this.labelOutPutMessage.Text = ".";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(280, 25);
            this.labelTitulo.TabIndex = 37;
            this.labelTitulo.Text = "Procesos Masivos de Datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(14, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(924, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "____________________________________________________________________________\r\n";
            // 
            // buttonLimpiarBaseDatos
            // 
            this.buttonLimpiarBaseDatos.BackColor = System.Drawing.Color.Red;
            this.buttonLimpiarBaseDatos.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonLimpiarBaseDatos.Location = new System.Drawing.Point(245, 85);
            this.buttonLimpiarBaseDatos.Name = "buttonLimpiarBaseDatos";
            this.buttonLimpiarBaseDatos.Size = new System.Drawing.Size(152, 23);
            this.buttonLimpiarBaseDatos.TabIndex = 46;
            this.buttonLimpiarBaseDatos.Text = "Limpiar Base de Datos";
            this.buttonLimpiarBaseDatos.UseVisualStyleBackColor = false;
            this.buttonLimpiarBaseDatos.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(484, 85);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(152, 23);
            this.buttonConfirmar.TabIndex = 47;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Visible = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonInicializarBaseDatos
            // 
            this.buttonInicializarBaseDatos.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonInicializarBaseDatos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonInicializarBaseDatos.Location = new System.Drawing.Point(19, 85);
            this.buttonInicializarBaseDatos.Name = "buttonInicializarBaseDatos";
            this.buttonInicializarBaseDatos.Size = new System.Drawing.Size(152, 23);
            this.buttonInicializarBaseDatos.TabIndex = 48;
            this.buttonInicializarBaseDatos.Text = "Inicializar Base de Datos";
            this.buttonInicializarBaseDatos.UseVisualStyleBackColor = false;
            this.buttonInicializarBaseDatos.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // ProcsMasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonInicializarBaseDatos);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonLimpiarBaseDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.output);
            this.Controls.Add(this.labelOutPutMessage);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcsMasivos";
            this.Text = "ProcsMasivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label output;
        public System.Windows.Forms.Label labelOutPutMessage;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiarBaseDatos;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonInicializarBaseDatos;
    }
}