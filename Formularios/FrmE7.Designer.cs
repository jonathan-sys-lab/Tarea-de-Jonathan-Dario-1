namespace Tarea1.Formularios
{
    partial class FrmE7
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
            this.txtll = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtpagar = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Llantas a comprar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "valor de cada llanta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total a pagar";
            // 
            // txtll
            // 
            this.txtll.Location = new System.Drawing.Point(200, 28);
            this.txtll.Name = "txtll";
            this.txtll.Size = new System.Drawing.Size(100, 20);
            this.txtll.TabIndex = 3;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(200, 65);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 4;
            // 
            // txtpagar
            // 
            this.txtpagar.Location = new System.Drawing.Point(200, 127);
            this.txtpagar.Name = "txtpagar";
            this.txtpagar.Size = new System.Drawing.Size(100, 20);
            this.txtpagar.TabIndex = 5;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(115, 178);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 6;
            this.btnc.Text = "CALCULAR";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(237, 177);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // FrmE7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 273);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txtpagar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE7";
            this.Text = "Compra de llantas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtll;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtpagar;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnlimpiar;
    }
}