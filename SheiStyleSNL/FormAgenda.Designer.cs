
namespace SheiStyleSNL
{
    partial class FormAgenda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.rjAgendaCliente = new SheiStyleSNL.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(871, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(40, 42);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 12;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // rjAgendaCliente
            // 
            this.rjAgendaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjAgendaCliente.FlatAppearance.BorderSize = 0;
            this.rjAgendaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjAgendaCliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjAgendaCliente.ForeColor = System.Drawing.Color.White;
            this.rjAgendaCliente.Image = global::SheiStyleSNL.Properties.Resources.calendario;
            this.rjAgendaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjAgendaCliente.Location = new System.Drawing.Point(183, 32);
            this.rjAgendaCliente.Name = "rjAgendaCliente";
            this.rjAgendaCliente.Size = new System.Drawing.Size(644, 65);
            this.rjAgendaCliente.TabIndex = 11;
            this.rjAgendaCliente.Text = "Agenda";
            this.rjAgendaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjAgendaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjAgendaCliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(462, 126);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 16);
            this.lblFecha.TabIndex = 15;
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(294, 183);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowHeadersVisible = false;
            this.dgvAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgenda.Size = new System.Drawing.Size(401, 329);
            this.dgvAgenda.TabIndex = 16;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjAgendaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.Text = "FormAgenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAtras;
        private RJButton rjAgendaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvAgenda;
    }
}