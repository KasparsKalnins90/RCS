namespace Valutu_kalkulators
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
            this.uzUSD = new System.Windows.Forms.Button();
            this.uzEur = new System.Windows.Forms.Button();
            this.ievaditieEur = new System.Windows.Forms.TextBox();
            this.ievaditieUSD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uzUSD
            // 
            this.uzUSD.Location = new System.Drawing.Point(146, 42);
            this.uzUSD.Name = "uzUSD";
            this.uzUSD.Size = new System.Drawing.Size(75, 23);
            this.uzUSD.TabIndex = 0;
            this.uzUSD.Text = "Uz USD";
            this.uzUSD.UseVisualStyleBackColor = true;
            this.uzUSD.Click += new System.EventHandler(this.uzUSD_Click);
            // 
            // uzEur
            // 
            this.uzEur.Location = new System.Drawing.Point(146, 105);
            this.uzEur.Name = "uzEur";
            this.uzEur.Size = new System.Drawing.Size(75, 23);
            this.uzEur.TabIndex = 1;
            this.uzEur.Text = "Uz EUR";
            this.uzEur.UseVisualStyleBackColor = true;
            this.uzEur.Click += new System.EventHandler(this.uzEur_Click);
            // 
            // ievaditieEur
            // 
            this.ievaditieEur.Location = new System.Drawing.Point(23, 44);
            this.ievaditieEur.Name = "ievaditieEur";
            this.ievaditieEur.Size = new System.Drawing.Size(100, 20);
            this.ievaditieEur.TabIndex = 2;
            // 
            // ievaditieUSD
            // 
            this.ievaditieUSD.Location = new System.Drawing.Point(23, 107);
            this.ievaditieUSD.Name = "ievaditieUSD";
            this.ievaditieUSD.Size = new System.Drawing.Size(100, 20);
            this.ievaditieUSD.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 178);
            this.Controls.Add(this.ievaditieUSD);
            this.Controls.Add(this.ievaditieEur);
            this.Controls.Add(this.uzEur);
            this.Controls.Add(this.uzUSD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uzUSD;
        private System.Windows.Forms.Button uzEur;
        private System.Windows.Forms.TextBox ievaditieEur;
        private System.Windows.Forms.TextBox ievaditieUSD;
    }
}

