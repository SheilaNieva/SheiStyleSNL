
namespace SheiStyleSNL
{
    partial class FormFavoritos
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.rjFavoritos = new SheiStyleSNL.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label1.Location = new System.Drawing.Point(309, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aquí aparecerán los servicios con su % \r\ncorrespondiente según demanda de los cli" +
    "entes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(862, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(31, 43);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 10;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // rjFavoritos
            // 
            this.rjFavoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjFavoritos.FlatAppearance.BorderSize = 0;
            this.rjFavoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjFavoritos.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjFavoritos.ForeColor = System.Drawing.Color.White;
            this.rjFavoritos.Image = global::SheiStyleSNL.Properties.Resources.estrella;
            this.rjFavoritos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjFavoritos.Location = new System.Drawing.Point(174, 33);
            this.rjFavoritos.Name = "rjFavoritos";
            this.rjFavoritos.Size = new System.Drawing.Size(644, 65);
            this.rjFavoritos.TabIndex = 9;
            this.rjFavoritos.Text = "Favoritos";
            this.rjFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjFavoritos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjFavoritos.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(174, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 333);
            this.panel1.TabIndex = 13;
            // 
            // FormFavoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjFavoritos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFavoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFavoritos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAtras;
        private RJButton rjFavoritos;
        private System.Windows.Forms.Panel panel1;
    }
}