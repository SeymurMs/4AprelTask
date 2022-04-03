using System;

namespace Task4Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime toDate = new DateTime();
            DateTime fromDate = new DateTime();
            Console.WriteLine("ToDate daxil et");
            string toDateStr = Console.ReadLine();
            Console.WriteLine("FromDate daxil et");
            string fromDateStr = Console.ReadLine();

            DateTime.TryParse(fromDateStr , out fromDate);   
            DateTime.TryParse(toDateStr, out toDate);
            Console.WriteLine(toDate);

            Meeting meeting = new Meeting("Name", toDate, fromDate);
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            try
            {
                meetingSchedule.SetMeeting(meeting);
                meetingSchedule.SetMeeting(meeting);
                
            }
            catch (AlreadExistException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(meetingSchedule.FindMeetingsCount(fromDate));
            
            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("i"));
           
            foreach (var item in meetingSchedule.GetExistMeetings("Na"))
            {
                Console.WriteLine(item.Name);
            }
            

        }
    }
}
