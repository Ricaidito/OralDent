namespace OralDent.Forms
{
    partial class ConsultasMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consultasDGV = new System.Windows.Forms.DataGridView();
            this.dentistaDGV = new System.Windows.Forms.DataGridView();
            this.pacientesDGV = new System.Windows.Forms.DataGridView();
            this.idPacienteTb = new System.Windows.Forms.TextBox();
            this.descTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idDentTb = new System.Windows.Forms.TextBox();
            this.dateTb = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.idConsultaTb = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idSucTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Paciente:";
            // 
            // consultasDGV
            // 
            this.consultasDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.consultasDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.consultasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.consultasDGV.Location = new System.Drawing.Point(326, 209);
            this.consultasDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultasDGV.Name = "consultasDGV";
            this.consultasDGV.ReadOnly = true;
            this.consultasDGV.RowHeadersWidth = 51;
            this.consultasDGV.RowTemplate.Height = 29;
            this.consultasDGV.Size = new System.Drawing.Size(746, 416);
            this.consultasDGV.TabIndex = 2;
            // 
            // dentistaDGV
            // 
            this.dentistaDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dentistaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dentistaDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dentistaDGV.Location = new System.Drawing.Point(326, 32);
            this.dentistaDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dentistaDGV.Name = "dentistaDGV";
            this.dentistaDGV.ReadOnly = true;
            this.dentistaDGV.RowHeadersWidth = 51;
            this.dentistaDGV.RowTemplate.Height = 29;
            this.dentistaDGV.Size = new System.Drawing.Size(366, 144);
            this.dentistaDGV.TabIndex = 3;
            // 
            // pacientesDGV
            // 
            this.pacientesDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.pacientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientesDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.pacientesDGV.Location = new System.Drawing.Point(706, 32);
            this.pacientesDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pacientesDGV.Name = "pacientesDGV";
            this.pacientesDGV.ReadOnly = true;
            this.pacientesDGV.RowHeadersWidth = 51;
            this.pacientesDGV.RowTemplate.Height = 29;
            this.pacientesDGV.Size = new System.Drawing.Size(366, 144);
            this.pacientesDGV.TabIndex = 4;
            // 
            // idPacienteTb
            // 
            this.idPacienteTb.Location = new System.Drawing.Point(10, 62);
            this.idPacienteTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idPacienteTb.Name = "idPacienteTb";
            this.idPacienteTb.PlaceholderText = "Ingrese el ID del paciente...";
            this.idPacienteTb.Size = new System.Drawing.Size(168, 23);
            this.idPacienteTb.TabIndex = 5;
            // 
            // descTb
            // 
            this.descTb.AcceptsReturn = true;
            this.descTb.AcceptsTab = true;
            this.descTb.Location = new System.Drawing.Point(10, 159);
            this.descTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descTb.Multiline = true;
            this.descTb.Name = "descTb";
            this.descTb.PlaceholderText = "Indique la descripción dada por el paciente...";
            this.descTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descTb.Size = new System.Drawing.Size(290, 157);
            this.descTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Dentista:";
            // 
            // idDentTb
            // 
            this.idDentTb.Location = new System.Drawing.Point(10, 399);
            this.idDentTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idDentTb.Name = "idDentTb";
            this.idDentTb.PlaceholderText = "Ingrese el ID del dentista...";
            this.idDentTb.Size = new System.Drawing.Size(168, 23);
            this.idDentTb.TabIndex = 11;
            // 
            // dateTb
            // 
            this.dateTb.Location = new System.Drawing.Point(10, 352);
            this.dateTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(290, 23);
            this.dateTb.TabIndex = 12;
            this.dateTb.ValueChanged += new System.EventHandler(this.dateTb_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID Consulta:";
            // 
            // idConsultaTb
            // 
            this.idConsultaTb.Location = new System.Drawing.Point(10, 547);
            this.idConsultaTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idConsultaTb.Name = "idConsultaTb";
            this.idConsultaTb.PlaceholderText = "Ingrese el id de consulta...";
            this.idConsultaTb.Size = new System.Drawing.Size(158, 23);
            this.idConsultaTb.TabIndex = 14;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeBtn.Location = new System.Drawing.Point(10, 571);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(214, 39);
            this.removeBtn.TabIndex = 15;
            this.removeBtn.Text = "Eliminar consulta";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(10, 659);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(214, 39);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Volver al menú";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.Location = new System.Drawing.Point(10, 476);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(214, 39);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Limpiar campos";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(10, 433);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(214, 39);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Agendar consulta";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(10, 615);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(214, 39);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Modificar consulta";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(326, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Consultas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(326, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dentistas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(706, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pacientes:";
            // 
            // idSucTb
            // 
            this.idSucTb.Location = new System.Drawing.Point(10, 109);
            this.idSucTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idSucTb.Name = "idSucTb";
            this.idSucTb.PlaceholderText = "Ingrese el ID de la sucursal...";
            this.idSucTb.Size = new System.Drawing.Size(168, 23);
            this.idSucTb.TabIndex = 24;
            this.idSucTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "ID Sucursal:";
            // 
            // ConsultasMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1082, 706);
            this.Controls.Add(this.idSucTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.idConsultaTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTb);
            this.Controls.Add(this.idDentTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descTb);
            this.Controls.Add(this.idPacienteTb);
            this.Controls.Add(this.pacientesDGV);
            this.Controls.Add(this.dentistaDGV);
            this.Controls.Add(this.consultasDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ConsultasMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OralDent - Consultas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultasMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.ConsultasMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView consultasDGV;
        private System.Windows.Forms.DataGridView dentistaDGV;
        private System.Windows.Forms.DataGridView pacientesDGV;
        private System.Windows.Forms.TextBox idPacienteTb;
        private System.Windows.Forms.TextBox descTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idDentTb;
        private System.Windows.Forms.DateTimePicker dateTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idConsultaTb;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idSucTb;
        private System.Windows.Forms.Label label10;
    }
}