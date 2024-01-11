using gui_cp2.ui.extradatachange;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gui_cp2
{
    public partial class NewPersonCreation : Form
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public List<Address> addresses { get; set; }
        public List<Telephone> telephones { get; set; }
        public Person res = null;
        public NewPersonCreation(Person person)
        {

            InitializeComponent();
            if (person != null)
            {
                _tbSurname.Text = person.LastName;
                _tbName.Text = person.FirstName;
                _tbEmail.Text = person.Email;
                addresses = person.Addresses;
                telephones = person.Telephones;
                res = person;
            }
            else
            {
                this.addresses = new List<Address>();
                this.telephones = new List<Telephone>();
            }
        }

        // События при взаимодействии с гуйней.
        private void _btnCreate_Click(object sender, EventArgs e)
        {
            this.lName = _tbSurname.Text;
            this.fName = _tbName.Text;
            this.email = _tbEmail.Text;

            try
            {
                if (res != null)
                {

                    res.FirstName = this.fName;
                    res.LastName = this.fName;
                    res.Email = this.email;
                    res.Addresses = this.addresses;
                    res.Telephones = this.telephones;
                }
                else
                {
                    res = new Person(
                        this.fName,
                        this.lName,
                        this.email,
                        this.addresses,
                        this.telephones
                    );
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _btnShowTlphForm_Click(object sender, EventArgs e)
        {
            using (var extraTlphForm = new ExtraTlphChange(this.telephones))
            {
                var res = extraTlphForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.telephones = extraTlphForm.telephones;
                }
            }
        }

        private void _btnShowAddrForm_Click(object sender, EventArgs e)
        {
            using (var extraAddrForm = new ExtraAddrChange(this.addresses))
            {
                var res = extraAddrForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.addresses = extraAddrForm.addresses;
                }
            }
        }
    }
}
