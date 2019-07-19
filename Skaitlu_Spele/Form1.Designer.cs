namespace Skaitlu_Spele
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
            this.uzminiLabel = new System.Windows.Forms.Label();
            this.minejumsLabel = new System.Windows.Forms.Label();
            this.pazinojums = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.minejums = new System.Windows.Forms.TextBox();
            this.minet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uzminiLabel
            // 
            this.uzminiLabel.AutoSize = true;
            this.uzminiLabel.Location = new System.Drawing.Point(36, 34);
            this.uzminiLabel.Name = "uzminiLabel";
            this.uzminiLabel.Size = new System.Drawing.Size(70, 13);
            this.uzminiLabel.TabIndex = 0;
            this.uzminiLabel.Text = "Uzmini skaitli!";
            // 
            // minejumsLabel
            // 
            this.minejumsLabel.AutoSize = true;
            this.minejumsLabel.Location = new System.Drawing.Point(15, 67);
            this.minejumsLabel.Name = "minejumsLabel";
            this.minejumsLabel.Size = new System.Drawing.Size(77, 13);
            this.minejumsLabel.TabIndex = 1;
            this.minejumsLabel.Text = "Tavs minējums";
            // 
            // pazinojums
            // 
            this.pazinojums.AutoSize = true;
            this.pazinojums.Location = new System.Drawing.Point(109, 114);
            this.pazinojums.Name = "pazinojums";
            this.pazinojums.Size = new System.Drawing.Size(59, 13);
            this.pazinojums.TabIndex = 2;
            this.pazinojums.Text = "pazinojums";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(181, 34);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(98, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Sākt no jauna";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // minejums
            // 
            this.minejums.Location = new System.Drawing.Point(98, 64);
            this.minejums.Name = "minejums";
            this.minejums.Size = new System.Drawing.Size(78, 20);
            this.minejums.TabIndex = 4;
            // 
            // minet
            // 
            this.minet.Location = new System.Drawing.Point(204, 64);
            this.minet.Name = "minet";
            this.minet.Size = new System.Drawing.Size(75, 23);
            this.minet.TabIndex = 5;
            this.minet.Text = "Minēt";
            this.minet.UseVisualStyleBackColor = true;
            this.minet.Click += new System.EventHandler(this.minet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 152);
            this.Controls.Add(this.minet);
            this.Controls.Add(this.minejums);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pazinojums);
            this.Controls.Add(this.minejumsLabel);
            this.Controls.Add(this.uzminiLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uzminiLabel;
        private System.Windows.Forms.Label minejumsLabel;
        private System.Windows.Forms.Label pazinojums;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox minejums;
        private System.Windows.Forms.Button minet;
    }
}

