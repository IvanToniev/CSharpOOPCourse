using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsmCall;

namespace Gsm
{
    class Gsm
    {
        private string gsmModel;
        private string manufacturer;
        private decimal ?price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();
        private List<Call> callList = new List<Call>();

        public static Gsm IPhone4S = new Gsm("IPhone4S","Apple",900,"Pa qze","nqkva bateriq",10,7,BatteryType.LiIon,15,256000);

        public List<Call> CallList
        {
            get
            {
                return this.callList;
            }
            set
            {
                this.callList = value;
            }
        }

        public string Model
        {
            get { return this.gsmModel;}
            set { this.gsmModel=value;}
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public decimal ?Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Gsm(string model,string manufacturer,decimal? price,string owner,string batteryModel,double? bHoursIdle,double? bHoursTalk,BatteryType? type,int? dSize,int? dColors)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery.BatteryModel = batteryModel;
            this.battery.HoursIdle = bHoursIdle;
            this.battery.HoursTalk = bHoursTalk;
            this.battery.BatteryType = type;
            this.display.Size = dSize;
            this.display.NumOfColors = dColors;
        }

        public Gsm(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? bHoursIdle, double? bHoursTalk, BatteryType type, int? dSize)
        :this(model,manufacturer,price,owner,batteryModel,bHoursIdle,bHoursTalk,type,dSize,null)
        { }

        public Gsm(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? bHoursIdle, double? bHoursTalk, BatteryType type)
            : this(model, manufacturer, price, owner, batteryModel, bHoursIdle, bHoursTalk, type, null, null)
        { }

        public Gsm(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? bHoursIdle, double? bHoursTalk)
            : this(model, manufacturer, price, owner, batteryModel, bHoursIdle, bHoursTalk,null, null, null)
        { }

        public Gsm(string model, string manufacturer, decimal? price, string owner, string batteryModel, double? bHoursIdle)
            : this(model, manufacturer, price, owner, batteryModel, bHoursIdle, null, null, null, null)
        { }

        public Gsm(string model, string manufacturer, decimal? price, string owner, string batteryModel)
            : this(model, manufacturer, price, owner, batteryModel, null, null, null, null, null)
        { }

        public Gsm(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null, null, null, null, null)
        { }

        public Gsm(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, null, null, null, null, null, null)
        { }

        public Gsm(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null, null, null, null, null)
        { }

        public Gsm(string model)
            : this(model, null, null, null, null, null, null, null, null, null)
        { }

        public Gsm()
            : this(null, null, null, null, null, null, null, null, null, null)
        { }

        public List<Call> AddCall(Call call) 
        {
            callList.Add(call);
            return callList;
        }

        public List<Call> DelCall(int index)
        {
            callList.RemoveAt(index);
            return callList;
        }

        public List<Call> Clear()
        {
            callList.Clear();
            return callList;
        }

        public double? CallPrice(List<Call> callList)
        {
            double? sum = 0;
            double moneyPerSecond = (0.37/60);

            foreach (var call in callList)
            {
                sum += call.Duration*moneyPerSecond;
            }

            return sum;
        }

        public override string ToString()
        {
           return String.Format("Model:{0}, Manufacturer:{1}, Price:{2}, Owner:{3} {4}, {5}, {6}",this.gsmModel,this.manufacturer,this.price,this.owner,'\n',this.battery.ToString(),this.display.ToString());
        }
    }
}
