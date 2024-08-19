using e_booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_booking.Helpers
{
    internal class LoggedInUser
    {
        private static LoggedInUser instance;

        public User _user { get; private set; }

        private LoggedInUser() { }

        public static LoggedInUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoggedInUser();
                }
                return instance;
            }
        }

        public void SetUser(User user)
        {
            _user = user;
        }
    }
}
