namespace OralDent
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.logoPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(12, 128);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(108, 26);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Usuario:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(12, 204);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(144, 26);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Contraseña:";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(118, 301);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(121, 42);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Salir";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.loginBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(280, 301);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(121, 42);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Ingresar";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userTb
            // 
            this.userTb.Location = new System.Drawing.Point(12, 157);
            this.userTb.Name = "userTb";
            this.userTb.PlaceholderText = "Ingrese su usuario...";
            this.userTb.Size = new System.Drawing.Size(161, 27);
            this.userTb.TabIndex = 0;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(12, 233);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.PlaceholderText = "Ingrese su contraseña...";
            this.passTb.Size = new System.Drawing.Size(161, 27);
            this.passTb.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(12, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(125, 30);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "OralDent";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descLabel.Location = new System.Drawing.Point(12, 77);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(180, 26);
            this.descLabel.TabIndex = 7;
            this.descLabel.Text = "Iniciar sesión";
            // 
            // logoPic
            // 
            this.logoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoPic.Image = global::OralDent.Properties.Resources.OralDent;
            this.logoPic.Location = new System.Drawing.Point(241, 12);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(260, 259);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPic.TabIndex = 8;
            this.logoPic.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(538, 355);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.userTb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "OralDent - Login";
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox userTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.PictureBox logoPic;
    }
}
