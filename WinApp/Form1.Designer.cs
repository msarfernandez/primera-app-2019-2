namespace WinApp
{
    partial class Form1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxPasaje = new System.Windows.Forms.CheckBox();
            this.btnOtroBoton = new System.Windows.Forms.Button();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCambiarLugares = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSaludar.FlatAppearance.BorderSize = 3;
            this.btnSaludar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnSaludar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Location = new System.Drawing.Point(30, 21);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(130, 46);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "&Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            this.btnSaludar.MouseHover += new System.EventHandler(this.btnSaludar_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxPasaje
            // 
            this.cbxPasaje.AutoSize = true;
            this.cbxPasaje.Location = new System.Drawing.Point(314, 39);
            this.cbxPasaje.Name = "cbxPasaje";
            this.cbxPasaje.Size = new System.Drawing.Size(70, 17);
            this.cbxPasaje.TabIndex = 3;
            this.cbxPasaje.Text = "Siguiente";
            this.cbxPasaje.UseVisualStyleBackColor = true;
            // 
            // btnOtroBoton
            // 
            this.btnOtroBoton.Location = new System.Drawing.Point(314, 62);
            this.btnOtroBoton.Name = "btnOtroBoton";
            this.btnOtroBoton.Size = new System.Drawing.Size(75, 23);
            this.btnOtroBoton.TabIndex = 4;
            this.btnOtroBoton.Text = "Ir";
            this.btnOtroBoton.UseVisualStyleBackColor = true;
            this.btnOtroBoton.Click += new System.EventHandler(this.btnOtroBoton_Click);
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Location = new System.Drawing.Point(12, 122);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(121, 21);
            this.cboOpciones.TabIndex = 5;
            this.cboOpciones.SelectedIndexChanged += new System.EventHandler(this.cboOpciones_SelectedIndexChanged);
            // 
            // btnCambiarLugares
            // 
            this.btnCambiarLugares.Location = new System.Drawing.Point(190, 33);
            this.btnCambiarLugares.Name = "btnCambiarLugares";
            this.btnCambiarLugares.Size = new System.Drawing.Size(103, 23);
            this.btnCambiarLugares.TabIndex = 6;
            this.btnCambiarLugares.Text = "Cambiar Lugares";
            this.btnCambiarLugares.UseVisualStyleBackColor = true;
            this.btnCambiarLugares.Click += new System.EventHandler(this.btnCambiarLugares_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(314, 122);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 155);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCambiarLugares);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.btnOtroBoton);
            this.Controls.Add(this.cbxPasaje);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Form1";
            this.Text = "Lo cambio desde acá";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbxPasaje;
        private System.Windows.Forms.Button btnOtroBoton;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Button btnCambiarLugares;
        private System.Windows.Forms.Button btnSalir;
    }
}

