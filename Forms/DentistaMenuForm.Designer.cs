namespace OralDent.Forms
{
    partial class DentistaMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistaMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.moneyTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.especialidadCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dtGVDentista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDentista)).BeginInit();
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
            this.label1.Text = "Dentistas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(12, 80);
            this.nameTb.Name = "nameTb";
            this.nameTb.PlaceholderText = "Ingrese el nombre...";
            this.nameTb.Size = new System.Drawing.Size(231, 27);
            this.nameTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // lastTb
            // 
            this.lastTb.Location = new System.Drawing.Point(12, 139);
            this.lastTb.Name = "lastTb";
            this.lastTb.PlaceholderText = "Ingrese el apellido...";
            this.lastTb.Size = new System.Drawing.Size(231, 27);
            this.lastTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teléfono:";
            // 
            // telTb
            // 
            this.telTb.Location = new System.Drawing.Point(12, 198);
            this.telTb.Name = "telTb";
            this.telTb.PlaceholderText = "Ingrese el teléfono...";
            this.telTb.Size = new System.Drawing.Size(231, 27);
            this.telTb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salario:";
            // 
            // moneyTb
            // 
            this.moneyTb.Location = new System.Drawing.Point(12, 257);
            this.moneyTb.Name = "moneyTb";
            this.moneyTb.PlaceholderText = "Ingrese el salario...";
            this.moneyTb.Size = new System.Drawing.Size(231, 27);
            this.moneyTb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especialidad:";
            // 
            // especialidadCb
            // 
            this.especialidadCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidadCb.FormattingEnabled = true;
            this.especialidadCb.Items.AddRange(new object[] {
            "Odontólogo",
            "Odontopediatra",
            "Ortodoncista",
            "Periodoncista",
            "Endodoncista",
            "Cirujano",
            "Prostodoncista"});
            this.especialidadCb.Location = new System.Drawing.Point(12, 316);
            this.especialidadCb.Name = "especialidadCb";
            this.especialidadCb.Size = new System.Drawing.Size(231, 28);
            this.especialidadCb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID:";
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(90, 503);
            this.idTb.Name = "idTb";
            this.idTb.PlaceholderText = "Ingrese el ID...";
            this.idTb.Size = new System.Drawing.Size(125, 27);
            this.idTb.TabIndex = 13;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(12, 370);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(231, 37);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Agregar dentista";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.removeBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeBtn.Location = new System.Drawing.Point(253, 497);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(231, 37);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Eliminar dentista";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clearBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.Location = new System.Drawing.Point(12, 433);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(231, 37);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Limpiar campos";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.LightCoral;
            this.backBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(816, 497);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(231, 37);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Volver al menú";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updateBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(528, 497);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(247, 37);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "Modificar dentista";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dtGVDentista
            // 
            this.dtGVDentista.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtGVDentista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVDentista.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dtGVDentista.Location = new System.Drawing.Point(253, 12);
            this.dtGVDentista.Name = "dtGVDentista";
            this.dtGVDentista.ReadOnly = true;
            this.dtGVDentista.RowHeadersWidth = 51;
            this.dtGVDentista.RowTemplate.Height = 29;
            this.dtGVDentista.Size = new System.Drawing.Size(794, 458);
            this.dtGVDentista.TabIndex = 19;
            // 
            // DentistaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1059, 546);
            this.Controls.Add(this.dtGVDentista);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.especialidadCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moneyTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DentistaMenuForm";
            this.Text = "OralDent - Dentista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DentistaMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.DentistaMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDentista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox moneyTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox especialidadCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dtGVDentista;
    }
}