using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare a List of Books objects to store the book list
        public List<Books> book = new List<Books>();

        //Declare a public class to initialize Books object
        public class Books
        {
            String title;
            String author;
            String language;
            String publisher;
            String summary;

            //Declare a constructor to store the values as defined
            public Books(String title, String author, String language, String publisher, String summary)
            {
                this.title = title;
                this.author = author;
                this.language = language;
                this.publisher = publisher;
                this.summary = summary;
            }

            //Setters-getters to dynamically obtain and store object variables
            public String Title
            {
                get { return title; }
                set { title = value; }
            }

            public String Author
            {
                get { return author; }
                set { author = value; }
            }

            public String Language
            {
                get { return language; }
                set { language = value; }
            }

            public String Publisher
            {
                get { return publisher; }
                set { publisher = value; }
            }

            public String Summary
            {
                get { return summary; }
                set { summary = value; }
            }
        }

        //Set the form as single column initially and load the starting list of books into the List
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Size = new Size(236, 400);
            tableLayoutPanel1.ColumnStyles[0].Width = 100;
            tableLayoutPanel1.ColumnStyles[1].Width = 0;

            book.Add(new Books("Harry Potter", "J.K. Rowling", "English", "Pottermore", "On Harry's eleventh birthday, a great beetle-eyed giant of a man called Rubeus Hagrid bursts in with some astonishing news: Harry Potter is a wizard, and he has a place at Hogwarts School of Witchcraft and Wizardry. An incredible adventure is about to begin!"));
            book.Add(new Books("I-Robot", "Isaac Asimov", "English", "Bantam Books", " In I, Robot, Asimov chronicles the development of the robot through a series of interlinked stories: from its primitive origins in the present to its ultimate perfection in the not-so-distant future--a future in which humanity itself may be rendered obsolete."));
            book.Add(new Books("Les Miserables", "Victor Hugo", "French", "Random House Publishing", "Novel Set in the post-Napoleonic era just after the French Revolution, Les Misérables is the story of Jean Valjean, a convict, who has just been released from prison after serving 19 years for stealing a loaf of bread."));
            book.Add(new Books("Life of Pi", "Yann Martel", "English", "Canongate Books", "The son of a zookeeper, Pi Patel has an encyclopedic knowledge of animal behavior and a fervent love of stories."));
            book.Add(new Books("The Hobbit", "J.R.R. Tolkien", "English", "Houghton Mifflin Harcourt", "Chronicles the adventures of Bilbo Baggins, who embarks on a quest to reclaim stolen treasure from the dragon Smaug, along with his dwarve companions and the wizard Gandalf, and unwittingly returns to the Shire with a Ring of Power."));

            //Populate the Listbox from booknames stored in List
            foreach (var b in book)
            {
                listBox1.Items.Add(b.Title);
            }
        }

        //Load the 2nd form to add books into the List and Listbox, initialized as a dialog to complete upon return, with the click of add book button
        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 dialog = new Form2())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.listBox1.Items.Add(dialog.AddListItem.First());
                    book.Add(new Books(dialog.AddListItem[0], dialog.AddListItem[1], dialog.AddListItem[2], dialog.AddListItem[3], dialog.AddListItem[4]));
                }
            }
        }

        //Remove the selected book with the click of remove button
        private void button2_Click(object sender, EventArgs e)
        {
            book.RemoveAll(a => a.Title == (string)listBox1.SelectedItem);
            listBox1.Items.Remove((string)listBox1.SelectedItem);
        }

        //Set a dynamic web address based on user selected book and do a google books search with the button click
        private void button3_Click(object sender, EventArgs e)
        {
            if (bookNameField.Text != "")
            {
                Process.Start(("https://www.google.co.uk/search?tbo=p&tbm=bks&q=intitle:" + bookNameField.Text + "+inauthor:" + bookAuthorField.Text + "+inpublisher:" + bookPublisherField.Text + "&num=10"));
            }
            else { MessageBox.Show("Please select a book first!","Error"); }
        }

        //Exit button to terminate application
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Expand the window with a second column and load the parameters defined for selected book
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var b in book)
            {
                if((string) listBox1.SelectedItem == b.Title)
                {
                    this.Size = new Size(420, 400);
                    tableLayoutPanel1.ColumnStyles[0].Width = 54;
                    tableLayoutPanel1.ColumnStyles[1].Width = 46;
                    bookNameField.Text = b.Title;
                    bookAuthorField.Text = b.Author;
                    bookLanguageField.Text = b.Language;
                    bookPublisherField.Text = b.Publisher;
                    bookSummaryField.Text = b.Summary;
                }
            }
        }
    }
}
