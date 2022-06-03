
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
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(336, 59);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbdesc
            // 
            this.tbdesc.Location = new System.Drawing.Point(336, 98);
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(100, 20);
            this.tbdesc.TabIndex = 2;
            // 
            // tbprecio
            // 
            this.tbprecio.Location = new System.Drawing.Point(336, 145);
            this.tbprecio.Name = "tbprecio";
            this.tbprecio.Size = new System.Drawing.Size(100, 20);
            this.tbprecio.TabIndex = 3;
            // 
            // tbduracion
            // 
            this.tbduracion.Location = new System.Drawing.Point(336, 184);
            this.tbduracion.Name = "tbduracion";
            this.tbduracion.Size = new System.Drawing.Size(100, 20);
            this.tbduracion.TabIndex = 4;
            // 
            // FormDatosBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}