namespace BookStore
{
    partial class Form2
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBookButton = new System.Windows.Forms.Button();
            this.addBookSummaryField = new System.Windows.Forms.TextBox();
            this.bookSummary = new System.Windows.Forms.Label();
            this.addBookPublisherField = new System.Windows.Forms.TextBox();
            this.bookPublisher = new System.Windows.Forms.Label();
            this.addBookLanguageField = new System.Windows.Forms.TextBox();
            this.bookLanguage = new System.Windows.Forms.Label();
            this.addBookAuthorField = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.addBookTitleField = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addBookButton);
            this.panel3.Controls.Add(this.addBookSummaryField);
            this.panel3.Controls.Add(this.bookSummary);
            this.panel3.Controls.Add(this.addBookPublisherField);
            this.panel3.Controls.Add(this.bookPublisher);
            this.panel3.Controls.Add(this.addBookLanguageField);
            this.panel3.Controls.Add(this.bookLanguage);
            this.panel3.Controls.Add(this.addBookAuthorField);
            this.panel3.Controls.Add(this.bookAuthor);
            this.panel3.Controls.Add(this.addBookTitleField);
            this.panel3.Controls.Add(this.bookTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 414);
            this.panel3.TabIndex = 6;
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.Location = new System.Drawing.Point(5, 349);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(194, 59);
            this.addBookButton.TabIndex = 11;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // addBookSummaryField
            // 
            this.addBookSummaryField.Location = new System.Drawing.Point(5, 248);
            this.addBookSummaryField.Multiline = true;
            this.addBookSummaryField.Name = "addBookSummaryField";
            this.addBookSummaryField.Size = new System.Drawing.Size(194, 95);
            this.addBookSummaryField.TabIndex = 10;
            // 
            // bookSummary
            // 
            this.bookSummary.AutoSize = true;
            this.bookSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSummary.Location = new System.Drawing.Point(76, 228);
            this.bookSummary.Name = "bookSummary";
            this.bookSummary.Size = new System.Drawing.Size(57, 13);
            this.bookSummary.TabIndex = 9;
            this.bookSummary.Text = "Summary";
            // 
            // addBookPublisherField
            // 
            this.addBookPublisherField.Location = new System.Drawing.Point(5, 197);
            this.addBookPublisherField.Name = "addBookPublisherField";
            this.addBookPublisherField.Size = new System.Drawing.Size(194, 20);
            this.addBookPublisherField.TabIndex = 8;
            // 
            // bookPublisher
            // 
            this.bookPublisher.AutoSize = true;
            this.bookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPublisher.Location = new System.Drawing.Point(75, 172);
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.Size = new System.Drawing.Size(59, 13);
            this.bookPublisher.TabIndex = 7;
            this.bookPublisher.Text = "Publisher";
            // 
            // addBookLanguageField
            // 
            this.addBookLanguageField.Location = new System.Drawing.Point(5, 141);
            this.addBookLanguageField.Name = "addBookLanguageField";
            this.addBookLanguageField.Size = new System.Drawing.Size(194, 20);
            this.addBookLanguageField.TabIndex = 6;
            // 
            // bookLanguage
            // 
            this.bookLanguage.AutoSize = true;
            this.bookLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLanguage.Location = new System.Drawing.Point(73, 116);
            this.bookLanguage.Name = "bookLanguage";
            this.bookLanguage.Size = new System.Drawing.Size(63, 13);
            this.bookLanguage.TabIndex = 5;
            this.bookLanguage.Text = "Language";
            // 
            // addBookAuthorField
            // 
            this.addBookAuthorField.Location = new System.Drawing.Point(5, 85);
            this.addBookAuthorField.Name = "addBookAuthorField";
            this.addBookAuthorField.Size = new System.Drawing.Size(194, 20);
            this.addBookAuthorField.TabIndex = 4;
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthor.Location = new System.Drawing.Point(81, 60);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(44, 13);
            this.bookAuthor.TabIndex = 3;
            this.bookAuthor.Text = "Author";
            // 
            // addBookTitleField
            // 
            this.addBookTitleField.Location = new System.Drawing.Point(5, 29);
            this.addBookTitleField.Name = "addBookTitleField";
            this.addBookTitleField.Size = new System.Drawing.Size(194, 20);
            this.addBookTitleField.TabIndex = 2;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(73, 9);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(65, 13);
            this.bookTitle.TabIndex = 1;
            this.bookTitle.Text = "Book Title";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 414);
            this.Controls.Add(this.panel3);
            this.Name = "Form2";
            this.Text = "Add Book";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox addBookSummaryField;
        private System.Windows.Forms.Label bookSummary;
        private System.Windows.Forms.TextBox addBookPublisherField;
        private System.Windows.Forms.Label bookPublisher;
        private System.Windows.Forms.TextBox addBookLanguageField;
        private System.Windows.Forms.Label bookLanguage;
        private System.Windows.Forms.TextBox addBookAuthorField;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.TextBox addBookTitleField;
        private System.Windows.Forms.Label bookTitle;
    }
}