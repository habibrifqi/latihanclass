using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Time
    {
        //privete variable autau field
        public int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;
        public Time(int year, int month, int date,
                int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;


            // public method

        }
    }
}

