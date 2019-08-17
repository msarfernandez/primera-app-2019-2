namespace WinApp
{
    partial class frmVentanaDos
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
            this.txtNro1 = new System.Windows.Forms.TextBox();
            this.txtNro2 = new System.Windows.Forms.TextBox();
            this.Dividir = new System.Windows.Forms.Button();
            this.lblNro1 = new System.Windows.Forms.Label();
            this.lblNro2 = new System.Windows.Forms.Label();
            this.btnProbarEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNro1
            // 
            this.txtNro1.Location = new System.Drawing.Point(55, 15);
            this.txtNro1.Name = "txtNro1";
            this.txtNro1.Size = new System.Drawing.Size(100, 20);
            this.txtNro1.TabIndex = 0;
            // 
            // txtNro2
            // 
            this.txtNro2.Location = new System.Drawing.Point(55, 41);
            this.txtNro2.Name = "txtNro2";
            this.txtNro2.Size = new System.Drawing.Size(100, 20);
            this.txtNro2.TabIndex = 1;
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(64, 67);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(75, 23);
            this.Dividir.TabIndex = 2;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // lblNro1
            // 
            this.lblNro1.AutoSize = true;
            this.lblNro1.Location = new System.Drawing.Point(13, 18);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(36, 13);
            this.lblNro1.TabIndex = 3;
            this.lblNro1.Text = "Nro1: ";
            // 
            // lblNro2
            // 
            this.lblNro2.AutoSize = true;
            this.lblNro2.Location = new System.Drawing.Point(13, 44);
            this.lblNro2.Name = "lblNro2";
            this.lblNro2.Size = new System.Drawing.Size(36, 13);
            this.lblNro2.TabIndex = 4;
            this.lblNro2.Text = "Nro 2:";
            // 
            // btnProbarEx
            // 
            this.btnProbarEx.Location = new System.Drawing.Point(207, 67);
            this.btnProbarEx.Name = "btnProbarEx";
            this.btnProbarEx.Size = new System.Drawing.Size(148, 23);
            this.btnProbarEx.TabIndex = 5;
            this.btnProbarEx.Text = "Probar Exception Custom";
            this.btnProbarEx.UseVisualStyleBackColor = true;
            this.btnProbarEx.Click += new System.EventHandler(this.btnProbarEx_Click);
            // 
            // frmVentanaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 229);
            this.Controls.Add(this.btnProbarEx);
            this.Controls.Add(this.lblNro2);
            this.Controls.Add(this.lblNro1);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.txtNro2);
            this.Controls.Add(this.txtNro1);
            this.Name = "frmVentanaDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Excepciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNro1;
        private System.Windows.Forms.TextBox txtNro2;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Label lblNro1;
        private System.Windows.Forms.Label lblNro2;
        private System.Windows.Forms.Button btnProbarEx;
    }
}