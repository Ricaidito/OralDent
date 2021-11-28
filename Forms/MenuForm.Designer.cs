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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.pacientesBtn = new System.Windows.Forms.Button();
            this.dentistaBtn = new System.Windows.Forms.Button();
            this.servicioBtn = new System.Windows.Forms.Button();
            this.facturaBtn = new System.Windows.Forms.Button();
            this.consultaBtn = new System.Windows.Forms.Button();
            this.asistBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(12, 25);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(153, 30);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bienvenid@";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionsLabel.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsLabel.Location = new System.Drawing.Point(12, 65);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(139, 30);
            this.optionsLabel.TabIndex = 1;
            this.optionsLabel.Text = "Opciones:";
            // 
            // pacientesBtn
            // 
            this.pacientesBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pacientesBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pacientesBtn.Location = new System.Drawing.Point(12, 175);
            this.pacientesBtn.Name = "pacientesBtn";
            this.pacientesBtn.Size = new System.Drawing.Size(337, 54);
            this.pacientesBtn.TabIndex = 1;
            this.pacientesBtn.Text = "Pacientes";
            this.pacientesBtn.UseVisualStyleBackColor = false;
            this.pacientesBtn.Click += new System.EventHandler(this.pacientesBtn_Click);
            // 
            // dentistaBtn
            // 
            this.dentistaBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dentistaBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dentistaBtn.Location = new System.Drawing.Point(12, 235);
            this.dentistaBtn.Name = "dentistaBtn";
            this.dentistaBtn.Size = new System.Drawing.Size(337, 54);
            this.dentistaBtn.TabIndex = 2;
            this.dentistaBtn.Text = "Dentistas";
            this.dentistaBtn.UseVisualStyleBackColor = false;
            // 
            // servicioBtn
            // 
            this.servicioBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.servicioBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servicioBtn.Location = new System.Drawing.Point(12, 355);
            this.servicioBtn.Name = "servicioBtn";
            this.servicioBtn.Size = new System.Drawing.Size(337, 54);
            this.servicioBtn.TabIndex = 4;
            this.servicioBtn.Text = "Servicios";
            this.servicioBtn.UseVisualStyleBackColor = false;
            // 
            // facturaBtn
            // 
            this.facturaBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.facturaBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.facturaBtn.Location = new System.Drawing.Point(12, 415);
            this.facturaBtn.Name = "facturaBtn";
            this.facturaBtn.Size = new System.Drawing.Size(337, 54);
            this.facturaBtn.TabIndex = 5;
            this.facturaBtn.Text = "Generar factura";
            this.facturaBtn.UseVisualStyleBackColor = false;
            // 
            // consultaBtn
            // 
            this.consultaBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.consultaBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultaBtn.Location = new System.Drawing.Point(12, 115);
            this.consultaBtn.Name = "consultaBtn";
            this.consultaBtn.Size = new System.Drawing.Size(337, 54);
            this.consultaBtn.TabIndex = 0;
            this.consultaBtn.Text = "Consultas";
            this.consultaBtn.UseVisualStyleBackColor = false;
            // 
            // asistBtn
            // 
            this.asistBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.asistBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.asistBtn.Location = new System.Drawing.Point(12, 295);
            this.asistBtn.Name = "asistBtn";
            this.asistBtn.Size = new System.Drawing.Size(337, 54);
            this.asistBtn.TabIndex = 3;
            this.asistBtn.Text = "Asistentes";
            this.asistBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::OralDent.Properties.Resources.OralDent;
            this.pictureBox1.Location = new System.Drawing.Point(427, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(777, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.asistBtn);
            this.Controls.Add(this.consultaBtn);
            this.Controls.Add(this.facturaBtn);
            this.Controls.Add(this.servicioBtn);
            this.Controls.Add(this.dentistaBtn);
            this.Controls.Add(this.pacientesBtn);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "OralDent - Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button consultaBtn;
        private System.Windows.Forms.Button asistBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}