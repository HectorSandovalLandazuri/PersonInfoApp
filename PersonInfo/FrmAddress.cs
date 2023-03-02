using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInfo
{
    public partial class FrmAddress : Form
    {
        ISaveAddress _parent;
        public FrmAddress(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        private void FrmAddress_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = txtStreetAddress.Text,
                City = txtCity.Text,
                State = txtState.Text,
                PostalCode = txtCode.Text
            };
            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
