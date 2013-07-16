using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_Timer
{
    class Timer
    {
        public static void Start(Action action, double t)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep((int)(t * 1000));
                    action();
                }
            });
        }
    }
}
