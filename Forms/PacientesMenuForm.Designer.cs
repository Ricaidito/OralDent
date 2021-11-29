namespace OralDent.Forms
{
    partial class PacientesMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.agregarPacienteBtn = new System.Windows.Forms.Button();
            this.eliminarPacienteBtn = new System.Windows.Forms.Button();
            this.updatePacienteBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.clearBoxBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.lastTb = new System.Windows.Forms.TextBox();
            this.cedulaTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.telTb = new System.Windows.Forms.TextBox();
            this.tipoPacienteDropdown = new System.Windows.Forms.ComboBox();
            this.dataGVPacientes = new System.Windows.Forms.DataGridView();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            // 
            // agregarPacienteBtn
            // 
            this.agregarPacienteBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.agregarPacienteBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.agregarPacienteBtn.Location = new System.Drawing.Point(45, 492);
            this.agregarPacienteBtn.Name = "agregarPacienteBtn";
            this.agregarPacienteBtn.Size = new System.Drawing.Size(289, 46);
            this.agregarPacienteBtn.TabIndex = 7;
            this.agregarPacienteBtn.Text = "Agregar paciente";
            this.agregarPacienteBtn.UseVisualStyleBackColor = false;
            this.agregarPacienteBtn.Click += new System.EventHandler(this.agregarPacienteBtn_Click);
            // 
            // eliminarPacienteBtn
            // 
            this.eliminarPacienteBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eliminarPacienteBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eliminarPacienteBtn.Location = new System.Drawing.Point(242, 544);
            this.eliminarPacienteBtn.Name = "eliminarPacienteBtn";
            this.eliminarPacienteBtn.Size = new System.Drawing.Size(289, 46);
            this.eliminarPacienteBtn.TabIndex = 8;
            this.eliminarPacienteBtn.Text = "Eliminar paciente";
            this.eliminarPacienteBtn.UseVisualStyleBackColor = false;
            this.eliminarPacienteBtn.Click += new System.EventHandler(this.eliminarPacienteBtn_Click);
            // 
            // updatePacienteBtn
            // 
            this.updatePacienteBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updatePacienteBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatePacienteBtn.Location = new System.Drawing.Point(615, 544);
            this.updatePacienteBtn.Name = "updatePacienteBtn";
            this.updatePacienteBtn.Size = new System.Drawing.Size(289, 46);
            this.updatePacienteBtn.TabIndex = 9;
            this.updatePacienteBtn.Text = "Modificar paciente";
            this.updatePacienteBtn.UseVisualStyleBackColor = false;
            this.updatePacienteBtn.Click += new System.EventHandler(this.updatePacienteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.LightCoral;
            this.backBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(797, 492);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(260, 46);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Volver al menú";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // clearBoxBtn
            // 
            this.clearBoxBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clearBoxBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBoxBtn.Location = new System.Drawing.Point(425, 492);
            this.clearBoxBtn.Name = "clearBoxBtn";
            this.clearBoxBtn.Size = new System.Drawing.Size(275, 46);
            this.clearBoxBtn.TabIndex = 10;
            this.clearBoxBtn.Text = "Limpiar campos";
            this.clearBoxBtn.UseVisualStyleBackColor = false;
            this.clearBoxBtn.Click += new System.EventHandler(this.clearBoxBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cédula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo de paciente:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(12, 72);
            this.nameTb.MaxLength = 20;
            this.nameTb.Name = "nameTb";
            this.nameTb.PlaceholderText = "Ingrese el nombre...";
            this.nameTb.Size = new System.Drawing.Size(216, 27);
            this.nameTb.TabIndex = 0;
            // 
            // lastTb
            // 
            this.lastTb.Location = new System.Drawing.Point(12, 131);
            this.lastTb.MaxLength = 20;
            this.lastTb.Name = "lastTb";
            this.lastTb.PlaceholderText = "Ingrese el apellido...";
            this.lastTb.Size = new System.Drawing.Size(216, 27);
            this.lastTb.TabIndex = 1;
            // 
            // cedulaTb
            // 
            this.cedulaTb.Location = new System.Drawing.Point(12, 189);
            this.cedulaTb.MaxLength = 20;
            this.cedulaTb.Name = "cedulaTb";
            this.cedulaTb.PlaceholderText = "Ingrese la cédula...";
            this.cedulaTb.Size = new System.Drawing.Size(216, 27);
            this.cedulaTb.TabIndex = 2;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(12, 252);
            this.emailTb.MaxLength = 40;
            this.emailTb.Name = "emailTb";
            this.emailTb.PlaceholderText = "Ingrese el e-mail...";
            this.emailTb.Size = new System.Drawing.Size(216, 27);
            this.emailTb.TabIndex = 3;
            // 
            // ageTb
            // 
            this.ageTb.Location = new System.Drawing.Point(12, 311);
            this.ageTb.Name = "ageTb";
            this.ageTb.PlaceholderText = "Ingrese la edad...";
            this.ageTb.Size = new System.Drawing.Size(216, 27);
            this.ageTb.TabIndex = 4;
            // 
            // telTb
            // 
            this.telTb.Location = new System.Drawing.Point(12, 370);
            this.telTb.MaxLength = 24;
            this.telTb.Name = "telTb";
            this.telTb.PlaceholderText = "Ingrese el teléfono...";
            this.telTb.Size = new System.Drawing.Size(216, 27);
            this.telTb.TabIndex = 5;
            // 
            // tipoPacienteDropdown
            // 
            this.tipoPacienteDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPacienteDropdown.FormattingEnabled = true;
            this.tipoPacienteDropdown.Items.AddRange(new object[] {
            "Mayor",
            "Menor"});
            this.tipoPacienteDropdown.Location = new System.Drawing.Point(12, 429);
            this.tipoPacienteDropdown.Name = "tipoPacienteDropdown";
            this.tipoPacienteDropdown.Size = new System.Drawing.Size(216, 28);
            this.tipoPacienteDropdown.TabIndex = 6;
            // 
            // dataGVPacientes
            // 
            this.dataGVPacientes.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGVPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVPacientes.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGVPacientes.Location = new System.Drawing.Point(253, 12);
            this.dataGVPacientes.Name = "dataGVPacientes";
            this.dataGVPacientes.ReadOnly = true;
            this.dataGVPacientes.RowHeadersWidth = 51;
            this.dataGVPacientes.RowTemplate.Height = 29;
            this.dataGVPacientes.Size = new System.Drawing.Size(804, 465);
            this.dataGVPacientes.TabIndex = 26;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(12, 554);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(48, 26);
            this.idLabel.TabIndex = 27;
            this.idLabel.Text = "ID:";
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(69, 555);
            this.idTb.Name = "idTb";
            this.idTb.PlaceholderText = "Ingrese el ID...";
            this.idTb.Size = new System.Drawing.Size(125, 27);
            this.idTb.TabIndex = 28;
            // 
            // PacientesMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dataGVPacientes);
            this.Controls.Add(this.tipoPacienteDropdown);
            this.Controls.Add(this.telTb);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.cedulaTb);
            this.Controls.Add(this.lastTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearBoxBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updatePacienteBtn);
            this.Controls.Add(this.eliminarPacienteBtn);
            this.Controls.Add(this.agregarPacienteBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PacientesMenuForm";
            this.Text = "OralDent - Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PacientesMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.PacientesMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarPacienteBtn;
        private System.Windows.Forms.Button eliminarPacienteBtn;
        private System.Windows.Forms.Button updatePacienteBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button clearBoxBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox lastTb;
        private System.Windows.Forms.TextBox cedulaTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.TextBox telTb;
        private System.Windows.Forms.ComboBox tipoPacienteDropdown;
        private System.Windows.Forms.DataGridView dataGVPacientes;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTb;
    }
}