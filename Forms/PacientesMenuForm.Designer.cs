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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones pacientes:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar paciente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar paciente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Modificar paciente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 137);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 29);
            this.button9.TabIndex = 10;
            this.button9.Text = "Volver al menú";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // PacientesMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 228);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "PacientesMenuForm";
            this.Text = "OralDent - Pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PacientesMenuForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
    }
}