
namespace SheiStyleSNL
{
    partial class FormListadoCitasCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListadoCitasCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.rjCitasCliente = new SheiStyleSNL.RJButton();
            this.listCitaClientes = new System.Windows.Forms.ListView();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(861, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(23, 39);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 7;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // rjCitasCliente
            // 
            this.rjCitasCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjCitasCliente.FlatAppearance.BorderSize = 0;
            this.rjCitasCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjCitasCliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjCitasCliente.ForeColor = System.Drawing.Color.White;
            this.rjCitasCliente.Image = global::SheiStyleSNL.Properties.Resources.clientes;
            this.rjCitasCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjCitasCliente.Location = new System.Drawing.Point(166, 29);
            this.rjCitasCliente.Name = "rjCitasCliente";
            this.rjCitasCliente.Size = new System.Drawing.Size(644, 65);
            this.rjCitasCliente.TabIndex = 6;
            this.rjCitasCliente.Text = "Listado citas";
            this.rjCitasCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjCitasCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjCitasCliente.UseVisualStyleBackColor = false;
            // 
            // listCitaClientes
            // 
            this.listCitaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.listCitaClientes.FullRowSelect = true;
            this.listCitaClientes.HideSelection = false;
            this.listCitaClientes.Location = new System.Drawing.Point(152, 197);
            this.listCitaClientes.MultiSelect = false;
            this.listCitaClientes.Name = "listCitaClientes";
            this.listCitaClientes.Size = new System.Drawing.Size(673, 300);
            this.listCitaClientes.TabIndex = 12;
            this.listCitaClientes.UseCompatibleStateImageBehavior = false;
            this.listCitaClientes.View = System.Windows.Forms.View.Details;
            this.listCitaClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listCitaClientes_MouseDoubleClick);
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnEliminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCita.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCita.Location = new System.Drawing.Point(420, 535);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(161, 38);
            this.btnEliminarCita.TabIndex = 21;
            this.btnEliminarCita.Text = "Eliminar cita";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // FormListadoCitasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(968, 622);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.listCitaClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjCitasCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListadoCitasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListadoCitasCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAtras;
        private RJButton rjCitasCliente;
        private System.Windows.Forms.ListView listCitaClientes;
        private System.Windows.Forms.Button btnEliminarCita;
    }
}