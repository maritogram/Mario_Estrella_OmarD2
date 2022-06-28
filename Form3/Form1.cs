using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool adding = false;
        List<Contact> Contacts = new List<Contact>();


        private void Add_Click(object sender, EventArgs e)
        {

            EmptyControls();
            EnabledControls(true);
            adding = true;

            Add.Enabled = false;
            Delete.Enabled = false;
            Load.Enabled = false;
            Save.Enabled = true;


        }


       private void EmptyControls()
        {
            ID.Text = string.Empty;
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            Address.Text = string.Empty;
            City.Text = string.Empty;
            Email.Text = string.Empty;
            Phone.Text = string.Empty;
            State.Text = string.Empty;

        }

        private void EnabledControls(bool enable)
        {
            ID.Enabled = enable;
            FirstName.Enabled = enable;
            LastName.Enabled = enable;
            Address.Enabled = enable;
            City.Enabled = enable;
            Email.Enabled = enable;
            Phone.Enabled = enable;
            State.Enabled = enable;

        }


        private void Save_Click(object sender, EventArgs e)
        {

            if (adding == true)
            {

                var contact = new Contact
                {
                    ID = ID.Text,
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Address = Address.Text,
                    City = City.Text,
                    State = State.Text,
                    Phone = Phone.Text,
                    Email = Email.Text,
                    CretedDate = DateTime.Now
                };


                Contacts.Add(contact);

                MessageBox.Show("Fue agregado.");

                EmptyControls();
                EnabledControls(false);

                Add.Enabled = true;
                Load.Enabled = true;
                Delete.Enabled = true;
                Save.Enabled = false;

                GetContacts();
                
            }
            else
            {

            }

        }

        private void Load_Click(object sender, EventArgs e)
        {
            GetContacts();
            MessageBox.Show("Se ha actualizado el registro.");
        }

        private void GetContacts()
        {

            dgcontact.DataSource = null;
            dgcontact.DataSource = Contacts;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Contacts.RemoveAt(0);
            MessageBox.Show("Se elimino el primer registro. Por favor haga click en Load.");

            dgcontact.DataSource = Contacts;
    
        }

       
    }

    public class Contact
    {

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CretedDate { get; set; }   

    }
}
