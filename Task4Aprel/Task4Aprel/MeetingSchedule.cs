using System;
using System.Collections.Generic;
using System.Text;

namespace Task4Aprel
{
    internal class MeetingSchedule
    {
        public List <Meeting> meetings = new List <Meeting> ();    
        

        public void SetMeeting(Meeting meeting)
        {
            foreach (var item in meetings)
            {
                if (item.FromDate == meeting.FromDate && item.ToDate == meeting.ToDate)
                {
                    throw new AlreadExistException(" Bu tarixde meeting var");
                }
            }           
            meetings.Add(meeting);
           
                    
        }

        public int FindMeetingsCount(DateTime date)
        {
            int count = 0;  
            foreach(var item in meetings)
            {
                if (item.FromDate <= date)
                {
                    count++;
                }
            }
            return count;
        }
        public bool IsExistsMeetingByName(string val)
        {
            foreach (var meeting in meetings)
            {
                if (meeting.Name.Contains(val))
                {
                    return true;
                }
            }
            return false;
        }
        public  List<Meeting> GetExistMeetings(string val)
        {
            List<Meeting> filteredMeetings = new List<Meeting> ();

            foreach (var item in meetings)
            {
                if (item.Name.Contains(val))
                {
                    filteredMeetings.Add(item);
                }
            }
            return filteredMeetings;
        }
    }
}
