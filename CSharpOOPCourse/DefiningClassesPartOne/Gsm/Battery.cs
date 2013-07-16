using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gsm
{
    class Battery
    {
        private string batteryModel;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType? type=new BatteryType();


        public string BatteryModel 
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public double? HoursIdle
        {
            get
            { 
                return this.hoursIdle;
            }
            set 
            {
                if (value >= 0 || value==null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public double? HoursTalk
        {
            get
            { 
                return this.hoursTalk; 
            }
            set 
            {
                if (value >= 0 || value==null)
                {
                    this.hoursTalk = value;
                }
                else 
                {
                    throw new ArgumentException();
                }
            }
        }

        public BatteryType? BatteryType 
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Battery(string model,double? hoursIdle,double? hoursTalk,BatteryType? type)
        {
            this.batteryModel = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public Battery(string model,double hoursIdle,double hoursTalk)
            :this(model,hoursIdle,hoursTalk,null)
        {
        }

        public Battery(string model, double hoursIdle)
            : this(model, hoursIdle, null,null)
        {
        }

        public Battery(string model)
            : this(model, null, null, null)
        {
        }

        public Battery()
            : this(null, null, null, null)
        {
        }

        public override string ToString()
        {
            return String.Format("Battery(Model: {0}, Hours Idle: {1}, Hours Talk: {2}, Type: {3}){4}",this.batteryModel,this.hoursIdle,this.hoursTalk,this.type,'\n');
        }
    }
}
