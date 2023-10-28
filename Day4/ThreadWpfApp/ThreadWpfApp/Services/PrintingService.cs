using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadWpfApp.Services
{
    internal class PrintingService
    {
        public void Print()
        {
            DateTime startTime = DateTime.UtcNow;
            TimeSpan future = TimeSpan.FromSeconds(8);

            while (DateTime.UtcNow - startTime < future)
            {
                Debug.WriteLine("delay :" + DateTime.Now.ToString("hh : mm : ss"));
                
            }
            Debug.WriteLine("Delay over");
        }

        public Task PrintAsync1() {

            return Task.Run(Print);
        }

        public Task<int> PrintAsync2()
        {

           return  Task.Run(() => {
                Print();
                Random r = new Random();
                return r.Next(1,10);
            });
        }
    }
}
