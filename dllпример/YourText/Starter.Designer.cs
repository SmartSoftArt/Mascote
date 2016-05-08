namespace YourText
{
    partial class Starter
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter));
            this.StartButAdd = new System.Windows.Forms.Button();
            this.StartButRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButAdd
            // 
            this.StartButAdd.BackColor = System.Drawing.SystemColors.Control;
            this.StartButAdd.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButAdd.Location = new System.Drawing.Point(42, 12);
            this.StartButAdd.Name = "StartButAdd";
            this.StartButAdd.Size = new System.Drawing.Size(269, 58);
            this.StartButAdd.TabIndex = 0;
            this.StartButAdd.Text = "Создать";
            this.StartButAdd.UseVisualStyleBackColor = false;
            this.StartButAdd.Click += new System.EventHandler(this.StartButAdd_Click);
            // 
            // StartButRead
            // 
            this.StartButRead.BackColor = System.Drawing.SystemColors.Control;
            this.StartButRead.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButRead.Location = new System.Drawing.Point(42, 121);
            this.StartButRead.Name = "StartButRead";
            this.StartButRead.Size = new System.Drawing.Size(269, 58);
            this.StartButRead.TabIndex = 1;
            this.StartButRead.Text = "Прочитать";
            this.StartButRead.UseVisualStyleBackColor = false;
            this.StartButRead.Click += new System.EventHandler(this.StartButRead_Click);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 191);
            this.Controls.Add(this.StartButRead);
            this.Controls.Add(this.StartButAdd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Starter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YourText";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButAdd;
        private System.Windows.Forms.Button StartButRead;
    }
}

