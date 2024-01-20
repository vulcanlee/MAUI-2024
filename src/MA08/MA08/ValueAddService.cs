using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA08
{
    public class ValueAddService : IValueAddService
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
