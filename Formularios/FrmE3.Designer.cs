namespace Tarea1.Formularios
{
    partial class FrmE3
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
            this.txtmetros = new System.Windows.Forms.TextBox();
            this.txtmillas = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Millas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Metros";
            // 
            // txtmetros
            // 
            this.txtmetros.Location = new System.Drawing.Point(140, 133);
            this.txtmetros.Name = "txtmetros";
            this.txtmetros.Size = new System.Drawing.Size(100, 20);
            this.txtmetros.TabIndex = 2;
            // 
            // txtmillas
            // 
            this.txtmillas.Location = new System.Drawing.Point(140, 40);
            this.txtmillas.Name = "txtmillas";
            this.txtmillas.Size = new System.Drawing.Size(100, 20);
            this.txtmillas.TabIndex = 3;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(96, 184);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 4;
            this.btnc.Text = "Convertir";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(203, 184);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 5;
            this.btnl.Text = "Limpiar";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // FrmE3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 347);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txtmillas);
            this.Controls.Add(this.txtmetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE3";
            this.Text = "De Millas a Metros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmetros;
        private System.Windows.Forms.TextBox txtmillas;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnl;
    }
}