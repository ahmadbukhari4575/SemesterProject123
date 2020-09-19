using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AhmadBukhari.Models
{
    public class Hostel
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public int No_of_rooms { get; set; }
        public int No_of_students { get; set; }
        public string Location { get; set; }
    }
}