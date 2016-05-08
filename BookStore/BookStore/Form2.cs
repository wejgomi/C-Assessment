using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Initialize a list to store the user entered values for later usage on return
        private List<String> addListItem = new List<String>();

        //Add the book parameters to relevant values and populate the List to add a book, with the click of Add Book button
        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (addBookTitleField.Text != "" && addBookAuthorField.Text != "" && addBookPublisherField.Text != "")
            {
                addListItem.Add(addBookTitleField.Text);
                addListItem.Add(addBookAuthorField.Text);
                addListItem.Add(addBookLanguageField.Text);
                addListItem.Add(addBookPublisherField.Text);
                addListItem.Add(addBookSummaryField.Text);
                this.DialogResult = DialogResult.OK;
            }
            else { MessageBox.Show("Please fill in all fields!", "Warning"); }
        }
     
        //Declare a getter to return the populated list on demand
        public List<String> AddListItem
        {
            get { return addListItem; }
        }

    }
}
