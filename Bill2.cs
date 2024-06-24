using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101_lab2_
{
    internal class Bill2
    {
        public string Sname { get; set; }
        public string PhoneNumber { get; set; }
        public double TariffPerMinute { get; set; }
        public double Discount { get; set; }
        public Time StartTime { get; set; }
        public Time EndTime { get; set; }
        public double TotalAmount { get; set; }

        public Bill2 ( string payerName, string phoneNumber, double tariffPerMinute, double discount, Time startTime, Time endTime )
        {
            Sname = payerName;
            PhoneNumber = phoneNumber;
            TariffPerMinute = tariffPerMinute;
            Discount = discount;
            StartTime = startTime;
            EndTime = endTime;

            CalculateTotalAmount();
        }

        private void CalculateTotalAmount ()
        {
            int totalMinutes = ( EndTime.ToMinutes() - StartTime.ToMinutes() ) + 1; // Rounded up to the nearest minute
            double totalCost = totalMinutes * TariffPerMinute;
            double discountAmount = totalCost * ( Discount / 100 );
            TotalAmount = totalCost - discountAmount;
        }

        public void UpdateEndTime ( Time newEndTime )
        {
            EndTime = newEndTime;
            CalculateTotalAmount();
        }

        public override string ToString ()
        {
            return $"Total amount to pay for {Sname}: {TotalAmount} rubles.";
        }
    }
}
