using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101_lab2_
{
    internal class Bill
    {
        public string S_name { get; set; }
        public int Number { get; set; }
        public double Tarif_per_minute { get; set; }
        public double Price_cut { get; set; }
        public DateTime Talk_start_time { get; set; }
        public DateTime Talk_end_time { get; set; }
        public double Price { get; set; }
        public Bill(string s_name, int number, double tariff_per_minute,double price_cut, DateTime talk_start_time, DateTime talk_end_time, double price)
        {
            S_name = s_name;
            Number = number;
            Tarif_per_minute = tariff_per_minute;
            Price_cut = price_cut;
            Talk_start_time = talk_start_time;
            Talk_end_time = talk_end_time;
            Price = price;
        }
        public void insect_fields () 
        {

        }
        public void change_fields() 
        {

        }
        public void Calculate () 
        {
            //double total=(Talk_end_time.ToMinutes)
        }
    }
}
