using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_booking.Model
{
    public class TimeTable
    {
        [Key] public int Id { get; set; }
        public string? HallName { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public int Day { get; set; }
        public string? EventName { get; set; }
    }
}
