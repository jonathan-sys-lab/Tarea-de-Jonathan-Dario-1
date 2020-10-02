namespace Tarea1.Formularios
{
    partial class FrmE8
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
            this.label3 = new System.Windows.Forms.Label();
            this.txttra = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dias trabajados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo Diario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario Total";
            // 
            // txttra
            // 
            this.txttra.Location = new System.Drawing.Point(143, 37);
            this.txttra.Name = "txttra";
            this.txttra.Size = new System.Drawing.Size(100, 20);
            this.txttra.TabIndex = 3;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(143, 78);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(100, 20);
            this.txtd.TabIndex = 4;
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(143, 145);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(100, 20);
            this.txts.TabIndex = 5;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(51, 200);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(95, 23);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "Calcular Sueldo";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(176, 199);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 7;
            this.btnL.Text = "Limpiar";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // FrmE8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 323);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txttra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE8";
            this.Text = "Salario de Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttra;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnL;
    }
}