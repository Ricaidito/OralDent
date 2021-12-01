namespace OralDent.Forms
{
    partial class AsistenteMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenteMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.idDentTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dtGvAsistente = new System.Windows.Forms.DataGridView();
            this.dtGvDentista = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvAsistente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvDentista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asistentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(12, 72);
            this.nameTb.Name = "nameTb";
            this.nameTb.PlaceholderText = "Ingrese el nombre...";
            this.nameTb.Size = new System.Drawing.Size(188, 27);
            this.nameTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // lastTb
            // 
            this.lastTb.Location = new System.Drawing.Point(12, 131);
            this.lastTb.Name = "lastTb";
            this.lastTb.PlaceholderText = "Ingrese el apellido...";
            this.lastTb.Size = new System.Drawing.Size(188, 27);
            this.lastTb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Teléfono:";
            // 
            // telTb
            // 
            this.telTb.Location = new System.Drawing.Point(12, 190);
            this.telTb.Name = "telTb";
            this.telTb.PlaceholderText = "Ingrese el teléfono...";
            this.telTb.Size = new System.Drawing.Size(188, 27);
            this.telTb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salario:";
            // 
            // salTb
            // 
            this.salTb.Location = new System.Drawing.Point(12, 249);
            this.salTb.Name = "salTb";
            this.salTb.PlaceholderText = "Ingrese el salario...";
            this.salTb.Size = new System.Drawing.Size(188, 27);
            this.salTb.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID Dentista:";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.delBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delBtn.Location = new System.Drawing.Point(9, 602);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(266, 42);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "Eliminar asistente";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // idDentTb
            // 
            this.idDentTb.Location = new System.Drawing.Point(12, 308);
            this.idDentTb.Name = "idDentTb";
            this.idDentTb.PlaceholderText = "Ingrese el ID del dentista...";
            this.idDentTb.Size = new System.Drawing.Size(188, 27);
            this.idDentTb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID:";
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(59, 502);
            this.idTb.Name = "idTb";
            this.idTb.PlaceholderText = "Ingrese el ID...";
            this.idTb.Size = new System.Drawing.Size(125, 27);
            this.idTb.TabIndex = 13;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updateBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(9, 554);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(266, 42);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Modificar asistente";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clearBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.Location = new System.Drawing.Point(12, 430);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(266, 42);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Limpiar campos";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(531, 602);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(266, 42);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Volver al menú";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(12, 373);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(266, 42);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Agregar asistente";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dtGvAsistente
            // 
            this.dtGvAsistente.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtGvAsistente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvAsistente.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dtGvAsistente.Location = new System.Drawing.Point(286, 43);
            this.dtGvAsistente.Name = "dtGvAsistente";
            this.dtGvAsistente.ReadOnly = true;
            this.dtGvAsistente.RowHeadersWidth = 51;
            this.dtGvAsistente.RowTemplate.Height = 29;
            this.dtGvAsistente.Size = new System.Drawing.Size(769, 249);
            this.dtGvAsistente.TabIndex = 18;
            // 
            // dtGvDentista
            // 
            this.dtGvDentista.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtGvDentista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGvDentista.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dtGvDentista.Location = new System.Drawing.Point(451, 333);
            this.dtGvDentista.Name = "dtGvDentista";
            this.dtGvDentista.ReadOnly = true;
            this.dtGvDentista.RowHeadersWidth = 51;
            this.dtGvDentista.RowTemplate.Height = 29;
            this.dtGvDentista.Size = new System.Drawing.Size(415, 263);
            this.dtGvDentista.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(286, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "Asistentes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(451, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dentistas:";
            // 
            // AsistenteMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 656);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtGvDentista);
            this.Controls.Add(this.dtGvAsistente);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.idTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idDentTb);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsistenteMenuForm";
            this.Text = "OralDent - Asistente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsistenteMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.AsistenteMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGvAsistente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGvDentista)).EndInit();
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
        private System.Windows.Forms.TextBox salTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox idDentTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dtGvAsistente;
        private System.Windows.Forms.DataGridView dtGvDentista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}