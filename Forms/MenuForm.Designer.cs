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
            this.facturaBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.pacientesBtn.Click += new System.EventHandler(this.pacientesBtn_Click);
            // 
            // dentistaBtn
            // 
            this.dentistaBtn.Location = new System.Drawing.Point(121, 88);
            this.dentistaBtn.Name = "dentistaBtn";
            this.dentistaBtn.Size = new System.Drawing.Size(94, 29);
            this.dentistaBtn.TabIndex = 3;
            this.dentistaBtn.Text = "Dentistas";
            this.dentistaBtn.UseVisualStyleBackColor = true;
            // 
            // servicioBtn
            // 
            this.servicioBtn.Location = new System.Drawing.Point(12, 123);
            this.servicioBtn.Name = "servicioBtn";
            this.servicioBtn.Size = new System.Drawing.Size(94, 29);
            this.servicioBtn.TabIndex = 4;
            this.servicioBtn.Text = "Servicios";
            this.servicioBtn.UseVisualStyleBackColor = true;
            // 
            // facturaBtn
            // 
            this.facturaBtn.Location = new System.Drawing.Point(112, 123);
            this.facturaBtn.Name = "facturaBtn";
            this.facturaBtn.Size = new System.Drawing.Size(121, 29);
            this.facturaBtn.TabIndex = 7;
            this.facturaBtn.Text = "Generar factura";
            this.facturaBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Consultas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Asistentes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 187);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.facturaBtn);
            this.Controls.Add(this.servicioBtn);
            this.Controls.Add(this.dentistaBtn);
            this.Controls.Add(this.pacientesBtn);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MenuForm";
            this.Text = "OralDent - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button pacientesBtn;
        private System.Windows.Forms.Button dentistaBtn;
        private System.Windows.Forms.Button servicioBtn;
        private System.Windows.Forms.Button facturaBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}