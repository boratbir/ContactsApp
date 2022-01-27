using System.ComponentModel;

namespace ContactsApp.UI
{
    partial class EditContactForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel_Edit = new System.Windows.Forms.TableLayoutPanel();
            this.labelIdVk = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxIdVk = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelLastName = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Edit
            // 
            this.tableLayoutPanel_Edit.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Edit.ColumnCount = 2;
            this.tableLayoutPanel_Edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel_Edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Edit.Controls.Add(this.labelIdVk, 0, 5);
            this.tableLayoutPanel_Edit.Controls.Add(this.labelEmail, 0, 4);
            this.tableLayoutPanel_Edit.Controls.Add(this.labelPhone, 0, 3);
            this.tableLayoutPanel_Edit.Controls.Add(this.labelBirthday, 0, 2);
            this.tableLayoutPanel_Edit.Controls.Add(this.labelFirstName, 0, 1);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBoxLastName, 1, 0);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBoxFirstName, 1, 1);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBoxEmail, 1, 4);
            this.tableLayoutPanel_Edit.Controls.Add(this.textBoxIdVk, 1, 5);
            this.tableLayoutPanel_Edit.Controls.Add(this.dateTimePickerBirthday, 1, 2);
            this.tableLayoutPanel_Edit.Controls.Add(this.labelLastName, 0, 0);
            this.tableLayoutPanel_Edit.Controls.Add(this.maskedTextBoxPhone, 1, 3);
            this.tableLayoutPanel_Edit.Location = new System.Drawing.Point(15, 16);
            this.tableLayoutPanel_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel_Edit.Name = "tableLayoutPanel_Edit";
            this.tableLayoutPanel_Edit.RowCount = 6;
            this.tableLayoutPanel_Edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel_Edit.Size = new System.Drawing.Size(638, 232);
            this.tableLayoutPanel_Edit.TabIndex = 0;
            // 
            // labelIdVk
            // 
            this.labelIdVk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIdVk.Location = new System.Drawing.Point(4, 195);
            this.labelIdVk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdVk.Name = "labelIdVk";
            this.labelIdVk.Size = new System.Drawing.Size(181, 39);
            this.labelIdVk.TabIndex = 11;
            this.labelIdVk.Text = "ID ВКонтакте:";
            this.labelIdVk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEmail.Location = new System.Drawing.Point(4, 156);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(181, 39);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "E-Mail:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhone.Location = new System.Drawing.Point(4, 117);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(181, 39);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Телефон:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBirthday.Location = new System.Drawing.Point(4, 78);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(181, 39);
            this.labelBirthday.TabIndex = 8;
            this.labelBirthday.Text = "Дата рождения:";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFirstName.Location = new System.Drawing.Point(4, 39);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(181, 39);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.Location = new System.Drawing.Point(224, 4);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(410, 26);
            this.textBoxLastName.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.Location = new System.Drawing.Point(224, 43);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(410, 26);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(224, 160);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(410, 26);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxIdVk
            // 
            this.textBoxIdVk.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdVk.Location = new System.Drawing.Point(224, 199);
            this.textBoxIdVk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdVk.Name = "textBoxIdVk";
            this.textBoxIdVk.Size = new System.Drawing.Size(410, 26);
            this.textBoxIdVk.TabIndex = 5;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(224, 82);
            this.dateTimePickerBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(410, 26);
            this.dateTimePickerBirthday.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLastName.Location = new System.Drawing.Point(4, 0);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(181, 39);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Фамилия:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(224, 123);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxPhone.Mask = "+7 (000) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(410, 26);
            this.maskedTextBoxPhone.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancel.Location = new System.Drawing.Point(546, 270);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 36);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.OnCancelButtonClicked);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOk.Location = new System.Drawing.Point(435, 270);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(103, 36);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.OnOkButtonClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 319);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tableLayoutPanel_Edit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(990, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(688, 350);
            this.Name = "EditContactForm";
            this.Text = "Редактирование контакта";
            this.tableLayoutPanel_Edit.ResumeLayout(false);
            this.tableLayoutPanel_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxIdVk;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelIdVk;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Edit;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}