using e_booking.Model;
using e_booking;
using System.Windows.Forms;

namespace e_booking
{
    public partial class ReserveForm : Form
    {
        private readonly AppDbContext _context;

        public ReserveForm(AppDbContext context)
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
            listView1.Columns.Add("Event", 120, HorizontalAlignment.Center);
            listView1.View = View.Details;
        }

        private void ShowInputForm(string hallName, string startTime, string endTime, int day)
        {
            using (ReserveInputForm inputForm = new ReserveInputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string studentID = inputForm.StudentID;
                    string eventName = inputForm.EventName;
                    UpdateEventName(hallName, startTime, endTime, day, eventName);
                    MessageBox.Show("Your Student ID: " + studentID + "\nEvent name : " + eventName);
                    Reset();
                }
            }
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
        private int dayValue = 0;
        private int _count = 0;
        private List<Slot> _freeSlots = new List<Slot>();

        public void UpdateEventName(string hallName, string startTime, string endTime, int day, string eventName)
        {

            var events = _context.TimeTables
                .Where(e => e.HallName == hallName && e.StartTime == startTime && e.EndTime == endTime && e.Day == day && e.EventName == "NULL")
                .ToList();


            foreach (var eventItem in events)
            {
                eventItem.EventName = eventName;
            }


            _context.SaveChanges();

            _freeSlots = _context.TimeTables
                        .Where(slot => (slot.Day == dayValue))
                        .Select(slot => new Slot
                        { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime, EventName = slot.EventName })
                        .ToList();
        }


        private void InitializedListViewItems(List<Slot> slots)
        {
            listView1.Items.Clear();
            foreach (var slot in slots)
            {
                if (!string.IsNullOrEmpty(slot.HallName) && !string.IsNullOrEmpty(slot.StartTime) &&
                    !string.IsNullOrEmpty(slot.EndTime) && !string.IsNullOrEmpty(slot.EventName))
                {
                    var capacity = _context.HallCapacities
                        .Where(name => name.HallName == slot.HallName)
                        .Select(name => name.Capacity)
                        .ToList();

                    if (capacity.Count == 1)
                    {
                        _count = capacity[0];
                    }

                    RenderItems(slot.HallName, slot.StartTime, slot.EndTime, _count, 0, slot.EventName);
                }
            }

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void RenderItems(string hallName, string startTime, string endTime, int capacity, int day, string eventName)
        {
            ListViewItem item = new ListViewItem(hallName);
            item.SubItems.Add(startTime + " - " + endTime);
            item.SubItems.Add(capacity.ToString());
            if (eventName != "NULL")
            {
                item.SubItems.Add(eventName);
            }
            else
            {
                item.SubItems.Add("");
            }
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
                { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime, EventName = slot.EventName })
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
                    !string.IsNullOrEmpty(slot.EndTime) && !string.IsNullOrEmpty(slot.EventName))
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
                { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime, EventName = slot.EventName })
                .ToList();
            sort_label.Text = "duration: " + hoursString + " hours and " +
                              minutesString + " minutes.";
            if (lectureHall_btn.Checked)
            {
                filteredSlots = FilterSlots(filteredSlots, "LCH");
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
                    dayValue = (int)dayEnum;

                    _freeSlots = _context.TimeTables
                        .Where(slot => (slot.Day == dayValue) && (slot.EventName == "NULL"))
                        .Select(slot => new Slot
                        { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime, EventName = slot.EventName })
                        .ToList();


                    InitializedListViewItems(_freeSlots);
                }
            }
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            _selectedDate = date_picker.Value;
            _selectedDateString = _selectedDate.DayOfWeek.ToString();
            Reset();

            if (!string.IsNullOrEmpty(_selectedDateString))
            {
                if (Enum.TryParse(_selectedDateString, out Days dayEnum))
                {
                    int dayValue = (int)dayEnum;

                    _freeSlots = _context.TimeTables
                        .Where(slot => (slot.Day == dayValue))
                        .Select(slot => new Slot
                        { HallName = slot.HallName, StartTime = slot.StartTime, EndTime = slot.EndTime, EventName = slot.EventName })
                        .ToList();


                    InitializedListViewItems(_freeSlots);
                }
            }
        }


        private void reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].SubItems[3].ToString() == "ListViewSubItem: {}")
            {
                string hallName = listView1.SelectedItems[0].SubItems[0].ToString().Substring(18, 5);
                string startTime = listView1.SelectedItems[0].SubItems[1].ToString().Substring(18, 5);
                string endTime = listView1.SelectedItems[0].SubItems[1].ToString().Substring(26, 5);
                int day = dayValue;
                ShowInputForm(hallName, startTime, endTime, day);
            }
            else
            {
                MessageBox.Show("This time slot is already booked");
            }


        }
    }
}