
namespace SheiStyleSNL
{
    partial class FormPrecios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPeluqueria = new System.Windows.Forms.DataGridView();
            this.columnServicioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPeluqueria = new System.Windows.Forms.Label();
            this.lblUnas = new System.Windows.Forms.Label();
            this.dgvUnas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBarberia = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLaser = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCera = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarPrecio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.PictureBox();
            this.rjListadoCliente = new SheiStyleSNL.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarberia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeluqueria
            // 
            this.dgvPeluqueria.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeluqueria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeluqueria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeluqueria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnServicioP,
            this.columnPrecioP});
            this.dgvPeluqueria.Location = new System.Drawing.Point(67, 231);
            this.dgvPeluqueria.Name = "dgvPeluqueria";
            this.dgvPeluqueria.ReadOnly = true;
            this.dgvPeluqueria.RowHeadersVisible = false;
            this.dgvPeluqueria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvPeluqueria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeluqueria.Size = new System.Drawing.Size(204, 212);
            this.dgvPeluqueria.TabIndex = 9;
            // 
            // columnServicioP
            // 
            this.columnServicioP.HeaderText = "Servicio";
            this.columnServicioP.Name = "columnServicioP";
            this.columnServicioP.ReadOnly = true;
            // 
            // columnPrecioP
            // 
            this.columnPrecioP.HeaderText = "Precio";
            this.columnPrecioP.Name = "columnPrecioP";
            this.columnPrecioP.ReadOnly = true;
            // 
            // lblPeluqueria
            // 
            this.lblPeluqueria.AutoSize = true;
            this.lblPeluqueria.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluqueria.Location = new System.Drawing.Point(64, 210);
            this.lblPeluqueria.Name = "lblPeluqueria";
            this.lblPeluqueria.Size = new System.Drawing.Size(87, 18);
            this.lblPeluqueria.TabIndex = 10;
            this.lblPeluqueria.Text = "Peluquería";
            // 
            // lblUnas
            // 
            this.lblUnas.AutoSize = true;
            this.lblUnas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnas.Location = new System.Drawing.Point(373, 171);
            this.lblUnas.Name = "lblUnas";
            this.lblUnas.Size = new System.Drawing.Size(45, 18);
            this.lblUnas.TabIndex = 12;
            this.lblUnas.Text = "Uñas";
            // 
            // dgvUnas
            // 
            this.dgvUnas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvUnas.Location = new System.Drawing.Point(376, 192);
            this.dgvUnas.Name = "dgvUnas";
            this.dgvUnas.ReadOnly = true;
            this.dgvUnas.RowHeadersVisible = false;
            this.dgvUnas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnas.Size = new System.Drawing.Size(204, 122);
            this.dgvUnas.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Barbería";
            // 
            // dgvBarberia
            // 
            this.dgvBarberia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarberia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarberia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarberia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvBarberia.Location = new System.Drawing.Point(376, 371);
            this.dgvBarberia.Name = "dgvBarberia";
            this.dgvBarberia.ReadOnly = true;
            this.dgvBarberia.RowHeadersVisible = false;
            this.dgvBarberia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBarberia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarberia.Size = new System.Drawing.Size(204, 122);
            this.dgvBarberia.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Depilación láser";
            // 
            // dgvLaser
            // 
            this.dgvLaser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLaser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvLaser.Location = new System.Drawing.Point(695, 371);
            this.dgvLaser.Name = "dgvLaser";
            this.dgvLaser.ReadOnly = true;
            this.dgvLaser.RowHeadersVisible = false;
            this.dgvLaser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLaser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaser.Size = new System.Drawing.Size(204, 122);
            this.dgvLaser.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Depilación cera caliente";
            // 
            // dgvCera
            // 
            this.dgvCera.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvCera.Location = new System.Drawing.Point(695, 192);
            this.dgvCera.Name = "dgvCera";
            this.dgvCera.ReadOnly = true;
            this.dgvCera.RowHeadersVisible = false;
            this.dgvCera.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCera.Size = new System.Drawing.Size(204, 122);
            this.dgvCera.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // btnModificarPrecio
            // 
            this.btnModificarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnModificarPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPrecio.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPrecio.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrecio.Location = new System.Drawing.Point(400, 572);
            this.btnModificarPrecio.Name = "btnModificarPrecio";
            this.btnModificarPrecio.Size = new System.Drawing.Size(161, 38);
            this.btnModificarPrecio.TabIndex = 19;
            this.btnModificarPrecio.Text = "Modificar precio";
            this.btnModificarPrecio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(875, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(37, 51);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 7;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // rjListadoCliente
            // 
            this.rjListadoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjListadoCliente.FlatAppearance.BorderSize = 0;
            this.rjListadoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjListadoCliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjListadoCliente.ForeColor = System.Drawing.Color.White;
            this.rjListadoCliente.Image = global::SheiStyleSNL.Properties.Resources.precio;
            this.rjListadoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjListadoCliente.Location = new System.Drawing.Point(180, 41);
            this.rjListadoCliente.Name = "rjListadoCliente";
            this.rjListadoCliente.Size = new System.Drawing.Size(644, 65);
            this.rjListadoCliente.TabIndex = 6;
            this.rjListadoCliente.Text = "Precios y servicios";
            this.rjListadoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjListadoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjListadoCliente.UseVisualStyleBackColor = false;
            // 
            // FormPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnModificarPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLaser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBarberia);
            this.Controls.Add(this.lblUnas);
            this.Controls.Add(this.dgvUnas);
            this.Controls.Add(this.lblPeluqueria);
            this.Controls.Add(this.dgvPeluqueria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjListadoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrecios";
            this.Text = "FormPrecios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeluqueria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarberia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAtras;
        private RJButton rjListadoCliente;
        private System.Windows.Forms.DataGridView dgvPeluqueria;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnServicioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioP;
        private System.Windows.Forms.Label lblPeluqueria;
        private System.Windows.Forms.Label lblUnas;
        private System.Windows.Forms.DataGridView dgvUnas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBarberia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnModificarPrecio;
    }
}