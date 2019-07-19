namespace Forms_Piemeri
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
            this.labelName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelName.Location = new System.Drawing.Point(27, 46);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Vārds";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(81, 43);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(166, 20);
            this.inputName.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(30, 105);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(217, 39);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(123, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "label2";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelSurname.Location = new System.Drawing.Point(12, 75);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(63, 18);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Uzvārds";
            // 
            // inputSurname
            // 
            this.inputSurname.Location = new System.Drawing.Point(81, 72);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.Size = new System.Drawing.Size(166, 20);
            this.inputSurname.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 168);
            this.Controls.Add(this.inputSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox inputSurname;
    }
}

