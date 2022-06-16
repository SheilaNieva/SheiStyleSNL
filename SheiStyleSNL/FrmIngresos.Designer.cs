
namespace SheiStyleSNL
{
    partial class FrmIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grafIngresos = new ScottPlot.FormsPlot();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.rjEditarCliente = new SheiStyleSNL.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(645, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // grafIngresos
            // 
            this.grafIngresos.Location = new System.Drawing.Point(132, 119);
            this.grafIngresos.Name = "grafIngresos";
            this.grafIngresos.Size = new System.Drawing.Size(400, 300);
            this.grafIngresos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hasta el momento,\r\nnuestro ingresos son:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(633, 214);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(35, 13);
            this.lblIngresos.TabIndex = 19;
            this.lblIngresos.Text = "label2";
            // 
            // rjEditarCliente
            // 
            this.rjEditarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjEditarCliente.FlatAppearance.BorderSize = 0;
            this.rjEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjEditarCliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjEditarCliente.ForeColor = System.Drawing.Color.White;
            this.rjEditarCliente.Location = new System.Drawing.Point(101, 48);
            this.rjEditarCliente.Name = "rjEditarCliente";
            this.rjEditarCliente.Size = new System.Drawing.Size(511, 65);
            this.rjEditarCliente.TabIndex = 15;
            this.rjEditarCliente.Text = "Ingresos";
            this.rjEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjEditarCliente.UseVisualStyleBackColor = false;
            // 
            // FrmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafIngresos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjEditarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresos";
            this.Text = "FrmIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton rjEditarCliente;
        private ScottPlot.FormsPlot grafIngresos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngresos;
    }
}