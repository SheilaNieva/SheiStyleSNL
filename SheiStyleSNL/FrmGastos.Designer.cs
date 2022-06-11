
namespace SheiStyleSNL
{
    partial class FrmGastos
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
            this.lblGastos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grafGastos = new ScottPlot.FormsPlot();
            this.rjGastos = new SheiStyleSNL.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Location = new System.Drawing.Point(610, 206);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(0, 13);
            this.lblGastos.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hasta el momento,\r\nnuestro gastos son:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grafGastos
            // 
            this.grafGastos.Location = new System.Drawing.Point(109, 111);
            this.grafGastos.Name = "grafGastos";
            this.grafGastos.Size = new System.Drawing.Size(400, 300);
            this.grafGastos.TabIndex = 22;
            // 
            // rjGastos
            // 
            this.rjGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjGastos.FlatAppearance.BorderSize = 0;
            this.rjGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjGastos.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjGastos.ForeColor = System.Drawing.Color.White;
            this.rjGastos.Location = new System.Drawing.Point(78, 40);
            this.rjGastos.Name = "rjGastos";
            this.rjGastos.Size = new System.Drawing.Size(511, 65);
            this.rjGastos.TabIndex = 20;
            this.rjGastos.Text = "Gastos";
            this.rjGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjGastos.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(622, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(780, 411);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grafGastos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGastos";
            this.Text = "FrmGastos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label label1;
        private ScottPlot.FormsPlot grafGastos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton rjGastos;
    }
}