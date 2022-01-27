using System.ComponentModel;

namespace ContactsApp.UI
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelName.Location = new System.Drawing.Point(12, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(318, 48);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "ContactsApp";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Location = new System.Drawing.Point(12, 71);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(318, 23);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Автор: Никита Дудик";
            // 
            // linkEmail
            // 
            this.linkEmail.Location = new System.Drawing.Point(0, 0);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(100, 23);
            this.linkEmail.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 6;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(12, 117);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(318, 23);
            this.labelVersion.TabIndex = 5;
            this.labelVersion.Text = "Версия";
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(12, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(318, 23);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "boratbir@yandex.ru";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 190);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkEmail);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 246);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(364, 246);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "О программе";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelVersion;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.LinkLabel linkEmail;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}