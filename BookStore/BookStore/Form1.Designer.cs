namespace BookStore
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookSummaryField = new System.Windows.Forms.TextBox();
            this.bookSummary = new System.Windows.Forms.Label();
            this.bookPublisherField = new System.Windows.Forms.TextBox();
            this.bookPublisher = new System.Windows.Forms.Label();
            this.bookLanguageField = new System.Windows.Forms.TextBox();
            this.bookLanguage = new System.Windows.Forms.Label();
            this.bookAuthorField = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.bookNameField = new System.Windows.Forms.TextBox();
            this.bookTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 349);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(0, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(0, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search Online";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(0, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(0, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 186);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Store";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bookSummaryField);
            this.panel3.Controls.Add(this.bookSummary);
            this.panel3.Controls.Add(this.bookPublisherField);
            this.panel3.Controls.Add(this.bookPublisher);
            this.panel3.Controls.Add(this.bookLanguageField);
            this.panel3.Controls.Add(this.bookLanguage);
            this.panel3.Controls.Add(this.bookAuthorField);
            this.panel3.Controls.Add(this.bookAuthor);
            this.panel3.Controls.Add(this.bookNameField);
            this.panel3.Controls.Add(this.bookTitle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 349);
            this.panel3.TabIndex = 5;
            // 
            // bookSummaryField
            // 
            this.bookSummaryField.Location = new System.Drawing.Point(5, 268);
            this.bookSummaryField.Multiline = true;
            this.bookSummaryField.Name = "bookSummaryField";
            this.bookSummaryField.Size = new System.Drawing.Size(168, 75);
            this.bookSummaryField.TabIndex = 10;
            // 
            // bookSummary
            // 
            this.bookSummary.AutoSize = true;
            this.bookSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookSummary.Location = new System.Drawing.Point(63, 248);
            this.bookSummary.Name = "bookSummary";
            this.bookSummary.Size = new System.Drawing.Size(57, 13);
            this.bookSummary.TabIndex = 9;
            this.bookSummary.Text = "Summary";
            // 
            // bookPublisherField
            // 
            this.bookPublisherField.Location = new System.Drawing.Point(5, 217);
            this.bookPublisherField.Name = "bookPublisherField";
            this.bookPublisherField.Size = new System.Drawing.Size(168, 20);
            this.bookPublisherField.TabIndex = 8;
            // 
            // bookPublisher
            // 
            this.bookPublisher.AutoSize = true;
            this.bookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPublisher.Location = new System.Drawing.Point(61, 192);
            this.bookPublisher.Name = "bookPublisher";
            this.bookPublisher.Size = new System.Drawing.Size(59, 13);
            this.bookPublisher.TabIndex = 7;
            this.bookPublisher.Text = "Publisher";
            // 
            // bookLanguageField
            // 
            this.bookLanguageField.Location = new System.Drawing.Point(5, 161);
            this.bookLanguageField.Name = "bookLanguageField";
            this.bookLanguageField.Size = new System.Drawing.Size(168, 20);
            this.bookLanguageField.TabIndex = 6;
            // 
            // bookLanguage
            // 
            this.bookLanguage.AutoSize = true;
            this.bookLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLanguage.Location = new System.Drawing.Point(59, 136);
            this.bookLanguage.Name = "bookLanguage";
            this.bookLanguage.Size = new System.Drawing.Size(63, 13);
            this.bookLanguage.TabIndex = 5;
            this.bookLanguage.Text = "Language";
            // 
            // bookAuthorField
            // 
            this.bookAuthorField.Location = new System.Drawing.Point(5, 105);
            this.bookAuthorField.Name = "bookAuthorField";
            this.bookAuthorField.Size = new System.Drawing.Size(168, 20);
            this.bookAuthorField.TabIndex = 4;
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthor.Location = new System.Drawing.Point(68, 80);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(44, 13);
            this.bookAuthor.TabIndex = 3;
            this.bookAuthor.Text = "Author";
            // 
            // bookNameField
            // 
            this.bookNameField.Location = new System.Drawing.Point(5, 49);
            this.bookNameField.Name = "bookNameField";
            this.bookNameField.Size = new System.Drawing.Size(168, 20);
            this.bookNameField.TabIndex = 2;
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(57, 29);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(65, 13);
            this.bookTitle.TabIndex = 1;
            this.bookTitle.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TrueFalse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox bookSummaryField;
        private System.Windows.Forms.Label bookSummary;
        private System.Windows.Forms.TextBox bookPublisherField;
        private System.Windows.Forms.Label bookPublisher;
        private System.Windows.Forms.TextBox bookLanguageField;
        private System.Windows.Forms.Label bookLanguage;
        private System.Windows.Forms.TextBox bookAuthorField;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.TextBox bookNameField;
        private System.Windows.Forms.Label bookTitle;
    }
}

