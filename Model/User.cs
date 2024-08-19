using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_booking.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string Email { get; set; }
        public string? Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;

        public UserType Type { get; set; } = UserType.User;
    }

    public enum UserType
    {
        Admin, User
    }
}
