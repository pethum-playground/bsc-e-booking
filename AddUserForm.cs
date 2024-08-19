namespace e_booking
{
    public partial class AddUserForm : Form
    {
        public string UserName { get; private set; }
        public string Email { get; private set; }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Retrieve entered user details
            Email = txtEmail.Text;

            // Perform validation here if necessary

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
