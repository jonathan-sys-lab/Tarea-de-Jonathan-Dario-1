namespace Tarea1.Formularios
{
    partial class FrmE2
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.btnp = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Promedio";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(108, 36);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 5;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(108, 68);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 6;
            this.txtn2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(108, 108);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 7;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(108, 144);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 20);
            this.txtn4.TabIndex = 8;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(108, 183);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(100, 20);
            this.txtp.TabIndex = 9;
            // 
            // btnp
            // 
            this.btnp.Location = new System.Drawing.Point(36, 223);
            this.btnp.Name = "btnp";
            this.btnp.Size = new System.Drawing.Size(103, 23);
            this.btnp.TabIndex = 10;
            this.btnp.Text = "Calcular Promedio";
            this.btnp.UseVisualStyleBackColor = true;
            this.btnp.Click += new System.EventHandler(this.btnp_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(145, 222);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 11;
            this.btnl.Text = "Limpiar";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // FrmE2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 278);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnp);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE2";
            this.Text = "Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.Button btnp;
        private System.Windows.Forms.Button btnl;
    }
}