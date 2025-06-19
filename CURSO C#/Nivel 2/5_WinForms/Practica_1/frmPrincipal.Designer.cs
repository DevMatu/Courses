namespace Practica_1
{
    partial class frmPrincipal
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
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.lblTexto_1 = new System.Windows.Forms.Label();
            this.lklEtiquetaLink1 = new System.Windows.Forms.LinkLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoton1.Location = new System.Drawing.Point(243, 400);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(90, 30);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "No Tocar...";
            this.btnBoton1.UseVisualStyleBackColor = false;
            this.btnBoton1.Click += new System.EventHandler(this.button1_Click);
            this.btnBoton1.MouseLeave += new System.EventHandler(this.btnBoton1_MouseLeave);
            this.btnBoton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBoton1_MouseMove);
            // 
            // lblTexto_1
            // 
            this.lblTexto_1.AutoSize = true;
            this.lblTexto_1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTexto_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTexto_1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTexto_1.Location = new System.Drawing.Point(191, 10);
            this.lblTexto_1.Name = "lblTexto_1";
            this.lblTexto_1.Size = new System.Drawing.Size(196, 25);
            this.lblTexto_1.TabIndex = 1;
            this.lblTexto_1.Text = "INSERTAR TITULO";
            this.lblTexto_1.MouseLeave += new System.EventHandler(this.lblTexto_1_MouseLeave);
            this.lblTexto_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTexto_1_MouseMove);
            // 
            // lklEtiquetaLink1
            // 
            this.lklEtiquetaLink1.AutoSize = true;
            this.lklEtiquetaLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklEtiquetaLink1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklEtiquetaLink1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.lklEtiquetaLink1.Location = new System.Drawing.Point(13, 10);
            this.lklEtiquetaLink1.Name = "lklEtiquetaLink1";
            this.lklEtiquetaLink1.Size = new System.Drawing.Size(74, 17);
            this.lklEtiquetaLink1.TabIndex = 2;
            this.lklEtiquetaLink1.TabStop = true;
            this.lklEtiquetaLink1.Text = "Ver Imagen";
            this.lklEtiquetaLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklEtiquetaLink1_LinkClicked);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(191, 299);
            this.txtNombre.MaxLength = 42767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(191, 336);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtApellido.Size = new System.Drawing.Size(196, 33);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lklEtiquetaLink1);
            this.Controls.Add(this.lblTexto_1);
            this.Controls.Add(this.btnBoton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Prmera Aplicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Label lblTexto_1;
        private System.Windows.Forms.LinkLabel lklEtiquetaLink1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
    }
}