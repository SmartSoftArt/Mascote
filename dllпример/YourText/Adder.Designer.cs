namespace YourText
{
    partial class Adder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adder));
            this.LabelNameAdd = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.valbox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNameAdd
            // 
            this.LabelNameAdd.AutoSize = true;
            this.LabelNameAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameAdd.Location = new System.Drawing.Point(15, 15);
            this.LabelNameAdd.Name = "LabelNameAdd";
            this.LabelNameAdd.Size = new System.Drawing.Size(173, 23);
            this.LabelNameAdd.TabIndex = 0;
            this.LabelNameAdd.Text = "Имя для YourText:";
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namebox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namebox.Location = new System.Drawing.Point(15, 42);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(173, 23);
            this.namebox.TabIndex = 1;
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
            this.valbox.Size = new System.Drawing.Size(479, 150);
            this.valbox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(250, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(222, 58);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "YourText";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 275);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.valbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.LabelNameAdd);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Adder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourText Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNameAdd;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox valbox;
        private System.Windows.Forms.Label AddButton;
    }
}