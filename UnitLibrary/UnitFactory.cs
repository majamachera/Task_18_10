using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLibrary
{
    public static class UnitFactory
    {
        public static Unit FromString(string text)
        {
            if (text.Equals("g"))
                return new Gram();
            if (text.Equals("mg"))
                return new Miligram();
            if (text.Equals("lbs"))
                return new Pound();
            if (text.Equals("oz"))
                return new Ounce();
            return null;

        }
    }
}
