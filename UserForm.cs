using e_booking.Helpers;
using e_booking.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class UserForm : Form
    {
        private readonly AppDbContext _context;
        private readonly List<User> _users = new List<User>();

        public UserForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Open AddUserForm as a dialog
            using (AddUserForm addUserForm = new AddUserForm())
            {
                if (addUserForm.ShowDialog() == DialogResult.OK)
                {
                    string userEmail = addUserForm.Email;
                    string password = GeneratePassword();

                    var newUser = new Model.User { Email = userEmail, Password = PasswordHelper.HashPassword(password) };
                    _context.Users.Add(newUser);
                    _context.SaveChanges();

                    SendEmailToUser(userEmail, password);
                    AddUserToTable(newUser);
                }
            }
        }


        private string GeneratePassword()
        {
            return "GeneratedPassword123";
        }

        private void SendEmailToUser(string email, string password)
        {
            
        }

        private void AddUserToTable(Model.User user)
        {
            var index = userTable.Rows.Add();
            userTable.Rows[index].Cells["UserName"].Value = user.Username;
            userTable.Rows[index].Cells["Email"].Value = user.Email;
            userTable.Rows[index].Cells["Status"].Value = user.IsActive ? "Active" : "Disabled";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.Instance._user.Type == Model.UserType.Admin)
            {
                btnAddUser.Enabled = true;
                btnRemoveUser.Enabled = true;
                btnDisableUser.Enabled = true;
            }
            else
            {
                btnAddUser.Enabled = false;
                btnRemoveUser.Enabled = false;
                btnDisableUser.Enabled = false;
            }

            LoadUsersToTable();
        }

        private void LoadUsersToTable()
        {
            string loggedInUserEmail = LoggedInUser.Instance._user.Email;

            var users = _context.Users.Where(u => u.Email != loggedInUserEmail).ToList();
            _users.AddRange(users);

            foreach (var user in users)
            {
                AddUserToTable(user);
            }
        }

        private void btnDisableUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in userTable.SelectedRows)
            {
                var user = _users.Where(u => u.Email == row.Cells["Email"].Value).FirstOrDefault();
                user.IsActive = false;

                row.Cells["Status"].Value = user.IsActive ? "Active" : "Disabled";
            }

            _context.SaveChanges();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove the selected user(s)?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in userTable.SelectedRows)
                    {
                        var user = _users.Where(u => u.Email.ToString() == row.Cells["Email"].Value.ToString()).FirstOrDefault();
                        if (user != null)
                        {
                            _context.Users.Remove(user);
                            userTable.Rows.Remove(row);
                        }
                    }

                    _context.SaveChanges(true);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to remove.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
