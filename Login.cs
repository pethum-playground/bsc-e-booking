using e_booking.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_booking
{
    public partial class Login : Form
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public Login(AppDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            var user = _context.Users.FirstOrDefault((user) => user.Email == Email.Text);
            if (user is null)
            {
                MessageBox.Show("The password you entered is incorrect. Please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var isValid = PasswordHelper.ValidatePassword(Password.Text, user.Password);
            if (!isValid)
            {
                MessageBox.Show("The password you entered is incorrect. Please try again.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoggedInUser.Instance.SetUser(user);
            var dashboard = new Dashboard(_context, _config);
            dashboard.FormClosed += (s, args) => Application.Exit();
            dashboard.Show();

            this.Hide();
        }
    }
}
