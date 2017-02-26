using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZenithDataLib
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime EventFrom { get; set; }
        public DateTime EventTo { get; set; }
        public string Username { get; set; }
        public Activity Activity { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
