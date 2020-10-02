namespace Tarea1.Formularios
{
    partial class FrmE10
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
            this.txtGal = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de Galones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litros";
            // 
            // txtGal
            // 
            this.txtGal.Location = new System.Drawing.Point(216, 26);
            this.txtGal.Name = "txtGal";
            this.txtGal.Size = new System.Drawing.Size(100, 20);
            this.txtGal.TabIndex = 2;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(216, 69);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(100, 20);
            this.txtLitros.TabIndex = 3;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(89, 118);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 4;
            this.btnc.Text = "Calcular";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(216, 117);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 5;
            this.btnl.Text = "Limpiar";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // FrmE10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 284);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtGal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE10";
            this.Text = "Galones a Litros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGal;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnl;
    }
}