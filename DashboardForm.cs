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
    public partial class DashboardForm : Form
    {
        private readonly AppDbContext _context;

        public DashboardForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserCards();
            LoadReservationCards();
        }

        private void LoadUserCards()
        {
            panelUserCards.Controls.Clear();

            var count = _context.Users.Count();

            Panel userCard = CreateUserCard(count);
            userCard.Location = new Point(0, 0); 
            panelUserCards.Controls.Add(userCard);
        }

        private void LoadReservationCards()
        {
            panelReservationCards.Controls.Clear();

            var count = _context.Slots.Count();

            Panel reservationCard = CreateReservationCard(count);
            panelReservationCards.Controls.Add(reservationCard);
        }

        private Panel CreateUserCard(int count)
        {
            Panel card = new Panel
            {
                Size = new Size(200, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10),
            };

            Label lblReservationCount = new Label
            {
                Text = $"Users: {count}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            card.Controls.Add(lblReservationCount);

            return card;
        }

        private Panel CreateReservationCard(int count)
        {
            Panel card = new Panel
            {
                Size = new Size(200, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10),
            };

            Label lblReservationId = new Label
            {
                Text = $"Reservations: {count}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            card.Controls.Add(lblReservationId);

            return card;
        }

    }
}
