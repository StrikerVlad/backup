using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    abstract public class Storage
    {

        public Storage(double capacity)
        {
            this.Capacity = Capacity;
        }
        protected string Name { get; set; }

        protected string Model { get; set; }

        protected double Capacity { get; set; }

        public int Memory { get; set; }
        
        public virtual double getCapacity()
        {
            return Capacity;
        }

        public abstract void CopyInfo();

        public virtual double getfreeCapacity()
        {
            return Capacity-Memory;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("{0}({1})-{2}gb",Name, Model, Capacity);
        }
        public virtual string getInfo()
        {
            return string.Format("{0}({1})-{2}gb", Name, Model, Capacity);
        }
    }
}
