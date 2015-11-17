using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class FullBeverage : Beverage
    {
        public override string ToString()
        {
            return string.Format("ID: {0} | Desc: {1} | Pack: {2}", this.id, this.name, this.pack);
        }
    }
}
