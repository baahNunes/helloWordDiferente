namespace Hello_World2
{
    partial class LaçoRepeticao
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
            this.lbLista1 = new System.Windows.Forms.ListBox();
            this.lbLista2 = new System.Windows.Forms.ListBox();
            this.lbLista3 = new System.Windows.Forms.ListBox();
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLista1
            // 
            this.lbLista1.FormattingEnabled = true;
            this.lbLista1.Location = new System.Drawing.Point(11, 81);
            this.lbLista1.Name = "lbLista1";
            this.lbLista1.Size = new System.Drawing.Size(73, 186);
            this.lbLista1.TabIndex = 0;
            // 
            // lbLista2
            // 
            this.lbLista2.FormattingEnabled = true;
            this.lbLista2.Location = new System.Drawing.Point(103, 81);
            this.lbLista2.Name = "lbLista2";
            this.lbLista2.Size = new System.Drawing.Size(65, 186);
            this.lbLista2.TabIndex = 1;
            // 
            // lbLista3
            // 
            this.lbLista3.FormattingEnabled = true;
            this.lbLista3.Location = new System.Drawing.Point(219, 81);
            this.lbLista3.Name = "lbLista3";
            this.lbLista3.Size = new System.Drawing.Size(75, 186);
            this.lbLista3.TabIndex = 2;
            // 
            // tbNumero1
            // 
            this.tbNumero1.Location = new System.Drawing.Point(12, 36);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(72, 20);
            this.tbNumero1.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(219, 273);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(182, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(37, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(182, 81);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(22, 23);
            this.btnSoma.TabIndex = 7;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(182, 119);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(22, 23);
            this.btnSub.TabIndex = 8;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(182, 155);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(22, 23);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(182, 194);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(22, 23);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // tbNumero2
            // 
            this.tbNumero2.Location = new System.Drawing.Point(96, 36);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(72, 20);
            this.tbNumero2.TabIndex = 11;
            // 
            // LaçoRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 315);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tbNumero1);
            this.Controls.Add(this.lbLista3);
            this.Controls.Add(this.lbLista2);
            this.Controls.Add(this.lbLista1);
            this.Name = "LaçoRepeticao";
            this.Text = "LaçoRepeticao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista1;
        private System.Windows.Forms.ListBox lbLista2;
        private System.Windows.Forms.ListBox lbLista3;
        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox tbNumero2;
    }
}