using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101_lab2_
{
    internal class Time2
    {
        internal int Hours;
        internal int Minutes;
        internal int Seconds;

        public Time2 ( int hours, int minutes, int seconds )
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Time2 ( string timeString )
        {
            string[] parts = timeString.Split(':');
            if (parts.Length == 3)
            {
                this.Hours = int.Parse(parts[0]);
                this.Minutes = int.Parse(parts[1]);
                this.Seconds = int.Parse(parts[2]);
            }
            else
            {
                throw new ArgumentException("Invalid time format. Use 'hour:minute:second'.");
            }
        }

        public Time2 ( int totalSeconds )
        {
            this.Hours = totalSeconds / 3600;
            this.Minutes = ( totalSeconds % 3600 ) / 60;
            this.Seconds = totalSeconds % 60;
        }

        public Time2 ( DateTime time )
        {
            this.Hours = time.Hour;
            this.Minutes = time.Minute;
            this.Seconds = time.Second;
        }

        public int DifferenceInSeconds ( Time2 otherTime )
        {
            return Math.Abs(( this.Hours * 3600 + this.Minutes * 60 + this.Seconds ) - ( otherTime.Hours * 3600 + otherTime.Minutes * 60 + otherTime.Seconds ));
        }

        public void AddSeconds ( int secondsToAdd )
        {
            int totalSeconds = this.Hours * 3600 + this.Minutes * 60 + this.Seconds + secondsToAdd;
            this.Hours = totalSeconds / 3600;
            this.Minutes = ( totalSeconds % 3600 ) / 60;
            this.Seconds = totalSeconds % 60;
        }

        public void SubtractSeconds ( int secondsToSubtract )
        {
            int totalSeconds = this.Hours * 3600 + this.Minutes * 60 + this.Seconds - secondsToSubtract;
            this.Hours = totalSeconds / 3600;
            this.Minutes = ( totalSeconds % 3600 ) / 60;
            this.Seconds = totalSeconds % 60;
        }

        public int ToSeconds ()
        {
            return this.Hours * 3600 + this.Minutes * 60 + this.Seconds;
        }

        public int ToMinutes ()
        {
            return (int)Math.Round((double)this.ToSeconds() / 60);
        }
    }
}
