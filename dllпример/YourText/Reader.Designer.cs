namespace YourText
{
    partial class Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reader));
            this.LabelNameRead = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.valbox = new System.Windows.Forms.TextBox();
            this.ReadButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNameRead
            // 
            this.LabelNameRead.AutoSize = true;
            this.LabelNameRead.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameRead.Location = new System.Drawing.Point(15, 15);
            this.LabelNameRead.Name = "LabelNameRead";
            this.LabelNameRead.Size = new System.Drawing.Size(212, 23);
            this.LabelNameRead.TabIndex = 0;
            this.LabelNameRead.Text = "Имя вашего YourText:";
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namebox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namebox.Location = new System.Drawing.Point(15, 42);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(173, 23);
            this.namebox.TabIndex = 2;
            // 
            // valbox
            // 
            this.valbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.valbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valbox.Location = new System.Drawing.Point(15, 95);
            this.valbox.MaximumSize = new System.Drawing.Size(479, 150);
            this.valbox.MinimumSize = new System.Drawing.Size(479, 150);
            this.valbox.Multiline = true;
            this.valbox.Name = "valbox";
            this.valbox.ReadOnly = true;
            this.valbox.Size = new System.Drawing.Size(479, 150);
            this.valbox.TabIndex = 4;
            // 
            // ReadButton
            // 
            this.ReadButton.AutoSize = true;
            this.ReadButton.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadButton.Location = new System.Drawing.Point(250, 15);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(222, 58);
            this.ReadButton.TabIndex = 5;
            this.ReadButton.Text = "YourText";
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 275);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.valbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.LabelNameRead);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourText Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNameRead;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox valbox;
        private System.Windows.Forms.Label ReadButton;

    }
}