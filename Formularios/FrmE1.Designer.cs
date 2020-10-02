namespace Tarea1.Formularios
{
    partial class FrmE1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(126, 26);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 4;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(126, 61);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 5;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(126, 105);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 6;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(160, 144);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(100, 20);
            this.txtr.TabIndex = 7;
            this.txtr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(60, 198);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 8;
            this.btnsuma.Text = "Sumar";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(173, 197);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 9;
            this.btnl.Text = "Limpiar";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // FrmE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 309);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE1";
            this.Text = "Suma De 3 Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnl;
    }
}