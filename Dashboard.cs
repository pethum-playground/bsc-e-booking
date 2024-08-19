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
    public partial class Dashboard : Form
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _config;

        public Dashboard(AppDbContext context, IConfiguration config)
        {
            InitializeComponent();
            _context = context;
            _config = config;

            LoadFormIntoPanel(new DashboardForm(_context));
        }

        public void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var dashboardForm = new DashboardForm(_context);
            LoadFormIntoPanel(dashboardForm);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReserveForm(_context);
            LoadFormIntoPanel(reservationForm);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            var reservationForm = new UserForm(_context, _config);
            LoadFormIntoPanel(reservationForm);
        }
    }
}
