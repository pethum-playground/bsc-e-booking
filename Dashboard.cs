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
    public partial class Dashboard : Form
    {
        private readonly AppDbContext _context;

        public Dashboard(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        public void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(form); // Add the form to the panel
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReserveForm(_context);
            LoadFormIntoPanel(reservationForm);
        }

        // Example event handler for a button click to open the User Management Form
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            var reservationForm = new UserForm(_context);
            LoadFormIntoPanel(reservationForm);
        }
    }
}
