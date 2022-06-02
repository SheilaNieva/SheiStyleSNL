
namespace SheiStyleSNL
{
    partial class FormCalendario
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rjCalendarioCliente = new SheiStyleSNL.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SheiStyleSNL.Properties.Resources.loguito;
            this.pictureBox1.Location = new System.Drawing.Point(873, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Image = global::SheiStyleSNL.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(42, 48);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 50);
            this.btnAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAtras.TabIndex = 9;
            this.btnAtras.TabStop = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(398, 225);
            this.monthCalendar1.MaxDate = new System.DateTime(2029, 12, 25, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2021, 12, 8, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label1.Location = new System.Drawing.Point(422, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elija un día:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(414, 457);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(161, 38);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rjCalendarioCliente
            // 
            this.rjCalendarioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.rjCalendarioCliente.FlatAppearance.BorderSize = 0;
            this.rjCalendarioCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjCalendarioCliente.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.rjCalendarioCliente.ForeColor = System.Drawing.Color.White;
            this.rjCalendarioCliente.Image = global::SheiStyleSNL.Properties.Resources.calendario;
            this.rjCalendarioCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjCalendarioCliente.Location = new System.Drawing.Point(185, 38);
            this.rjCalendarioCliente.Name = "rjCalendarioCliente";
            this.rjCalendarioCliente.Size = new System.Drawing.Size(644, 65);
            this.rjCalendarioCliente.TabIndex = 8;
            this.rjCalendarioCliente.Text = "Calendario";
            this.rjCalendarioCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjCalendarioCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rjCalendarioCliente.UseVisualStyleBackColor = false;
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.rjCalendarioCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalendario";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnAtras;
        private RJButton rjCalendarioCliente;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
    }
}