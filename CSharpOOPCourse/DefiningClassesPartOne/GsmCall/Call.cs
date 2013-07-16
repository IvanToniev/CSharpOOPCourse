using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmCall
{
    public class Call
    {
        private string date;
        private string time;
        private string dialedNum;
        private int? duration;

        public int? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public string DialedNum
        {
            get
            {
                return this.dialedNum;
            }
            set
            {
                this.dialedNum = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public Call(string date,string time,string dialedNum,int? duration) 
        {
            this.Date = date;
            this.Time = time;
            this.DialedNum = dialedNum;
            this.Duration = duration;
        }

        public Call(string date, string time, string dialedNum)
            :this(date,time,dialedNum,null)
        { }

        public Call(string date, string time)
            : this(date, time, null, null)
        { }

        public Call(string date)
            : this(date, null, null, null)
        { }

        

        public string CallDetails() 
        {
            return String.Format("Date: {0}, Time: {1}, Dialed Number: {2}, Duration: {3}",this.Date,this.Time,this.DialedNum,this.Duration);
        }
    }
}
