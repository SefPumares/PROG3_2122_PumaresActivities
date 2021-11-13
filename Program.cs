using System;

namespace TimeKeeping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emloyee Time Keeping System");
            Console.WriteLine($"Today's Date:  {DateTime.Today}");

            Console.WriteLine("To log your time-in, enter your employee ID: ");
            string employeeId = Console.ReadLine();

            TimeSpan timeIn = new TimeSpan(8, 0, 0);
            Console.WriteLine($"Welcome {employeeId}! Your log-in time is recorded: {timeIn}");

            Console.WriteLine("*******************************************");
            Console.WriteLine("To log your time-out enter your employee ID: ");
            employeeId = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(16, 0, 0);
            Console.WriteLine($"Goodbye {employeeId}! Your log-out time is recorded: {timeOut}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;

            Console.WriteLine($"Employee {employeeId} your total hours worked is: {totalHours}");

            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0, 0, 0);
            TimeSpan underTime = new TimeSpan(1, 0, 0);

            if (timeIn > regularHoursStart)
            {
                lateIn = timeIn - regularHoursStart;
            }

            if (timeOut > regularHoursEnd)
            {
                underTime = timeOut - regularHoursEnd;
            }

            Console.WriteLine($"Employee {employeeId} your undertime is : {underTime}");
        }
    }
}