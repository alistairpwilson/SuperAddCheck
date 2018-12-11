namespace SuperAddCheck
{
    partial class FrmSuperAddCheck
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
            this.CmbVersion = new System.Windows.Forms.ComboBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbVersion
            // 
            this.CmbVersion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVersion.FormattingEnabled = true;
            this.CmbVersion.Location = new System.Drawing.Point(37, 48);
            this.CmbVersion.Name = "CmbVersion";
            this.CmbVersion.Size = new System.Drawing.Size(121, 21);
            this.CmbVersion.TabIndex = 0;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(164, 48);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(75, 23);
            this.BtnCheck.TabIndex = 1;
            this.BtnCheck.Text = "Checksum";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(164, 77);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(75, 23);
            this.BtnQuit.TabIndex = 2;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // FrmSuperAddCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 236);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.CmbVersion);
            this.Name = "FrmSuperAddCheck";
            this.Text = "UIAddCheck";
            this.Load += new System.EventHandler(this.FrmSuperAddCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbVersion;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnQuit;
    }
}

