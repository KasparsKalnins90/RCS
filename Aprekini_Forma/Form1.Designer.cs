namespace Aprekini_Forma
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
            this.PirmaisLabel = new System.Windows.Forms.Label();
            this.otraisLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pirmaisIevaditais = new System.Windows.Forms.TextBox();
            this.otraisIevaditais = new System.Windows.Forms.TextBox();
            this.rezultats = new System.Windows.Forms.TextBox();
            this.summa = new System.Windows.Forms.Button();
            this.starpiba = new System.Windows.Forms.Button();
            this.reizinajums = new System.Windows.Forms.Button();
            this.videjais = new System.Windows.Forms.Button();
            this.maksimala = new System.Windows.Forms.Button();
            this.minimalais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PirmaisLabel
            // 
            this.PirmaisLabel.AutoSize = true;
            this.PirmaisLabel.Location = new System.Drawing.Point(12, 25);
            this.PirmaisLabel.Name = "PirmaisLabel";
            this.PirmaisLabel.Size = new System.Drawing.Size(76, 13);
            this.PirmaisLabel.TabIndex = 0;
            this.PirmaisLabel.Text = "Pirmais Skaitlis";
            // 
            // otraisLabel
            // 
            this.otraisLabel.AutoSize = true;
            this.otraisLabel.Location = new System.Drawing.Point(12, 58);
            this.otraisLabel.Name = "otraisLabel";
            this.otraisLabel.Size = new System.Drawing.Size(70, 13);
            this.otraisLabel.TabIndex = 1;
            this.otraisLabel.Text = "Otrais Skaitlis";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 92);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(51, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Rezultats";
            // 
            // pirmaisIevaditais
            // 
            this.pirmaisIevaditais.Location = new System.Drawing.Point(122, 25);
            this.pirmaisIevaditais.Name = "pirmaisIevaditais";
            this.pirmaisIevaditais.Size = new System.Drawing.Size(100, 20);
            this.pirmaisIevaditais.TabIndex = 3;
            // 
            // otraisIevaditais
            // 
            this.otraisIevaditais.Location = new System.Drawing.Point(122, 58);
            this.otraisIevaditais.Name = "otraisIevaditais";
            this.otraisIevaditais.Size = new System.Drawing.Size(100, 20);
            this.otraisIevaditais.TabIndex = 4;
            // 
            // rezultats
            // 
            this.rezultats.Enabled = false;
            this.rezultats.Location = new System.Drawing.Point(122, 92);
            this.rezultats.Name = "rezultats";
            this.rezultats.Size = new System.Drawing.Size(100, 20);
            this.rezultats.TabIndex = 5;
            // 
            // summa
            // 
            this.summa.Location = new System.Drawing.Point(45, 158);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(75, 23);
            this.summa.TabIndex = 6;
            this.summa.Text = "+";
            this.summa.UseVisualStyleBackColor = true;
            this.summa.Click += new System.EventHandler(this.summa_Click);
            // 
            // starpiba
            // 
            this.starpiba.Location = new System.Drawing.Point(229, 157);
            this.starpiba.Name = "starpiba";
            this.starpiba.Size = new System.Drawing.Size(75, 23);
            this.starpiba.TabIndex = 7;
            this.starpiba.Text = "-";
            this.starpiba.UseVisualStyleBackColor = true;
            this.starpiba.Click += new System.EventHandler(this.starpiba_Click);
            // 
            // reizinajums
            // 
            this.reizinajums.Location = new System.Drawing.Point(45, 204);
            this.reizinajums.Name = "reizinajums";
            this.reizinajums.Size = new System.Drawing.Size(75, 23);
            this.reizinajums.TabIndex = 8;
            this.reizinajums.Text = "*";
            this.reizinajums.UseVisualStyleBackColor = true;
            this.reizinajums.Click += new System.EventHandler(this.reizinajums_Click);
            // 
            // videjais
            // 
            this.videjais.Location = new System.Drawing.Point(229, 204);
            this.videjais.Name = "videjais";
            this.videjais.Size = new System.Drawing.Size(75, 23);
            this.videjais.TabIndex = 9;
            this.videjais.Text = "AVG";
            this.videjais.UseVisualStyleBackColor = true;
            this.videjais.Click += new System.EventHandler(this.videjais_Click);
            // 
            // maksimala
            // 
            this.maksimala.Location = new System.Drawing.Point(45, 253);
            this.maksimala.Name = "maksimala";
            this.maksimala.Size = new System.Drawing.Size(75, 23);
            this.maksimala.TabIndex = 10;
            this.maksimala.Text = "MAX";
            this.maksimala.UseVisualStyleBackColor = true;
            this.maksimala.Click += new System.EventHandler(this.maksimala_Click);
            // 
            // minimalais
            // 
            this.minimalais.Location = new System.Drawing.Point(229, 253);
            this.minimalais.Name = "minimalais";
            this.minimalais.Size = new System.Drawing.Size(75, 23);
            this.minimalais.TabIndex = 11;
            this.minimalais.Text = "MIN";
            this.minimalais.UseVisualStyleBackColor = true;
            this.minimalais.Click += new System.EventHandler(this.minimalais_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 288);
            this.Controls.Add(this.minimalais);
            this.Controls.Add(this.maksimala);
            this.Controls.Add(this.videjais);
            this.Controls.Add(this.reizinajums);
            this.Controls.Add(this.starpiba);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.rezultats);
            this.Controls.Add(this.otraisIevaditais);
            this.Controls.Add(this.pirmaisIevaditais);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.otraisLabel);
            this.Controls.Add(this.PirmaisLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PirmaisLabel;
        private System.Windows.Forms.Label otraisLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox pirmaisIevaditais;
        private System.Windows.Forms.TextBox otraisIevaditais;
        private System.Windows.Forms.TextBox rezultats;
        private System.Windows.Forms.Button summa;
        private System.Windows.Forms.Button starpiba;
        private System.Windows.Forms.Button reizinajums;
        private System.Windows.Forms.Button videjais;
        private System.Windows.Forms.Button maksimala;
        private System.Windows.Forms.Button minimalais;
    }
}

