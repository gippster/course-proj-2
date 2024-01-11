using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_cp2.ui.extradatachange.tlph
{
    public partial class NewTlphCreation : Form
    {
        public Telephone res;
        public TelephoneType tType { get; set; }
        public bool isStationary { get; set; } 
        public string tNumber { get; set; }
        public NewTlphCreation(Telephone tlph)
        {
            InitializeComponent();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            tType = (TelephoneType)_cbTelType.SelectedIndex;
            isStationary = _cbIsStationary.Checked;
            tNumber = _tbTelNum.Text;

            try
            {
                if (this.isStationary)
                {
                    res = new LandlinePhone(this.tNumber);
                }
                else
                {
                    res = new MobilePhone(this.tNumber);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
