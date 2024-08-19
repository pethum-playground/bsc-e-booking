namespace e_booking
{
    public partial class ReserveInputForm : Form
    {
        public string StudentID { get; private set; }
        public string EventName { get; private set; }
        public ReserveInputForm()
        {
            InitializeComponent();
        }


        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            StudentID = studentID.Text;
            EventName = eventName.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
