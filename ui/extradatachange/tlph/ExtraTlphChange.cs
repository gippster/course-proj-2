using gui_cp2.ui.extradatachange.tlph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cp2.ui.extradatachange
{
    public partial class ExtraTlphChange : Form
    {
        public List<Telephone> telephones { get; set; }
        public ExtraTlphChange(List<Telephone> _telephones)
        {
            this.telephones = _telephones;
            InitializeComponent();

            UpdateTelList();
        }
        private void UpdateTelList()
        {
            _lbTlphns.Items.Clear();
            foreach (var telephone in telephones)
            {
                TelephoneItem telephoneItem = new TelephoneItem();
                telephoneItem.tel = telephone;
                _lbTlphns.Items.Add(telephoneItem);
            }
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void _btnShowAddForm_Click(object sender, EventArgs e)
        {
            using (var ntcForm = new NewTlphCreation(null))
            {
                var res = ntcForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    telephones.Add(ntcForm.res);
                    UpdateTelList();
                }
            }
        }
    }
    internal class TelephoneItem
    {
        internal Telephone tel { get; set; }
        public override string ToString()
        {
            return tel.PhoneNumber;
        }
        internal TelephoneItem() { }
    }
}
