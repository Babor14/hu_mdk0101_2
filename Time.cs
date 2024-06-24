using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101_lab2_
{
    internal class Time
    {
        //public int Start_time { get; set; }
        //public int End_time { get; set;}
        //public Time(int start_time, int end_time)
        //{
        //    Start_time = start_time;
        //    End_time = end_time;
        //}
        ////public void Transform_time(DateTime dts, DateTime dte) 
        ////{
        ////    dts = DateTime.Parse(Start_time.ToString());
        ////    dte = DateTime.Parse(End_time.ToString());
        ////}
        //public void Cut_time(DateTime ct, DateTime dts,DateTime dte) 
        //{

        //}
        private int hours;
        private int minutes;
        private int seconds;

        public Time ( int hours, int minutes, int seconds )
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Time ( string timeString )
        {
            string[] timeParts = timeString.Split(':');
            this.hours = int.Parse(timeParts[0]);
            this.minutes = int.Parse(timeParts[1]);
            this.seconds = int.Parse(timeParts[2]);
        }

        public Time ( int totalSeconds )
        {
            this.hours = totalSeconds / 3600;
            this.minutes = ( totalSeconds % 3600 ) / 60;
            this.seconds = totalSeconds % 60;
        }

        public Time ( DateTime time )
        {
            this.hours = time.Hour;
            this.minutes = time.Minute;
            this.seconds = time.Second;
        }

        public int DifferenceInSeconds ( Time otherTime )
        {
            return Math.Abs(( this.hours * 3600 + this.minutes * 60 + this.seconds ) - ( otherTime.hours * 3600 + otherTime.minutes * 60 + otherTime.seconds ));
        }

        public void AddSeconds ( int secondsToAdd )
        {
            int totalSeconds = this.hours * 3600 + this.minutes * 60 + this.seconds;
            totalSeconds += secondsToAdd;
            this.hours = totalSeconds / 3600;
            this.minutes = ( totalSeconds % 3600 ) / 60;
            this.seconds = totalSeconds % 60;
        }

        public void SubtractSeconds ( int secondsToSubtract )
        {
            int totalSeconds = this.hours * 3600 + this.minutes * 60 + this.seconds;
            totalSeconds -= secondsToSubtract;
            this.hours = totalSeconds / 3600;
            this.minutes = ( totalSeconds % 3600 ) / 60;
            this.seconds = totalSeconds % 60;
        }

        public bool Compare ( Time otherTime )
        {
            return ( this.hours == otherTime.hours && this.minutes == otherTime.minutes && this.seconds == otherTime.seconds );
        }

        public int ToSeconds ()
        {
            return this.hours * 3600 + this.minutes * 60 + this.seconds;
        }

        public int ToMinutes ()
        {
            return (int)Math.Round((double)this.ToSeconds() / 60);
        }
    }
}
