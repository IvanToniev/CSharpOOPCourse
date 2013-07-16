using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsmCall;

namespace Gsm
{
    class Test
    {
        

        static void Main(string[] args)
        {
            //gsm test
            Gsm[] gsms = new Gsm[3];
            gsms[0] = new Gsm("ZTE");
            Gsm gsm = new Gsm("Lumia", "Nokia", 700, "Qze", "nekva", 10, 7, BatteryType.LiIon, 10, 256000);
            gsms[1] = gsm;
            gsms[2] = Gsm.IPhone4S;
            foreach (Gsm phone in gsms)
            {
                Console.WriteLine(phone.ToString());
            }

            //calls test
            Gsm someGsm = new Gsm("Lumia", "Nokia", 700, "Qze", "nekva", 10, 7, BatteryType.LiIon, 10, 256000);
            someGsm.AddCall(new Call("12.3.2013","12:33","0885379136",62));
            someGsm.AddCall(new Call("12.4.2013", "12:33", "0885379136", 60));
            someGsm.AddCall(new Call("12.5.2013", "12:33", "0885379136", 50));
            someGsm.AddCall(new Call("12.6.2013", "12:33", "0885379136", 10));

            foreach (Call call in someGsm.CallList)
            {
                Console.WriteLine(call.CallDetails());
            }

            Console.WriteLine(someGsm.CallPrice(someGsm.CallList));


            //we find the longest call
            int? currentLongestCall = 0;
            foreach(var call in someGsm.CallList)
            {
                if (currentLongestCall<call.Duration)
                {
                    currentLongestCall = call.Duration;
                }
            }
            //we delete the longest call
            foreach (var call in someGsm.CallList)
            {
                if (currentLongestCall==call.Duration)
                {
                    someGsm.CallList.Remove(call); break;
                }
            }

            someGsm.CallList.Clear();
            foreach (var call in someGsm.CallList)
            {
                Console.WriteLine(call.CallDetails());
            }
        }
    }
}
