namespace pryPereiroControlesComunes
{
    partial class frmEjemplo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkRojo = new CheckBox();
            chkAzul = new CheckBox();
            chkAmarillo = new CheckBox();
            lblEjemplo = new Label();
            SuspendLayout();
            // 
            // chkRojo
            // 
            chkRojo.AutoSize = true;
            chkRojo.Location = new Point(12, 12);
            chkRojo.Name = "chkRojo";
            chkRojo.Size = new Size(74, 29);
            chkRojo.TabIndex = 0;
            chkRojo.Text = "Rojo";
            chkRojo.UseVisualStyleBackColor = true;
            chkRojo.CheckedChanged += chkRojo_CheckedChanged;
            // 
            // chkAzul
            // 
            chkAzul.AutoSize = true;
            chkAzul.Location = new Point(12, 66);
            chkAzul.Name = "chkAzul";
            chkAzul.Size = new Size(72, 29);
            chkAzul.TabIndex = 1;
            chkAzul.Text = "Azul";
            chkAzul.UseVisualStyleBackColor = true;
            chkAzul.CheckedChanged += chkAzul_CheckedChanged;
            // 
            // chkAmarillo
            // 
            chkAmarillo.AutoSize = true;
            chkAmarillo.Location = new Point(12, 117);
            chkAmarillo.Name = "chkAmarillo";
            chkAmarillo.Size = new Size(104, 29);
            chkAmarillo.TabIndex = 2;
            chkAmarillo.Text = "Amarillo";
            chkAmarillo.UseVisualStyleBackColor = true;
            chkAmarillo.CheckedChanged += chkAmarillo_CheckedChanged;
            // 
            // lblEjemplo
            // 
            lblEjemplo.AutoSize = true;
            lblEjemplo.BorderStyle = BorderStyle.Fixed3D;
            lblEjemplo.Font = new Font("Segoe UI", 16F);
            lblEjemplo.Location = new Point(207, 66);
            lblEjemplo.Name = "lblEjemplo";
            lblEjemplo.Size = new Size(267, 47);
            lblEjemplo.TabIndex = 3;
            lblEjemplo.Text = "Texto de Ejemplo";
            // 
            // frmEjemplo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 208);
            Controls.Add(lblEjemplo);
            Controls.Add(chkAmarillo);
            Controls.Add(chkAzul);
            Controls.Add(chkRojo);
            Name = "frmEjemplo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prueba de Controles Comunes";
            Load += frmEjemplo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkRojo;
        private CheckBox chkAzul;
        private CheckBox chkAmarillo;
        private Label lblEjemplo;
    }
}
