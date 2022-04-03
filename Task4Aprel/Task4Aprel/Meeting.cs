using System;
using System.Collections.Generic;
using System.Text;

namespace Task4Aprel
{
    internal class Meeting
    {
        public Meeting(string name , DateTime toDate, DateTime fromDate)
        {
            this.ToDate = toDate;
            this.Name = name;
            this.FromDate = fromDate;
        }
        public DateTime FromDate = new DateTime();
        public DateTime ToDate = new DateTime();   
        public string Name { get; set; }
    }
}
