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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 75);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Usuario:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(12, 148);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(86, 20);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Contraseña:";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 236);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 29);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Salir";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(112, 236);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(94, 29);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Ingresar";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userTb
            // 
            this.userTb.Location = new System.Drawing.Point(12, 108);
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(125, 27);
            this.userTb.TabIndex = 4;
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(12, 181);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(125, 27);
            this.passTb.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(69, 20);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "OralDent";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(12, 40);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(94, 20);
            this.descLabel.TabIndex = 7;
            this.descLabel.Text = "Iniciar sesión";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 287);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.userTb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginForm";
            this.Text = "OralDent - Login";
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
    }
}
