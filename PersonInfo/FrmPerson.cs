using DemoLibrary;
using System.ComponentModel;

namespace PersonInfo
{
    public partial class FrmPerson : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public FrmPerson()
        {
            InitializeComponent();
            lbxAddresses.DataSource = addresses;
            lbxAddresses.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddress frmAddress = new FrmAddress(this);
            frmAddress.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                IsActive = chkActive.Checked,
                Addresses = addresses.ToList()
            };
        }
    }
}