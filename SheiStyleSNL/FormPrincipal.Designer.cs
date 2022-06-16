
namespace SheiStyleSNL
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnPedido = new SheiStyleSNL.RJButton();
            this.btnFavoritos = new SheiStyleSNL.RJButton();
            this.btnPrecio = new SheiStyleSNL.RJButton();
            this.btnClientes = new SheiStyleSNL.RJButton();
            this.btnNuevaCita = new SheiStyleSNL.RJButton();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedido
            // 
            this.btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Image = global::SheiStyleSNL.Properties.Resources.pedido;
            this.btnPedido.Location = new System.Drawing.Point(288, 415);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(461, 80);
            this.btnPedido.TabIndex = 8;
            this.btnPedido.Text = "     Nuevo pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedido.UseVisualStyleBackColor = false;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnFavoritos.FlatAppearance.BorderSize = 0;
            this.btnFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavoritos.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritos.ForeColor = System.Drawing.Color.White;
            this.btnFavoritos.Image = global::SheiStyleSNL.Properties.Resources.estrella;
            this.btnFavoritos.Location = new System.Drawing.Point(288, 510);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(461, 80);
            this.btnFavoritos.TabIndex = 7;
            this.btnFavoritos.Text = "     Favoritos";
            this.btnFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavoritos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFavoritos.UseVisualStyleBackColor = false;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // btnPrecio
            // 
            this.btnPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnPrecio.FlatAppearance.BorderSize = 0;
            this.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecio.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecio.ForeColor = System.Drawing.Color.White;
            this.btnPrecio.Image = global::SheiStyleSNL.Properties.Resources.precio;
            this.btnPrecio.Location = new System.Drawing.Point(288, 312);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(461, 80);
            this.btnPrecio.TabIndex = 6;
            this.btnPrecio.Text = "     Precios y servicios";
            this.btnPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecio.UseVisualStyleBackColor = false;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::SheiStyleSNL.Properties.Resources.clientes;
            this.btnClientes.Location = new System.Drawing.Point(288, 206);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(461, 80);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "     Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCita.Image = global::SheiStyleSNL.Properties.Resources.calendario;
            this.btnNuevaCita.Location = new System.Drawing.Point(288, 108);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(461, 80);
            this.btnNuevaCita.TabIndex = 4;
            this.btnNuevaCita.Text = "     Nueva cita";
            this.btnNuevaCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.btnNuevaCita_Click);
            // 
            // pbSalir
            // 
            this.pbSalir.Image = global::SheiStyleSNL.Properties.Resources.icons8_salida_48;
            this.pbSalir.Location = new System.Drawing.Point(892, 580);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(60, 60);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 2;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::SheiStyleSNL.Properties.Resources.icons8_menú_48;
            this.pbMenu.Location = new System.Drawing.Point(892, 23);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(60, 60);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 1;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(105, 103);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnFavoritos);
            this.Controls.Add(this.btnPrecio);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnNuevaCita);
            this.Controls.Add(this.pbSalir);
            this.Controls.Add(this.pbMenu);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pbSalir;
        private RJButton btnNuevaCita;
        private RJButton btnClientes;
        private RJButton btnPrecio;
        private RJButton btnFavoritos;
        private RJButton btnPedido;
    }
}

