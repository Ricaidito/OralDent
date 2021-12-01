namespace OralDent.Forms
{
    partial class FacturaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.facturaDGV = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.idPacienteTb = new System.Windows.Forms.TextBox();
            this.servicioDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID del paciente:";
            // 
            // facturaDGV
            // 
            this.facturaDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.facturaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.facturaDGV.Location = new System.Drawing.Point(326, 17);
            this.facturaDGV.Name = "facturaDGV";
            this.facturaDGV.ReadOnly = true;
            this.facturaDGV.RowHeadersWidth = 51;
            this.facturaDGV.RowTemplate.Height = 29;
            this.facturaDGV.Size = new System.Drawing.Size(573, 246);
            this.facturaDGV.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(36, 269);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(230, 53);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Generar factura";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(36, 379);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(230, 53);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Volver al menú";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // idPacienteTb
            // 
            this.idPacienteTb.Location = new System.Drawing.Point(51, 170);
            this.idPacienteTb.Name = "idPacienteTb";
            this.idPacienteTb.PlaceholderText = "Ingrese el ID del paciente...";
            this.idPacienteTb.Size = new System.Drawing.Size(189, 27);
            this.idPacienteTb.TabIndex = 5;
            // 
            // servicioDGV
            // 
            this.servicioDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.servicioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicioDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.servicioDGV.Location = new System.Drawing.Point(326, 269);
            this.servicioDGV.Name = "servicioDGV";
            this.servicioDGV.ReadOnly = true;
            this.servicioDGV.RowHeadersWidth = 51;
            this.servicioDGV.RowTemplate.Height = 29;
            this.servicioDGV.Size = new System.Drawing.Size(573, 240);
            this.servicioDGV.TabIndex = 6;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(911, 521);
            this.Controls.Add(this.servicioDGV);
            this.Controls.Add(this.idPacienteTb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.facturaDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacturaForm_FormClosing);
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView facturaDGV;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox idPacienteTb;
        private System.Windows.Forms.DataGridView servicioDGV;
    }
}