using e_booking.Model;

namespace e_booking
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;

        public Form1(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;

            var user = new User { Name = name };

            _context.Users.Add(user);
            _context.SaveChanges();

            MessageBox.Show("Username saved to database!");
            txtName.Clear();

            saveLabel.Text = user.Id.ToString();
        }
    }
}
