using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Backup
{
    public class ServiceStorage
    {
        public List<Storage> storages = new List<Storage>();
        public double getTotalCapacity()
        {
            double sum = 0;
            for (int i = 0; i < storages.Count; i++)
            {
                sum += storages[i].getCapacity();
            }
            return sum;
        }

        public TimeSpan getTimeCopying(Flash flash, double mem)
        {
            TimeSpan time;
            if (flash.getfreeCapacity() < mem)
            {
                time = new TimeSpan(0, 0, 0);
            }

            else
            {
                double tmp = mem / flash.speed;
                time = TimeSpan.FromSeconds(tmp);
            }
            return time;
        }

        public void getCountStorage(double v)
        {
            for (int i = 0; i < storages.Count; i++)
            {
                string info = string.Format("{0}) {1} Count: {2}", i + 1, storages[i].getInfo(), v / storages[i].getCapacity());
                Console.WriteLine(info);
            }
        }

        public void T(Flash flash, double memory)
        {
            if (memory > flash.getfreeCapacity())
            {
                throw new Exception("No memory");
            }
            else
            {
                for (int i = 0; i < getTimeCopying(flash, memory).Minutes; i++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Console.WriteLine("Copy yes");
            }
        }


    }
}

