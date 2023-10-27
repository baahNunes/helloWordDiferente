namespace Hello_World2
{
    partial class MediaAritmetica
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
            this.tbAc1 = new System.Windows.Forms.TextBox();
            this.tbTio = new System.Windows.Forms.TextBox();
            this.tbAc2 = new System.Windows.Forms.TextBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AC1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AC2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AR";
            // 
            // tbAc1
            // 
            this.tbAc1.Location = new System.Drawing.Point(80, 32);
            this.tbAc1.Name = "tbAc1";
            this.tbAc1.Size = new System.Drawing.Size(37, 20);
            this.tbAc1.TabIndex = 4;
            // 
            // tbTio
            // 
            this.tbTio.Location = new System.Drawing.Point(80, 67);
            this.tbTio.Name = "tbTio";
            this.tbTio.Size = new System.Drawing.Size(37, 20);
            this.tbTio.TabIndex = 5;
            // 
            // tbAc2
            // 
            this.tbAc2.Location = new System.Drawing.Point(190, 32);
            this.tbAc2.Name = "tbAc2";
            this.tbAc2.Size = new System.Drawing.Size(37, 20);
            this.tbAc2.TabIndex = 6;
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(190, 67);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(37, 20);
            this.tbAr.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MEDIA ARITIMETICA";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(99, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(74, 166);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 10;
            // 
            // MediaAritmetica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.tbAc2);
            this.Controls.Add(this.tbTio);
            this.Controls.Add(this.tbAc1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MediaAritmetica";
            this.Text = "MediaAritmetica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAc1;
        private System.Windows.Forms.TextBox tbTio;
        private System.Windows.Forms.TextBox tbAc2;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}