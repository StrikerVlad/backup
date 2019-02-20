using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    public enum USBType
    {
        USB20,
        USB30
    }
    public class Flash: Storage
    {
        public Flash(double capacity) : base(capacity)
        {
            
        }
       public USBType USBType { get; set; }

       public double speed { get; set; }

        public override void CopyInfo()
        {
            
        }
    }
}
