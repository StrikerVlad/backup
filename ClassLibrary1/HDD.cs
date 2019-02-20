using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    public class HDD : Storage
    {
        public HDD(double capacity) :base(capacity)
        {

        }

        public int CountSections { get; set; }

        public double VolumeSections { get; set; }

        public USBType USBType { get; set; }
        public override void CopyInfo()
        {

        }
    }
}
