namespace OralDent.Forms
{
    partial class MenuForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.pacientesBtn = new System.Windows.Forms.Button();
            this.dentistaBtn = new System.Windows.Forms.Button();
            this.servicioBtn = new System.Windows.Forms.Button();
            this.exitMenuBtn = new System.Windows.Forms.Button();
            this.facturaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 25);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(88, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bienvenid@";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(12, 65);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(74, 20);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "Opciones:";
            // 
            // pacientesBtn
            // 
            this.pacientesBtn.Location = new System.Drawing.Point(12, 88);
            this.pacientesBtn.Name = "pacientesBtn";
            this.pacientesBtn.Size = new System.Drawing.Size(94, 29);
            this.pacientesBtn.TabIndex = 2;
            this.pacientesBtn.Text = "Pacientes";
            this.pacientesBtn.UseVisualStyleBackColor = true;
            // 
            // dentistaBtn
            // 
            this.dentistaBtn.Location = new System.Drawing.Point(131, 88);
            this.dentistaBtn.Name = "dentistaBtn";
            this.dentistaBtn.Size = new System.Drawing.Size(94, 29);
            this.dentistaBtn.TabIndex = 3;
            this.dentistaBtn.Text = "Dentistas";
            this.dentistaBtn.UseVisualStyleBackColor = true;
            // 
            // servicioBtn
            // 
            this.servicioBtn.Location = new System.Drawing.Point(12, 138);
            this.servicioBtn.Name = "servicioBtn";
            this.servicioBtn.Size = new System.Drawing.Size(94, 29);
            this.servicioBtn.TabIndex = 4;
            this.servicioBtn.Text = "Servicios";
            this.servicioBtn.UseVisualStyleBackColor = true;
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Location = new System.Drawing.Point(12, 191);
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.Size = new System.Drawing.Size(94, 29);
            this.exitMenuBtn.TabIndex = 5;
            this.exitMenuBtn.Text = "Salir";
            this.exitMenuBtn.UseVisualStyleBackColor = true;
            // 
            // facturaBtn
            // 
            this.facturaBtn.Location = new System.Drawing.Point(131, 138);
            this.facturaBtn.Name = "facturaBtn";
            this.facturaBtn.Size = new System.Drawing.Size(121, 29);
            this.facturaBtn.TabIndex = 7;
            this.facturaBtn.Text = "Generar factura";
            this.facturaBtn.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 249);
            this.Controls.Add(this.facturaBtn);
            this.Controls.Add(this.exitMenuBtn);
            this.Controls.Add(this.servicioBtn);
            this.Controls.Add(this.dentistaBtn);
            this.Controls.Add(this.pacientesBtn);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MenuForm";
            this.Text = "OralDent - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button pacientesBtn;
        private System.Windows.Forms.Button dentistaBtn;
        private System.Windows.Forms.Button servicioBtn;
        private System.Windows.Forms.Button exitMenuBtn;
        private System.Windows.Forms.Button facturaBtn;
    }
}