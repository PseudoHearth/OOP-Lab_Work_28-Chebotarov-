namespace ООП_ЛР_27__Чеботарьов_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.driveComboBox = new System.Windows.Forms.ComboBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.propertiesRichTextBox = new System.Windows.Forms.TextBox();
            this.viewSecurityButton = new System.Windows.Forms.Button();
            this.viewPropertiesButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.viewContentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // driveComboBox
            // 
            this.driveComboBox.FormattingEnabled = true;
            this.driveComboBox.Location = new System.Drawing.Point(62, 66);
            this.driveComboBox.Name = "driveComboBox";
            this.driveComboBox.Size = new System.Drawing.Size(110, 21);
            this.driveComboBox.TabIndex = 0;
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(12, 99);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(258, 238);
            this.fileListBox.TabIndex = 1;
            // 
            // directoryListBox
            // 
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.Location = new System.Drawing.Point(276, 99);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(258, 238);
            this.directoryListBox.TabIndex = 2;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(173, 12);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(135, 20);
            this.filterTextBox.TabIndex = 3;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(197, 38);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(90, 33);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "->";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Disc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            // 
            // propertiesRichTextBox
            // 
            this.propertiesRichTextBox.Location = new System.Drawing.Point(657, 562);
            this.propertiesRichTextBox.Multiline = true;
            this.propertiesRichTextBox.Name = "propertiesRichTextBox";
            this.propertiesRichTextBox.Size = new System.Drawing.Size(389, 69);
            this.propertiesRichTextBox.TabIndex = 7;
            // 
            // viewSecurityButton
            // 
            this.viewSecurityButton.Location = new System.Drawing.Point(28, 607);
            this.viewSecurityButton.Name = "viewSecurityButton";
            this.viewSecurityButton.Size = new System.Drawing.Size(157, 23);
            this.viewSecurityButton.TabIndex = 9;
            this.viewSecurityButton.Text = "Security";
            this.viewSecurityButton.UseVisualStyleBackColor = true;
            this.viewSecurityButton.Click += new System.EventHandler(this.viewSecurityButton_Click);
            // 
            // viewPropertiesButton
            // 
            this.viewPropertiesButton.Location = new System.Drawing.Point(28, 549);
            this.viewPropertiesButton.Name = "viewPropertiesButton";
            this.viewPropertiesButton.Size = new System.Drawing.Size(157, 23);
            this.viewPropertiesButton.TabIndex = 10;
            this.viewPropertiesButton.Text = "Properties";
            this.viewPropertiesButton.UseVisualStyleBackColor = true;
            this.viewPropertiesButton.Click += new System.EventHandler(this.viewPropertiesButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(568, 82);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(469, 446);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(264, 353);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(298, 277);
            this.contentTextBox.TabIndex = 12;
            // 
            // viewContentButton
            // 
            this.viewContentButton.Location = new System.Drawing.Point(28, 578);
            this.viewContentButton.Name = "viewContentButton";
            this.viewContentButton.Size = new System.Drawing.Size(157, 23);
            this.viewContentButton.TabIndex = 13;
            this.viewContentButton.Text = "Content";
            this.viewContentButton.UseVisualStyleBackColor = true;
            this.viewContentButton.Click += new System.EventHandler(this.viewContentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 657);
            this.Controls.Add(this.viewContentButton);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.viewPropertiesButton);
            this.Controls.Add(this.viewSecurityButton);
            this.Controls.Add(this.propertiesRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.directoryListBox);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.driveComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox driveComboBox;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox propertiesRichTextBox;
        private System.Windows.Forms.Button viewSecurityButton;
        private System.Windows.Forms.Button viewPropertiesButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button viewContentButton;
    }
}

