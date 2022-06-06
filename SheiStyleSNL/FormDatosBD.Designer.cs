
namespace SheiStyleSNL
{
    partial class FormDatosBD
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.tbprecio = new System.Windows.Forms.TextBox();
            this.tbduracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCorreoE = new System.Windows.Forms.TextBox();
            this.tbTelefonoE = new System.Windows.Forms.TextBox();
            this.tbDireccionE = new System.Windows.Forms.TextBox();
            this.tbNombreE = new System.Windows.Forms.TextBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(624, 58);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbdesc
            // 
            this.tbdesc.Location = new System.Drawing.Point(624, 97);
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(100, 20);
            this.tbdesc.TabIndex = 2;
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(624, 144);
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(100, 20);
            this.tbprecio.TabIndex = 3;
            // 
            // tbduracion
            // 
            this.tbduracion.Location = new System.Drawing.Point(624, 183);
            this.tbduracion.Name = "tbduracion";
            this.tbduracion.Size = new System.Drawing.Size(100, 20);
            this.tbduracion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servicio";
            // 
            // tbCorreoE
            // 
            this.tbCorreoE.Location = new System.Drawing.Point(94, 183);
            this.tbCorreoE.Name = "tbCorreoE";
            this.tbCorreoE.Size = new System.Drawing.Size(100, 20);
            this.tbCorreoE.TabIndex = 9;
            // 
            // tbTelefonoE
            // 
            this.tbTelefonoE.Location = new System.Drawing.Point(94, 144);
            this.tbTelefonoE.Name = "tbTelefonoE";
            this.tbTelefonoE.Size = new System.Drawing.Size(100, 20);
            this.tbTelefonoE.TabIndex = 8;
            // 
            // tbDireccionE
            // 
            this.tbDireccionE.Location = new System.Drawing.Point(94, 97);
            this.tbDireccionE.Name = "tbDireccionE";
            this.tbDireccionE.Size = new System.Drawing.Size(100, 20);
            this.tbDireccionE.TabIndex = 7;
            // 
            // tbNombreE
            // 
            this.tbNombreE.Location = new System.Drawing.Point(94, 58);
            this.tbNombreE.Name = "tbNombreE";
            this.tbNombreE.Size = new System.Drawing.Size(100, 20);
            this.tbNombreE.TabIndex = 6;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(94, 345);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btnEmpresa.TabIndex = 10;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // FormDatosBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.tbCorreoE);
            this.Controls.Add(this.tbTelefonoE);
            this.Controls.Add(this.tbDireccionE);
            this.Controls.Add(this.tbNombreE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbduracion);
            this.Controls.Add(this.tbprecio);
            this.Controls.Add(this.tbdesc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormDatosBD";
            this.Text = "FormDatosBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbdesc;
        private System.Windows.Forms.TextBox tbprecio;
        private System.Windows.Forms.TextBox tbduracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCorreoE;
        private System.Windows.Forms.TextBox tbTelefonoE;
        private System.Windows.Forms.TextBox tbDireccionE;
        private System.Windows.Forms.TextBox tbNombreE;
        private System.Windows.Forms.Button btnEmpresa;
    }
}