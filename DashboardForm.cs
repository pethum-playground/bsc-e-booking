using e_booking.Model;
using ExcelDataReader;
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

        private void btnUploadExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|All files|*.*";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                var result = reader.AsDataSet();

                                // Assuming the first sheet contains the data
                                var dataTable = result.Tables[0];

                                foreach (System.Data.DataRow row in dataTable.Rows)
                                {
                                    string hallName = row[0].ToString();
                                    int capacity = int.Parse(row[1].ToString()); 

                                    var hall = new HallCapacity { HallName = hallName, Capacity = capacity };
                                    _context.HallCapacities.Add(hall);
                                }

                                _context.SaveChanges();
                            }
                        }

                        MessageBox.Show("Data imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
