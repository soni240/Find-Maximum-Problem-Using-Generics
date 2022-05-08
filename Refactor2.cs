using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_Maximum_String
{
    internal class Refactor2
    {
        private int[] intArray;
        private double[] doubleArray;
        private string[] stringArray;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public GenericMaximum(int[] intArray)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.intArray = intArray;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public GenericMaximum(double[] doubleArray)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.doubleArray = doubleArray;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public GenericMaximum(string[] stringArray)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.stringArray = stringArray;
        }

        internal void PrintMaxValue()
        {
            throw new NotImplementedException();
        }
    }
}

    }
}
