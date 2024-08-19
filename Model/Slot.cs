using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_booking.Model
{
    public class Slot
    {
        public int Id { get; set; }

        public string? HallName { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? EventName { get; set; }
    }
}
