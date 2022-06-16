
namespace SheiStyleSNL
{
    partial class FormNuevoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoPedido));
            this.rjFavoritos = new SheiStyleSNL.RJButton();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rjFavoritos
            // 
            this.rjFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjFavoritos.FlatAppearance.BorderSize = 0;
            this.rjFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjFavoritos.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjFavoritos.ForeColor = System.Drawing.Color.White;
            this.rjFavoritos.Image = global::SheiStyleSNL.Properties.Resources.pedido;
            this.rjFavoritos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjFavoritos.Location = new System.Drawing.Point(97, 25);
            this.rjFavoritos.Name = "rjFavoritos";
            this.rjFavoritos.Size = new System.Drawing.Size(293, 58);
            this.rjFavoritos.TabIndex = 10;
            this.rjFavoritos.Text = "Nuevo pedido";
            this.rjFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjFavoritos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjFavoritos.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(24, 37);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(46, 46);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 11;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pbLogo.Location = new System.Drawing.Point(396, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(92, 90);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción del pedido: (*)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(113, 153);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(277, 96);
            this.tbDescripcion.TabIndex = 15;
            this.tbDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Importe: (*)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(236, 286);
            this.tbImporte.Mask = "999.00";
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(100, 20);
            this.tbImporte.TabIndex = 17;
            this.tbImporte.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "€";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarCliente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCliente.Location = new System.Drawing.Point(210, 343);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(104, 31);
            this.btnActualizarCliente.TabIndex = 19;
            this.btnActualizarCliente.Text = "Pedir";
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // FormNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjFavoritos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton rjFavoritos;
        private System.Windows.Forms.PictureBox btnAtras;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizarCliente;
    }
}