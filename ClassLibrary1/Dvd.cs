using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    public enum DVDtype
    {
        onesided, twosided
    }

    public class Dvd : Storage
    {
        public Dvd(double capacity) : base(capacity)
        {

        }

        public double speedRead { get; set; }
        public double speedWrite { get; set; }

        public override void CopyInfo()
        {

        }
    }
}
