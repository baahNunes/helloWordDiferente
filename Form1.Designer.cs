namespace Hello_World2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entrega1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaAritméticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaPonderadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrega2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrega3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laçoDeRepetiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrega1ToolStripMenuItem,
            this.entrega2ToolStripMenuItem,
            this.entrega3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entrega1ToolStripMenuItem
            // 
            this.entrega1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldToolStripMenuItem,
            this.somaToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.mediaAritméticaToolStripMenuItem,
            this.médiaPonderadaToolStripMenuItem,
            this.iMCToolStripMenuItem,
            this.laçoDeRepetiçãoToolStripMenuItem});
            this.entrega1ToolStripMenuItem.Name = "entrega1ToolStripMenuItem";
            this.entrega1ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.entrega1ToolStripMenuItem.Text = "Entrega 1";
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // somaToolStripMenuItem
            // 
            this.somaToolStripMenuItem.Name = "somaToolStripMenuItem";
            this.somaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.somaToolStripMenuItem.Text = "Soma";
            this.somaToolStripMenuItem.Click += new System.EventHandler(this.somaToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // mediaAritméticaToolStripMenuItem
            // 
            this.mediaAritméticaToolStripMenuItem.Name = "mediaAritméticaToolStripMenuItem";
            this.mediaAritméticaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mediaAritméticaToolStripMenuItem.Text = "Média Aritmética";
            this.mediaAritméticaToolStripMenuItem.Click += new System.EventHandler(this.mediaAritméticaToolStripMenuItem_Click);
            // 
            // médiaPonderadaToolStripMenuItem
            // 
            this.médiaPonderadaToolStripMenuItem.Name = "médiaPonderadaToolStripMenuItem";
            this.médiaPonderadaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.médiaPonderadaToolStripMenuItem.Text = "Média Ponderada";
            this.médiaPonderadaToolStripMenuItem.Click += new System.EventHandler(this.médiaPonderadaToolStripMenuItem_Click);
            // 
            // entrega2ToolStripMenuItem
            // 
            this.entrega2ToolStripMenuItem.Name = "entrega2ToolStripMenuItem";
            this.entrega2ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.entrega2ToolStripMenuItem.Text = "Entrega 2";
            // 
            // entrega3ToolStripMenuItem
            // 
            this.entrega3ToolStripMenuItem.Name = "entrega3ToolStripMenuItem";
            this.entrega3ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.entrega3ToolStripMenuItem.Text = "Entrega 3";
            // 
            // iMCToolStripMenuItem
            // 
            this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            this.iMCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.iMCToolStripMenuItem.Text = "IMC";
            // 
            // laçoDeRepetiçãoToolStripMenuItem
            // 
            this.laçoDeRepetiçãoToolStripMenuItem.Name = "laçoDeRepetiçãoToolStripMenuItem";
            this.laçoDeRepetiçãoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.laçoDeRepetiçãoToolStripMenuItem.Text = "Laço  de Repetição";
            this.laçoDeRepetiçãoToolStripMenuItem.Click += new System.EventHandler(this.laçoDeRepetiçãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 375);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema Gerenciador de Algoritmos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entrega1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrega2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrega3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaAritméticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaPonderadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laçoDeRepetiçãoToolStripMenuItem;
    }
}

