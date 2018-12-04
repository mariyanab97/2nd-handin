using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2ndHandInProgramming
{
    public partial class CreateAndFilterCustomers : System.Web.UI.Page
    {
        private CustomerDatabase CustomerListDatabase;
        private List<Customer> CustomersInTheList;
        private Customer c;

        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            if (Application["CustomerListRegister"] == null)
                Application["CustomerListRegister"] = new CustomerDatabase();

            Application.UnLock();

            CustomerListDatabase = (CustomerDatabase)Application["CustomerListRegister"];
            UpdateCustomerList();
            EnableButtonAddCustomer();
        }

        public void UpdateCustomerList()
        {
            ListBoxCustomers.Items.Clear();
            CustomersInTheList = CustomerListDatabase.ShowCustomerList();

            foreach (Customer ctm in CustomersInTheList)
            {
                ListBoxCustomers.Items.Add(ctm.ToString());
            }
        }

        public void EnableButtonAddCustomer()
        {
            //if (string.IsNullOrWhiteSpace(TextBoxFirstName.Text) ||
            //    string.IsNullOrWhiteSpace(TextBoxLastName.Text) ||
            //    string.IsNullOrWhiteSpace(TextBoxZipCode.Text) ||
            //    DropDownListSelectRegion.SelectedValue == "Select" ||
            //    string.IsNullOrWhiteSpace(TextBoxAge.Text) ||
            //    string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            //{
            //    ButtonAddCustomer.Enabled = false;
            //}   
            
            //else
            //{
            //    ButtonAddCustomer.Enabled = true;
            //}
        }

        protected void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            c = new Customer(TextBoxFirstName.Text, TextBoxLastName.Text, int.Parse(TextBoxZipCode.Text), DropDownListSelectRegion.SelectedValue, int.Parse(TextBoxAge.Text), TextBoxPassword.Text);


            Application.Lock();
            CustomerListDatabase = (CustomerDatabase)Application["CustomerListRegister"];
            CustomerListDatabase.AddCustomerToList(c);
            Application["CustomerListRegister"] = CustomerListDatabase;
            Application.UnLock();

            LabelMessages.Text = c.ToString();

            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxZipCode.Text = "";
            DropDownListSelectRegion.SelectedValue = "Select";
            TextBoxAge.Text = "";
            TextBoxPassword.Text = "";
            UpdateCustomerList();
            EnableButtonAddCustomer();
        }

        protected void ButtonAllCustomers_Click(object sender, EventArgs e)
        {
            UpdateCustomerList();
            LabelAllCustomers.Text = (sender as Button).Text;
        }

        protected void RegionButton_Click(object sender, EventArgs e)
        {
            ListBoxCustomers.Items.Clear();

            var regionFilterList = CustomersInTheList.Where(c => c.Region.Equals((sender as Button).Text));
            foreach (var ctm in regionFilterList)
            {
                ListBoxCustomers.Items.Add(ctm.ToString());
            }

            LabelAllCustomers.Text = (sender as Button).Text;
        }

        protected void All_TextBoxChanged(object sender, EventArgs e)
        {
            EnableButtonAddCustomer();
        }

        protected void DropDownListSelectRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtonAddCustomer();
        }

        protected void ListBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}