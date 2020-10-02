namespace Tarea1.Formularios
{
    partial class FrmE4
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
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtk = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese millas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilometros";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(106, 27);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 20);
            this.txtm.TabIndex = 2;
            // 
            // txtk
            // 
            this.txtk.Location = new System.Drawing.Point(106, 87);
            this.txtk.Name = "txtk";
            this.txtk.Size = new System.Drawing.Size(100, 20);
            this.txtk.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(65, 133);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(174, 132);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(75, 23);
            this.btnLim.TabIndex = 5;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // FrmE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 250);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtk);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE4";
            this.Text = "Convertir Milas a Km";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtk;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnLim;
    }
}