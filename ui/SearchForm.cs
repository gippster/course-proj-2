using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cp2.ui
{
    public partial class SearchForm : Form
    {
        private List<Person> _persons;
        public Person res;
        private List<Person> _results = new List<Person>();
        public SearchForm(List<Person> curList)
        {
            _persons = curList;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_cbConditions.SelectedIndex)
            {
                /*
                 * ID
                 * Имя
                 * Фамилия
                 * Номер
                */
                case 0:
                    _results = _persons.Where(el => el.ID == _tbCondition.Text).ToList();
                    break;
                case 1:
                    _results = _persons.Where(el => el.FirstName == _tbCondition.Text).ToList();
                    break;
                case 2:
                    _results = _persons.Where(el => el.LastName == _tbCondition.Text).ToList();
                    break;
                case 3:
                    _results = _persons.Where(el => el.Telephones.Any(el_tel => el_tel.PhoneNumber == _tbCondition.Text)).ToList();
                    break;
            }

            _lbPersons.Items.Clear();
            if (_results.Count > 0)
            {
                foreach(Person person in _results)
                {
                    PersonItem personItem = new PersonItem();
                    personItem.person = person;
                    _lbPersons.Items.Add(personItem);
                }
            }
            else
            {
                _lbPersons.Items.Add("Ничего не найдено по заданному условию.");
            }
        }

        private void _lbPersons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_lbPersons.SelectedIndex != -1 && _lbPersons.SelectedItem is PersonItem)
            {
                res = ((PersonItem)_lbPersons.SelectedItem).person;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
