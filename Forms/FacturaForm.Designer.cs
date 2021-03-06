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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.facturaDGV = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.idPacienteTb = new System.Windows.Forms.TextBox();
            this.servicioDGV = new System.Windows.Forms.DataGridView();
            this.idSucursalTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID del paciente:";
            // 
            // facturaDGV
            // 
            this.facturaDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.facturaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.facturaDGV.Location = new System.Drawing.Point(285, 13);
            this.facturaDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facturaDGV.Name = "facturaDGV";
            this.facturaDGV.ReadOnly = true;
            this.facturaDGV.RowHeadersWidth = 51;
            this.facturaDGV.RowTemplate.Height = 29;
            this.facturaDGV.Size = new System.Drawing.Size(501, 184);
            this.facturaDGV.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(32, 231);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(201, 40);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Generar factura";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.Location = new System.Drawing.Point(32, 313);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(201, 40);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Volver al menú";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // idPacienteTb
            // 
            this.idPacienteTb.Location = new System.Drawing.Point(45, 128);
            this.idPacienteTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idPacienteTb.Name = "idPacienteTb";
            this.idPacienteTb.PlaceholderText = "Ingrese el ID del paciente...";
            this.idPacienteTb.Size = new System.Drawing.Size(166, 23);
            this.idPacienteTb.TabIndex = 5;
            // 
            // servicioDGV
            // 
            this.servicioDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.servicioDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicioDGV.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.servicioDGV.Location = new System.Drawing.Point(285, 202);
            this.servicioDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servicioDGV.Name = "servicioDGV";
            this.servicioDGV.ReadOnly = true;
            this.servicioDGV.RowHeadersWidth = 51;
            this.servicioDGV.RowTemplate.Height = 29;
            this.servicioDGV.Size = new System.Drawing.Size(501, 180);
            this.servicioDGV.TabIndex = 6;
            // 
            // idSucursalTb
            // 
            this.idSucursalTb.Location = new System.Drawing.Point(45, 184);
            this.idSucursalTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idSucursalTb.Name = "idSucursalTb";
            this.idSucursalTb.PlaceholderText = "Ingrese el ID de la sucursal...";
            this.idSucursalTb.Size = new System.Drawing.Size(166, 23);
            this.idSucursalTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID de la sucursal:";
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(797, 404);
            this.Controls.Add(this.idSucursalTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.servicioDGV);
            this.Controls.Add(this.idPacienteTb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.facturaDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OralDent - Factura";
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
        private System.Windows.Forms.TextBox idSucursalTb;
        private System.Windows.Forms.Label label3;
    }
}