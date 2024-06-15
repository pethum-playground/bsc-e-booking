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
            var book = new Book { BookName = name };

            _context.Users.Add(user);
            _context.Books.Add(book);
            var book1 = _context.Books.FirstOrDefault((book1) => book1.Id == 1);
            _context.SaveChanges();

            MessageBox.Show("Username saved to database!");
            txtName.Clear();

            saveLabel.Text = user.Id.ToString();
        }
    }
}
