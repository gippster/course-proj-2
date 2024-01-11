using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cp2.ui.extradatachange.addr
{
    public partial class NewAddrCreation : Form
    {
        public string postcode { get; set; }
        public string country {  get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int housenum {  get; set; }
        public int appartmentnum { get; set; }
        public NewAddrCreation(Address addr)
        {
            InitializeComponent();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            postcode = _tbPostcode.Text;
            country = _tbCountry.Text;
            city = _tbCity.Text;
            street = _tbStreet.Text;
            housenum = (int)_nudHouse.Value;
            appartmentnum = (int)_nudAppartment.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
