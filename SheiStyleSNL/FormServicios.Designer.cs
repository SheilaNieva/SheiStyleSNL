
namespace SheiStyleSNL
{
    partial class FormServicios
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
            this.rjServiciosCliente = new SheiStyleSNL.RJButton();
            this.gbPeluqueria = new System.Windows.Forms.GroupBox();
            this.gbUnas = new System.Windows.Forms.GroupBox();
            this.rbGel = new System.Windows.Forms.RadioButton();
            this.rbPedicura = new System.Windows.Forms.RadioButton();
            this.rbAcrílicas = new System.Windows.Forms.RadioButton();
            this.rbPermanentes = new System.Windows.Forms.RadioButton();
            this.gbCera = new System.Windows.Forms.GroupBox();
            this.rbCejas = new System.Windows.Forms.RadioButton();
            this.rbBigote = new System.Windows.Forms.RadioButton();
            this.gbBarberia = new System.Windows.Forms.GroupBox();
            this.rbRecorte = new System.Windows.Forms.RadioButton();
            this.rbAfeitado = new System.Windows.Forms.RadioButton();
            this.gbLaser = new System.Windows.Forms.GroupBox();
            this.rbZonaIntima = new System.Windows.Forms.RadioButton();
            this.rbAxilas = new System.Windows.Forms.RadioButton();
            this.rbBrazos = new System.Windows.Forms.RadioButton();
            this.rbPiernas = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbLavado = new System.Windows.Forms.CheckBox();
            this.cbDecoloracion = new System.Windows.Forms.CheckBox();
            this.cbMechas = new System.Windows.Forms.CheckBox();
            this.cbTinte = new System.Windows.Forms.CheckBox();
            this.cbCorte = new System.Windows.Forms.CheckBox();
            this.cbRecogido = new System.Windows.Forms.CheckBox();
            this.cbPermanente = new System.Windows.Forms.CheckBox();
            this.cbAlisado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.gbPeluqueria.SuspendLayout();
            this.gbUnas.SuspendLayout();
            this.gbCera.SuspendLayout();
            this.gbBarberia.SuspendLayout();
            this.gbLaser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(874, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(43, 41);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 15;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // rjServiciosCliente
            // 
            this.rjServiciosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjServiciosCliente.FlatAppearance.BorderSize = 0;
            this.rjServiciosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjServiciosCliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjServiciosCliente.ForeColor = System.Drawing.Color.White;
            this.rjServiciosCliente.Image = global::SheiStyleSNL.Properties.Resources.calendario;
            this.rjServiciosCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjServiciosCliente.Location = new System.Drawing.Point(186, 31);
            this.rjServiciosCliente.Name = "rjServiciosCliente";
            this.rjServiciosCliente.Size = new System.Drawing.Size(644, 65);
            this.rjServiciosCliente.TabIndex = 14;
            this.rjServiciosCliente.Text = "Servicios";
            this.rjServiciosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjServiciosCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjServiciosCliente.UseVisualStyleBackColor = false;
            // 
            // gbPeluqueria
            // 
            this.gbPeluqueria.AutoSize = true;
            this.gbPeluqueria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.gbPeluqueria.Controls.Add(this.cbAlisado);
            this.gbPeluqueria.Controls.Add(this.cbPermanente);
            this.gbPeluqueria.Controls.Add(this.cbRecogido);
            this.gbPeluqueria.Controls.Add(this.cbCorte);
            this.gbPeluqueria.Controls.Add(this.cbTinte);
            this.gbPeluqueria.Controls.Add(this.cbMechas);
            this.gbPeluqueria.Controls.Add(this.cbDecoloracion);
            this.gbPeluqueria.Controls.Add(this.cbLavado);
            this.gbPeluqueria.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeluqueria.Location = new System.Drawing.Point(87, 172);
            this.gbPeluqueria.Name = "gbPeluqueria";
            this.gbPeluqueria.Size = new System.Drawing.Size(322, 212);
            this.gbPeluqueria.TabIndex = 17;
            this.gbPeluqueria.TabStop = false;
            this.gbPeluqueria.Text = "Peluquería";
            // 
            // gbUnas
            // 
            this.gbUnas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.gbUnas.Controls.Add(this.rbGel);
            this.gbUnas.Controls.Add(this.rbPedicura);
            this.gbUnas.Controls.Add(this.rbAcrílicas);
            this.gbUnas.Controls.Add(this.rbPermanentes);
            this.gbUnas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnas.Location = new System.Drawing.Point(87, 416);
            this.gbUnas.Name = "gbUnas";
            this.gbUnas.Size = new System.Drawing.Size(322, 124);
            this.gbUnas.TabIndex = 18;
            this.gbUnas.TabStop = false;
            this.gbUnas.Text = "Uñas";
            // 
            // rbGel
            // 
            this.rbGel.AutoSize = true;
            this.rbGel.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGel.Location = new System.Drawing.Point(184, 75);
            this.rbGel.Name = "rbGel";
            this.rbGel.Size = new System.Drawing.Size(65, 21);
            this.rbGel.TabIndex = 5;
            this.rbGel.TabStop = true;
            this.rbGel.Text = "De gel";
            this.rbGel.UseVisualStyleBackColor = true;
            // 
            // rbPedicura
            // 
            this.rbPedicura.AutoSize = true;
            this.rbPedicura.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPedicura.Location = new System.Drawing.Point(184, 37);
            this.rbPedicura.Name = "rbPedicura";
            this.rbPedicura.Size = new System.Drawing.Size(81, 21);
            this.rbPedicura.TabIndex = 4;
            this.rbPedicura.TabStop = true;
            this.rbPedicura.Text = "Pedicura";
            this.rbPedicura.UseVisualStyleBackColor = true;
            // 
            // rbAcrílicas
            // 
            this.rbAcrílicas.AutoSize = true;
            this.rbAcrílicas.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAcrílicas.Location = new System.Drawing.Point(20, 75);
            this.rbAcrílicas.Name = "rbAcrílicas";
            this.rbAcrílicas.Size = new System.Drawing.Size(81, 21);
            this.rbAcrílicas.TabIndex = 1;
            this.rbAcrílicas.TabStop = true;
            this.rbAcrílicas.Text = "Acrílicas";
            this.rbAcrílicas.UseVisualStyleBackColor = true;
            // 
            // rbPermanentes
            // 
            this.rbPermanentes.AutoSize = true;
            this.rbPermanentes.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPermanentes.Location = new System.Drawing.Point(20, 37);
            this.rbPermanentes.Name = "rbPermanentes";
            this.rbPermanentes.Size = new System.Drawing.Size(104, 21);
            this.rbPermanentes.TabIndex = 0;
            this.rbPermanentes.TabStop = true;
            this.rbPermanentes.Text = "Permanentes";
            this.rbPermanentes.UseVisualStyleBackColor = true;
            // 
            // gbCera
            // 
            this.gbCera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.gbCera.Controls.Add(this.rbCejas);
            this.gbCera.Controls.Add(this.rbBigote);
            this.gbCera.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCera.Location = new System.Drawing.Point(533, 134);
            this.gbCera.Name = "gbCera";
            this.gbCera.Size = new System.Drawing.Size(322, 96);
            this.gbCera.TabIndex = 19;
            this.gbCera.TabStop = false;
            this.gbCera.Text = "Depilación con cera caliente";
            // 
            // rbCejas
            // 
            this.rbCejas.AutoSize = true;
            this.rbCejas.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCejas.Location = new System.Drawing.Point(182, 49);
            this.rbCejas.Name = "rbCejas";
            this.rbCejas.Size = new System.Drawing.Size(57, 21);
            this.rbCejas.TabIndex = 4;
            this.rbCejas.TabStop = true;
            this.rbCejas.Text = "Cejas";
            this.rbCejas.UseVisualStyleBackColor = true;
            // 
            // rbBigote
            // 
            this.rbBigote.AutoSize = true;
            this.rbBigote.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBigote.Location = new System.Drawing.Point(18, 49);
            this.rbBigote.Name = "rbBigote";
            this.rbBigote.Size = new System.Drawing.Size(67, 21);
            this.rbBigote.TabIndex = 0;
            this.rbBigote.TabStop = true;
            this.rbBigote.Text = "Bigote";
            this.rbBigote.UseVisualStyleBackColor = true;
            // 
            // gbBarberia
            // 
            this.gbBarberia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.gbBarberia.Controls.Add(this.rbRecorte);
            this.gbBarberia.Controls.Add(this.rbAfeitado);
            this.gbBarberia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBarberia.Location = new System.Drawing.Point(533, 453);
            this.gbBarberia.Name = "gbBarberia";
            this.gbBarberia.Size = new System.Drawing.Size(322, 96);
            this.gbBarberia.TabIndex = 20;
            this.gbBarberia.TabStop = false;
            this.gbBarberia.Text = "Barbería";
            // 
            // rbRecorte
            // 
            this.rbRecorte.AutoSize = true;
            this.rbRecorte.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecorte.Location = new System.Drawing.Point(182, 49);
            this.rbRecorte.Name = "rbRecorte";
            this.rbRecorte.Size = new System.Drawing.Size(72, 21);
            this.rbRecorte.TabIndex = 4;
            this.rbRecorte.TabStop = true;
            this.rbRecorte.Text = "Recorte";
            this.rbRecorte.UseVisualStyleBackColor = true;
            // 
            // rbAfeitado
            // 
            this.rbAfeitado.AutoSize = true;
            this.rbAfeitado.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAfeitado.Location = new System.Drawing.Point(18, 49);
            this.rbAfeitado.Name = "rbAfeitado";
            this.rbAfeitado.Size = new System.Drawing.Size(78, 21);
            this.rbAfeitado.TabIndex = 0;
            this.rbAfeitado.TabStop = true;
            this.rbAfeitado.Text = "Afeitado";
            this.rbAfeitado.UseVisualStyleBackColor = true;
            // 
            // gbLaser
            // 
            this.gbLaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(158)))), ((int)(((byte)(55)))));
            this.gbLaser.Controls.Add(this.rbZonaIntima);
            this.gbLaser.Controls.Add(this.rbAxilas);
            this.gbLaser.Controls.Add(this.rbBrazos);
            this.gbLaser.Controls.Add(this.rbPiernas);
            this.gbLaser.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLaser.Location = new System.Drawing.Point(533, 284);
            this.gbLaser.Name = "gbLaser";
            this.gbLaser.Size = new System.Drawing.Size(322, 124);
            this.gbLaser.TabIndex = 21;
            this.gbLaser.TabStop = false;
            this.gbLaser.Text = "Láser";
            // 
            // rbZonaIntima
            // 
            this.rbZonaIntima.AutoSize = true;
            this.rbZonaIntima.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZonaIntima.Location = new System.Drawing.Point(184, 75);
            this.rbZonaIntima.Name = "rbZonaIntima";
            this.rbZonaIntima.Size = new System.Drawing.Size(101, 21);
            this.rbZonaIntima.TabIndex = 5;
            this.rbZonaIntima.TabStop = true;
            this.rbZonaIntima.Text = "Zona íntima";
            this.rbZonaIntima.UseVisualStyleBackColor = true;
            // 
            // rbAxilas
            // 
            this.rbAxilas.AutoSize = true;
            this.rbAxilas.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAxilas.Location = new System.Drawing.Point(184, 37);
            this.rbAxilas.Name = "rbAxilas";
            this.rbAxilas.Size = new System.Drawing.Size(65, 21);
            this.rbAxilas.TabIndex = 4;
            this.rbAxilas.TabStop = true;
            this.rbAxilas.Text = "Axilas";
            this.rbAxilas.UseVisualStyleBackColor = true;
            // 
            // rbBrazos
            // 
            this.rbBrazos.AutoSize = true;
            this.rbBrazos.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBrazos.Location = new System.Drawing.Point(20, 75);
            this.rbBrazos.Name = "rbBrazos";
            this.rbBrazos.Size = new System.Drawing.Size(68, 21);
            this.rbBrazos.TabIndex = 1;
            this.rbBrazos.TabStop = true;
            this.rbBrazos.Text = "Brazos";
            this.rbBrazos.UseVisualStyleBackColor = true;
            // 
            // rbPiernas
            // 
            this.rbPiernas.AutoSize = true;
            this.rbPiernas.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPiernas.Location = new System.Drawing.Point(20, 37);
            this.rbPiernas.Name = "rbPiernas";
            this.rbPiernas.Size = new System.Drawing.Size(73, 21);
            this.rbPiernas.TabIndex = 0;
            this.rbPiernas.TabStop = true;
            this.rbPiernas.Text = "Piernas";
            this.rbPiernas.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(259, 596);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 16);
            this.lblFecha.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha:";
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnadir.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(428, 596);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(111, 35);
            this.btnAnadir.TabIndex = 24;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(717, 590);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 25;
            // 
            // cbLavado
            // 
            this.cbLavado.AutoSize = true;
            this.cbLavado.Location = new System.Drawing.Point(20, 36);
            this.cbLavado.Name = "cbLavado";
            this.cbLavado.Size = new System.Drawing.Size(80, 22);
            this.cbLavado.TabIndex = 0;
            this.cbLavado.Text = "Lavado";
            this.cbLavado.UseVisualStyleBackColor = true;
            // 
            // cbDecoloracion
            // 
            this.cbDecoloracion.AutoSize = true;
            this.cbDecoloracion.Location = new System.Drawing.Point(175, 36);
            this.cbDecoloracion.Name = "cbDecoloracion";
            this.cbDecoloracion.Size = new System.Drawing.Size(122, 22);
            this.cbDecoloracion.TabIndex = 1;
            this.cbDecoloracion.Text = "Decoloracion";
            this.cbDecoloracion.UseVisualStyleBackColor = true;
            // 
            // cbMechas
            // 
            this.cbMechas.AutoSize = true;
            this.cbMechas.Location = new System.Drawing.Point(21, 166);
            this.cbMechas.Name = "cbMechas";
            this.cbMechas.Size = new System.Drawing.Size(81, 22);
            this.cbMechas.TabIndex = 2;
            this.cbMechas.Text = "Mechas";
            this.cbMechas.UseVisualStyleBackColor = true;
            // 
            // cbTinte
            // 
            this.cbTinte.AutoSize = true;
            this.cbTinte.Location = new System.Drawing.Point(21, 121);
            this.cbTinte.Name = "cbTinte";
            this.cbTinte.Size = new System.Drawing.Size(67, 22);
            this.cbTinte.TabIndex = 3;
            this.cbTinte.Text = "Tinte";
            this.cbTinte.UseVisualStyleBackColor = true;
            // 
            // cbCorte
            // 
            this.cbCorte.AutoSize = true;
            this.cbCorte.Location = new System.Drawing.Point(21, 77);
            this.cbCorte.Name = "cbCorte";
            this.cbCorte.Size = new System.Drawing.Size(65, 22);
            this.cbCorte.TabIndex = 4;
            this.cbCorte.Text = "Corte";
            this.cbCorte.UseVisualStyleBackColor = true;
            // 
            // cbRecogido
            // 
            this.cbRecogido.AutoSize = true;
            this.cbRecogido.Location = new System.Drawing.Point(175, 166);
            this.cbRecogido.Name = "cbRecogido";
            this.cbRecogido.Size = new System.Drawing.Size(92, 22);
            this.cbRecogido.TabIndex = 5;
            this.cbRecogido.Text = "Recogido";
            this.cbRecogido.UseVisualStyleBackColor = true;
            // 
            // cbPermanente
            // 
            this.cbPermanente.AutoSize = true;
            this.cbPermanente.Location = new System.Drawing.Point(175, 121);
            this.cbPermanente.Name = "cbPermanente";
            this.cbPermanente.Size = new System.Drawing.Size(113, 22);
            this.cbPermanente.TabIndex = 6;
            this.cbPermanente.Text = "Permanente";
            this.cbPermanente.UseVisualStyleBackColor = true;
            // 
            // cbAlisado
            // 
            this.cbAlisado.AutoSize = true;
            this.cbAlisado.Location = new System.Drawing.Point(175, 77);
            this.cbAlisado.Name = "cbAlisado";
            this.cbAlisado.Size = new System.Drawing.Size(83, 22);
            this.cbAlisado.TabIndex = 7;
            this.cbAlisado.Text = "Alisado";
            this.cbAlisado.UseVisualStyleBackColor = true;
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLaser);
            this.Controls.Add(this.gbBarberia);
            this.Controls.Add(this.gbCera);
            this.Controls.Add(this.gbUnas);
            this.Controls.Add(this.gbPeluqueria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjServiciosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormServicios";
            this.Load += new System.EventHandler(this.FormServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.gbPeluqueria.ResumeLayout(false);
            this.gbPeluqueria.PerformLayout();
            this.gbUnas.ResumeLayout(false);
            this.gbUnas.PerformLayout();
            this.gbCera.ResumeLayout(false);
            this.gbCera.PerformLayout();
            this.gbBarberia.ResumeLayout(false);
            this.gbBarberia.PerformLayout();
            this.gbLaser.ResumeLayout(false);
            this.gbLaser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAtras;
        private RJButton rjServiciosCliente;
        private System.Windows.Forms.GroupBox gbPeluqueria;
        private System.Windows.Forms.GroupBox gbUnas;
        private System.Windows.Forms.RadioButton rbGel;
        private System.Windows.Forms.RadioButton rbPedicura;
        private System.Windows.Forms.RadioButton rbAcrílicas;
        private System.Windows.Forms.RadioButton rbPermanentes;
        private System.Windows.Forms.GroupBox gbCera;
        private System.Windows.Forms.RadioButton rbCejas;
        private System.Windows.Forms.RadioButton rbBigote;
        private System.Windows.Forms.GroupBox gbBarberia;
        private System.Windows.Forms.RadioButton rbRecorte;
        private System.Windows.Forms.RadioButton rbAfeitado;
        private System.Windows.Forms.GroupBox gbLaser;
        private System.Windows.Forms.RadioButton rbZonaIntima;
        private System.Windows.Forms.RadioButton rbAxilas;
        private System.Windows.Forms.RadioButton rbBrazos;
        private System.Windows.Forms.RadioButton rbPiernas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.CheckBox cbAlisado;
        private System.Windows.Forms.CheckBox cbPermanente;
        private System.Windows.Forms.CheckBox cbRecogido;
        private System.Windows.Forms.CheckBox cbCorte;
        private System.Windows.Forms.CheckBox cbTinte;
        private System.Windows.Forms.CheckBox cbMechas;
        private System.Windows.Forms.CheckBox cbDecoloracion;
        private System.Windows.Forms.CheckBox cbLavado;
    }
}