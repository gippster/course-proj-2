using gui_cp2.ui.extradatachange.addr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cp2
{
    public partial class ExtraAddrChange : Form
    {
        public List<Address> addresses { get; set; }
        public ExtraAddrChange(List<Address> _addresses)
        {
            this.addresses = _addresses;
            InitializeComponent();

            UpdateAddrList();
        }

        private void UpdateAddrList()
        {
            _lbAddresses.Items.Clear();
            foreach (var address in addresses)
            {
                AddressItem addressItem = new AddressItem();
                addressItem.addr = address;
                _lbAddresses.Items.Add(addressItem);
            }
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void _btnShowAddForm_Click(object sender, EventArgs e)
        {
            using (var nacForm = new NewAddrCreation(null))
            {
                var res = nacForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Address newAddr = new Address(
                        nacForm.street,
                        nacForm.housenum,
                        nacForm.appartmentnum,
                        nacForm.city,
                        nacForm.country,
                        nacForm.postcode
                    );

                    addresses.Add(newAddr);
                    UpdateAddrList();
                }
            }
        }
    }
    internal class AddressItem
    {
        internal Address addr { get; set; }
        public override string ToString()
        {
            return addr.Country + "; " + addr.City + "; " + addr.Street + "; " + addr.HouseNumber + "; " + addr.ApartmentNumber;
        }
        internal AddressItem() { }
    }
}
