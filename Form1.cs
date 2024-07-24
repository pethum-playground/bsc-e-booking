using e_booking;
using e_booking.Model;
using System.Windows.Forms;

namespace e_booking
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;

        public Form1(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializedListView();
        }

        private void InitializedListView()
        {
            listView1.Columns.Add("Hall No", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("Time", 120, HorizontalAlignment.Center);
            listView1.Columns.Add("Capacity", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Code", 120, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }


        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        };

        private DateTime _selectedDate;
        private string _selectedDateString = "";
        private int _count = 0;
        private List<Slot> _freeSlots = new List<Slot>();

        private void InitializedListViewItems(List<Slot> slots)
        {
            listView1.Items.Clear();
            foreach (var slot in slots)
            {
                if (!string.IsNullOrEmpty(slot.HallName) && !string.IsNullOrEmpty(slot.StartTime) &&
                    !string.IsNullOrEmpty(slot.EndTime))
                {
                    var capacity = _context.hall_capacities
                        .Where(name => name.HallName == slot.HallName)
                        .Select(name => name.Capacity)
                        .ToList();

                    if (capacity.Count == 1)
                    {
                        _count = capacity[0];
                    }

                    RenderItems(slot.HallName, slot.StartTime, slot.EndTime, _count, 0);
                }
            }

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void RenderItems(string hallName, string startTime, string endTime, int capacity, int day)
        {
            string code = hallName + startTime.Split(':')[0];

            ListViewItem item = new ListViewItem(hallName);
            item.SubItems.Add(startTime + " - " + endTime);
            item.SubItems.Add(capacity.ToString());
            item.SubItems.Add(code);
            listView1.Items.Add(item);
        }

        private List<Slot> FilterSlots(List<Slot> slots, string text)
        {
            List<Slot> filteredSlots = slots.Where(slot =>
            {
                if (!string.IsNullOrEmpty(slot.HallName))
                {
                    return slot.HallName.StartsWith(text);
                }
                else
                {
                    return false;
                }
            }
                )
                .Select(slot => new Slot
                { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime })
                .ToList();
            return filteredSlots;
        }

        private void Reset()
        {
            lectureHall_btn.Checked = false;
            computerLab_btn.Checked = false;
            sort_label.Text = "-";
            InitializedListViewItems(_freeSlots);
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DateTime selectedStartTime = start_time.Value;
            string selectedStartTimeString = selectedStartTime.ToString("HH:mm");
            DateTime selectedEndTime = end_time.Value;
            string selectedEndTimeString = selectedEndTime.ToString("HH:mm");

            TimeSpan timeStart = TimeSpan.Parse(selectedStartTimeString);
            TimeSpan timeEnd = TimeSpan.Parse(selectedEndTimeString);
            TimeSpan timeDifference = timeEnd - timeStart;
            string hoursString = timeDifference.ToString().Split(":")[0];
            string minutesString = timeDifference.ToString().Split(":")[1];


            List<Slot> filteredSlots = _freeSlots.Where(slot =>
            {
                if (!string.IsNullOrEmpty(slot.HallName) && !string.IsNullOrEmpty(slot.StartTime) &&
                    !string.IsNullOrEmpty(slot.EndTime))
                {
                    TimeSpan dbStartTime = TimeSpan.Parse(slot.StartTime);
                    TimeSpan dbEndTime = TimeSpan.Parse(slot.EndTime);
                    int comparisonResultStart = timeStart.CompareTo(dbStartTime);
                    int comparisonResultEnd = timeEnd.CompareTo(dbEndTime);

                    if (comparisonResultStart >= 0 && comparisonResultEnd <= 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
                )
                .Select(slot => new Slot
                { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime })
                .ToList();
            sort_label.Text = "duration: " + hoursString + " hours and " +
                              minutesString + " minutes.";
            if (lectureHall_btn.Checked)
            {
                filteredSlots = FilterSlots(filteredSlots, "LH");
                sort_label.Text = "Lecture Hall, " + "duration: " + hoursString +
                                  " hours and " + minutesString + " minutes.";
            }

            if (computerLab_btn.Checked)
            {
                filteredSlots = FilterSlots(filteredSlots, "CMP");
                sort_label.Text = "Computer Laboratory, " + "duration: " +
                                  hoursString + " hours and " +
                                  minutesString + " minutes.";
            }

            InitializedListViewItems(filteredSlots);
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            _selectedDate = date_picker.Value;
            _selectedDateString = _selectedDate.DayOfWeek.ToString();
            Reset();

            if (!string.IsNullOrEmpty(_selectedDateString))
            {
                if (Enum.TryParse(_selectedDateString, out Days dayEnum))
                {
                    int dayValue = (int)dayEnum;

                    _freeSlots = _context.time_table
                        .Where(slot => (slot.Day == dayValue) && (slot.EventName != ""))
                        .Select(slot => new Slot
                        { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime })
                        .ToList();


                    InitializedListViewItems(_freeSlots);
                }
            }
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            search_btn_Click(sender, e);
        }


        private void reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }


    }
}