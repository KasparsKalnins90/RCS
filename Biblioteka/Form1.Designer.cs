namespace Biblioteka
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
            this.PanemtGramatu = new System.Windows.Forms.Button();
            this.IesniegtGramatu = new System.Windows.Forms.Button();
            this.NosaukumaTextBox = new System.Windows.Forms.TextBox();
            this.NosaukuaLabel = new System.Windows.Forms.Label();
            this.GramatuSarakstsLabel = new System.Windows.Forms.Label();
            this.GramatuSarakstsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PanemtGramatu
            // 
            this.PanemtGramatu.Location = new System.Drawing.Point(154, 70);
            this.PanemtGramatu.Name = "PanemtGramatu";
            this.PanemtGramatu.Size = new System.Drawing.Size(97, 23);
            this.PanemtGramatu.TabIndex = 0;
            this.PanemtGramatu.Text = "Paņemt Grāmatu";
            this.PanemtGramatu.UseVisualStyleBackColor = true;
            this.PanemtGramatu.Click += new System.EventHandler(this.PanemtGramatu_Click);
            // 
            // IesniegtGramatu
            // 
            this.IesniegtGramatu.Location = new System.Drawing.Point(278, 69);
            this.IesniegtGramatu.Name = "IesniegtGramatu";
            this.IesniegtGramatu.Size = new System.Drawing.Size(102, 23);
            this.IesniegtGramatu.TabIndex = 1;
            this.IesniegtGramatu.Text = "Iesniegt Grāmatu";
            this.IesniegtGramatu.UseVisualStyleBackColor = true;
            this.IesniegtGramatu.Click += new System.EventHandler(this.IesniegtGramatu_Click);
            // 
            // NosaukumaTextBox
            // 
            this.NosaukumaTextBox.Location = new System.Drawing.Point(36, 72);
            this.NosaukumaTextBox.Name = "NosaukumaTextBox";
            this.NosaukumaTextBox.Size = new System.Drawing.Size(100, 20);
            this.NosaukumaTextBox.TabIndex = 2;
            // 
            // NosaukuaLabel
            // 
            this.NosaukuaLabel.AutoSize = true;
            this.NosaukuaLabel.Location = new System.Drawing.Point(12, 56);
            this.NosaukuaLabel.Name = "NosaukuaLabel";
            this.NosaukuaLabel.Size = new System.Drawing.Size(140, 13);
            this.NosaukuaLabel.TabIndex = 3;
            this.NosaukuaLabel.Text = "Ievadi grāmatas nosaukumu";
            // 
            // GramatuSarakstsLabel
            // 
            this.GramatuSarakstsLabel.AutoSize = true;
            this.GramatuSarakstsLabel.Location = new System.Drawing.Point(137, 128);
            this.GramatuSarakstsLabel.Name = "GramatuSarakstsLabel";
            this.GramatuSarakstsLabel.Size = new System.Drawing.Size(131, 13);
            this.GramatuSarakstsLabel.TabIndex = 4;
            this.GramatuSarakstsLabel.Text = "Grāmatu atlikumu saraksts";
            // 
            // GramatuSarakstsTextBox
            // 
            this.GramatuSarakstsTextBox.Location = new System.Drawing.Point(36, 144);
            this.GramatuSarakstsTextBox.Multiline = true;
            this.GramatuSarakstsTextBox.Name = "GramatuSarakstsTextBox";
            this.GramatuSarakstsTextBox.Size = new System.Drawing.Size(329, 144);
            this.GramatuSarakstsTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 298);
            this.Controls.Add(this.GramatuSarakstsTextBox);
            this.Controls.Add(this.GramatuSarakstsLabel);
            this.Controls.Add(this.NosaukuaLabel);
            this.Controls.Add(this.NosaukumaTextBox);
            this.Controls.Add(this.IesniegtGramatu);
            this.Controls.Add(this.PanemtGramatu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PanemtGramatu;
        private System.Windows.Forms.Button IesniegtGramatu;
        private System.Windows.Forms.TextBox NosaukumaTextBox;
        private System.Windows.Forms.Label NosaukuaLabel;
        private System.Windows.Forms.Label GramatuSarakstsLabel;
        private System.Windows.Forms.TextBox GramatuSarakstsTextBox;
    }
}

