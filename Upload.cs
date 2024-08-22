using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using e_booking.Model;
using ExcelDataReader;
using OfficeOpenXml;

namespace e_booking
{
    public partial class Upload : Form
    {
        private readonly AppDbContext _context;

        public Upload(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "HallName",
                HeaderText = "Hall Name",
                DataPropertyName = "HallName"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Capacity",
                HeaderText = "Capacity",
                DataPropertyName = "Capacity"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StartTime",
                HeaderText = "Start Time",
                DataPropertyName = "StartTime"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EndTime",
                HeaderText = "End Time",
                DataPropertyName = "EndTime"
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Day",
                HeaderText = "Day",
                DataPropertyName = "Day"
            });

        }

        private void Upload_Load(object sender, EventArgs e)
        {
            LoadHalls();
        }

        private void LoadHalls()
        {

            var halls = _context.TimeTables.ToList();
            var hallCapacities = _context.HallCapacities.ToList();

            foreach (var hall in halls)
            {
                var capacity = hallCapacities.FirstOrDefault(t => t.HallName == hall.HallName)?.Capacity;
                dataGridView.Rows.Add(hall.HallName, capacity, hall.StartTime, hall.EndTime, hall.Day);
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
                                var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                                    {
                                        UseHeaderRow = true
                                    }
                                });

                                var dataTable = result.Tables[0];

                                var dataRows = dataTable.AsEnumerable().Skip(1).CopyToDataTable();

                                dataGridView.AutoGenerateColumns = false;
                                dataGridView.DataSource = dataRows;

                                foreach (DataRow row in dataRows.Rows)
                                {
                                    string hallName = row[0].ToString();
                                    int capacity = int.Parse(row[1].ToString());
                                    string startTime = row[2].ToString();
                                    string endTime = row[3].ToString();
                                    int day = int.Parse(row[4].ToString());
                                    string eventName = "NULL";

                                    var hall = new HallCapacity { HallName = hallName, Capacity = capacity };
                                    var timeTable = new TimeTable { Day = day, EventName = eventName, StartTime = startTime, EndTime = endTime, HallName = hallName };
                                    _context.HallCapacities.Add(hall);
                                    _context.TimeTables.Add(timeTable);
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

        private void btnDownloadSample_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Halls";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (var package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Sample");

                            worksheet.Cells[1, 1].Value = "Hall Name";
                            worksheet.Cells[1, 2].Value = "Capacity";
                            worksheet.Cells[1, 3].Value = "StartTime";
                            worksheet.Cells[1, 4].Value = "EndTime";
                            worksheet.Cells[1, 5].Value = "Day";

                            var halls = _context.TimeTables.ToList();
                            var hallCapacities = _context.HallCapacities.ToList();

                            for (int i = 0; i < halls.Count; i++)
                            {
                                worksheet.Cells[i+2, 1].Value = halls[i].HallName;
                                worksheet.Cells[i+2, 2].Value = hallCapacities.FirstOrDefault(t => t.HallName == halls[i].HallName)?.Capacity;
                                worksheet.Cells[i+2, 3].Value = halls[i].StartTime;
                                worksheet.Cells[i+2, 4].Value = halls[i].EndTime;
                                worksheet.Cells[i+2, 5].Value = halls[i].Day;
                            }

                            // Save the file
                            package.SaveAs(new FileInfo(filePath));
                        }

                        MessageBox.Show("Sample Excel file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while creating the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
