namespace ContactsApp.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanellnfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelVk = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxVk = new System.Windows.Forms.TextBox();
            this.leftTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanellnfo.SuspendLayout();
            this.leftTablePanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileMenuItem, this.editMenuItem, this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(878, 35);
            this.menuStrip.TabIndex = 1;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(65, 29);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(136, 30);
            this.exitMenuItem.Text = "Выход";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addContactMenuItem, this.editContactMenuItem, this.deleteContactMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(158, 29);
            this.editMenuItem.Text = "Редактирование";
            // 
            // addContactMenuItem
            // 
            this.addContactMenuItem.Name = "addContactMenuItem";
            this.addContactMenuItem.Size = new System.Drawing.Size(272, 30);
            this.addContactMenuItem.Text = "Добавить контакт";
            this.addContactMenuItem.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // editContactMenuItem
            // 
            this.editContactMenuItem.Name = "editContactMenuItem";
            this.editContactMenuItem.Size = new System.Drawing.Size(272, 30);
            this.editContactMenuItem.Text = "Редактировать контакт";
            this.editContactMenuItem.Click += new System.EventHandler(this.OnEditButtonClicked);
            // 
            // deleteContactMenuItem
            // 
            this.deleteContactMenuItem.Name = "deleteContactMenuItem";
            this.deleteContactMenuItem.Size = new System.Drawing.Size(272, 30);
            this.deleteContactMenuItem.Text = "Удалить контакт";
            this.deleteContactMenuItem.Click += new System.EventHandler(this.OnRemoveButtonClicked);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(96, 29);
            this.helpMenuItem.Text = "Помощь";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(197, 30);
            this.aboutMenuItem.Text = "О программе";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanellnfo, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.leftTablePanel, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(854, 603);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // tableLayoutPanellnfo
            // 
            this.tableLayoutPanellnfo.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanellnfo.ColumnCount = 2;
            this.tableLayoutPanellnfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanellnfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanellnfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanellnfo.Controls.Add(this.labelVk, 0, 5);
            this.tableLayoutPanellnfo.Controls.Add(this.labelFirstName, 0, 1);
            this.tableLayoutPanellnfo.Controls.Add(this.labelLastName, 0, 0);
            this.tableLayoutPanellnfo.Controls.Add(this.textBoxLastName, 1, 0);
            this.tableLayoutPanellnfo.Controls.Add(this.labelBirthday, 0, 2);
            this.tableLayoutPanellnfo.Controls.Add(this.labelPhone, 0, 3);
            this.tableLayoutPanellnfo.Controls.Add(this.labelEmail, 0, 4);
            this.tableLayoutPanellnfo.Controls.Add(this.textBoxFirstName, 1, 1);
            this.tableLayoutPanellnfo.Controls.Add(this.textBoxBirthday, 1, 2);
            this.tableLayoutPanellnfo.Controls.Add(this.textBoxPhone, 1, 3);
            this.tableLayoutPanellnfo.Controls.Add(this.textBoxEmail, 1, 4);
            this.tableLayoutPanellnfo.Controls.Add(this.textBoxVk, 1, 5);
            this.tableLayoutPanellnfo.Location = new System.Drawing.Point(304, 4);
            this.tableLayoutPanellnfo.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanellnfo.Name = "tableLayoutPanellnfo";
            this.tableLayoutPanellnfo.RowCount = 6;
            this.tableLayoutPanellnfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanellnfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanellnfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanellnfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanellnfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanellnfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanellnfo.Size = new System.Drawing.Size(546, 240);
            this.tableLayoutPanellnfo.TabIndex = 1;
            // 
            // labelVk
            // 
            this.labelVk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVk.Location = new System.Drawing.Point(4, 204);
            this.labelVk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVk.Name = "labelVk";
            this.labelVk.Size = new System.Drawing.Size(156, 31);
            this.labelVk.TabIndex = 10;
            this.labelVk.Text = "VK ID:";
            this.labelVk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFirstName.Location = new System.Drawing.Point(4, 44);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(156, 31);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Имя:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLastName.Location = new System.Drawing.Point(4, 4);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(156, 31);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Фамилия:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLastName.Location = new System.Drawing.Point(169, 7);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(373, 26);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBirthday.Location = new System.Drawing.Point(4, 84);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(156, 31);
            this.labelBirthday.TabIndex = 4;
            this.labelBirthday.Text = "Дата рождения:";
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhone.Location = new System.Drawing.Point(4, 124);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(156, 31);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Телефон:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEmail.Location = new System.Drawing.Point(4, 164);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(156, 31);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-Mail:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFirstName.Location = new System.Drawing.Point(169, 47);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(373, 26);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBirthday.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBirthday.Location = new System.Drawing.Point(169, 87);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.ReadOnly = true;
            this.textBoxBirthday.Size = new System.Drawing.Size(373, 26);
            this.textBoxBirthday.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPhone.Location = new System.Drawing.Point(169, 127);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(373, 26);
            this.textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Location = new System.Drawing.Point(169, 167);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(373, 26);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxVk
            // 
            this.textBoxVk.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVk.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxVk.Location = new System.Drawing.Point(169, 207);
            this.textBoxVk.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVk.Name = "textBoxVk";
            this.textBoxVk.ReadOnly = true;
            this.textBoxVk.Size = new System.Drawing.Size(373, 26);
            this.textBoxVk.TabIndex = 11;
            // 
            // leftTablePanel
            // 
            this.leftTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.leftTablePanel.ColumnCount = 2;
            this.leftTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.leftTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTablePanel.Controls.Add(this.labelSearch, 0, 0);
            this.leftTablePanel.Controls.Add(this.textBox1, 1, 0);
            this.leftTablePanel.Controls.Add(this.contactsListBox, 0, 1);
            this.leftTablePanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.leftTablePanel.Location = new System.Drawing.Point(3, 3);
            this.leftTablePanel.Name = "leftTablePanel";
            this.leftTablePanel.RowCount = 3;
            this.leftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.leftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.leftTablePanel.Size = new System.Drawing.Size(294, 597);
            this.leftTablePanel.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(3, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(69, 37);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Поиск:";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(78, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.OnQueryChanged);
            // 
            // contactsListBox
            // 
            this.leftTablePanel.SetColumnSpan(this.contactsListBox, 2);
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.ItemHeight = 20;
            this.contactsListBox.Location = new System.Drawing.Point(3, 40);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(288, 484);
            this.contactsListBox.TabIndex = 2;
            this.contactsListBox.SelectedValueChanged += new System.EventHandler(this.OnSelectedContactChanged);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.leftTablePanel.SetColumnSpan(this.buttonsPanel, 2);
            this.buttonsPanel.Controls.Add(this.buttonDelete);
            this.buttonsPanel.Controls.Add(this.buttonEdit);
            this.buttonsPanel.Controls.Add(this.buttonAdd);
            this.buttonsPanel.Location = new System.Drawing.Point(3, 544);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(288, 50);
            this.buttonsPanel.TabIndex = 3;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::ContactsApp.UI.Properties.Resources.Delete;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Location = new System.Drawing.Point(103, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(44, 44);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnRemoveButtonClicked);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackgroundImage = global::ContactsApp.UI.Properties.Resources.Edit;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(53, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(44, 44);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.OnEditButtonClicked);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::ContactsApp.UI.Properties.Resources.Add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(44, 44);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OnAddButtonClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 653);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanellnfo.ResumeLayout(false);
            this.tableLayoutPanellnfo.PerformLayout();
            this.leftTablePanel.ResumeLayout(false);
            this.leftTablePanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ErrorProvider errorProvider;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanellnfo;
        private System.Windows.Forms.Label labelVk;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxVk;

        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;

        private System.Windows.Forms.Panel buttonsPanel;

        private System.Windows.Forms.ListBox contactsListBox;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TableLayoutPanel leftTablePanel;
        private System.Windows.Forms.Label labelSearch;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;

        #endregion
    }
}