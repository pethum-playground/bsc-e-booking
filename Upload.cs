using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using e_booking.Model;
using ExcelDataReader;

namespace e_booking
{
    public partial class Upload : Form
    {
        private readonly AppDbContext _context;

        public Upload(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void Upload_Load(object sender, EventArgs e)
        {
            LoadHalls();
        }

        private void LoadHalls()
        {
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("HallName", "Hall Name");
            dataGridView.Columns.Add("Capacity", "Capacity");

            var halls = _context.HallCapacities.ToList();

            foreach (var hall in halls)
            {
                dataGridView.Rows.Add(hall.HallName, hall.Capacity);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
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

                                var dataTable = result.Tables[0];

                                var dataRows = dataTable.AsEnumerable().Skip(1).CopyToDataTable();

                                dataGridView.Columns.Clear();
                                dataGridView.Columns.Add("HallName", "Hall Name");
                                dataGridView.Columns.Add("Capacity", "Capacity");

                                dataGridView.DataSource = dataRows;

                                foreach (DataRow row in dataRows.Rows)
                                {
                                    string hallName = row[0].ToString(); // First column: Hall Name
                                    int capacity = int.Parse(row[1].ToString()); // Second column: Capacity

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
