using gui_cp2.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cp2
{
    public partial class MainMenu : Form
    {
        private static string _JRNL_FILE = "journal.json";
        private List<Person> _persons = null;
        private Person _personToShow = null;

        public MainMenu()
        {
            _persons = JsonWorker.LoadPersonsFromFile(_JRNL_FILE);
            
            if (_persons == null)
            {
                MessageBox.Show("Файл не существует или повреждён, был создан новый.");
                _persons = new List<Person>();
            }

            InitializeComponent();
            UpdatePersonsList();
        }

        private void UpdatePersonsList()
        {
            _personsList.Items.Clear();
            foreach (Person person in _persons)
            {
                PersonItem pItem = new PersonItem();
                pItem.person = person;

                _personsList.Items.Add(pItem);
            }
        }

        private void UpdateViewingPerson()
        {
            _lbID.Text = _personToShow.ID;
            _lbLname.Text = _personToShow.LastName;
            _lbFname.Text = _personToShow.FirstName;
            _lbEmail.Text = _personToShow.Email;
            _lbAddr.Text = "";
            foreach (Address address in _personToShow.Addresses)
            {
                _lbAddr.Text += address.PostCode + "; " + address.Country + "; " + address.City + "; " + address.Street + "; " + address.HouseNumber + "; " + address.ApartmentNumber + "\n";
            }

            _lbTlph.Text = "";
            foreach (Telephone telephone in _personToShow.Telephones)
            {
                _lbTlph.Text += telephone.PhoneNumberType + "; " + telephone.PhoneNumber + "\n";
            }
        }

        // События при взаимодействии с гуйней.
        private void _btnShowNPCForm_Click(object sender, EventArgs e)
        {
            using (var _npcForm = new NewPersonCreation(null)) {
                var res = _npcForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _persons.Add(_npcForm.res);
                    JsonWorker.RecreateFileFromList(_JRNL_FILE, _persons);
                    UpdatePersonsList();
                }
            }
        }

        private void _btnChange_Click(object sender, EventArgs e)
        {
            if (_personToShow != null)
            {
                using (var _npcForm = new NewPersonCreation(_personToShow))
                {
                    var res = _npcForm.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        _persons[_persons.IndexOf(_personToShow)] = _npcForm.res;
                        JsonWorker.RecreateFileFromList(_JRNL_FILE, _persons);
                        UpdatePersonsList();
                        _personsList.SelectedIndex = _persons.IndexOf(_personToShow);
                    }
                }
            }
        }

        private void _btnDelPerson_Click(object sender, EventArgs e)
        {
            if (_personToShow != null)
            {
                _persons.Remove(_personToShow);
                _personsList.SelectedIndex = -1;
                JsonWorker.RecreateFileFromList(_JRNL_FILE, _persons);
                UpdatePersonsList();
            }
        }
        private void _personsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_personsList.SelectedIndex == -1)
            {
                _personToShow = null;
                _personView.Visible = false;
            }
            else
            {
                _personToShow = ((PersonItem)_personsList.SelectedItem).person;
                _personView.Visible = true;
                UpdateViewingPerson();
            }
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            using (var sf = new SearchForm(_persons))
            {
                var res = sf.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _personsList.SelectedIndex = _persons.IndexOf(sf.res);
                }
            }
        }
    }
    internal class PersonItem
    {
        public Person person;
        public override string ToString()
        {
            return person.LastName + " " + person.FirstName;
        }
    }
}
