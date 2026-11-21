using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class MyArr
    {
        int[] arr;
        public int Length;

        public MyArr(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        public int this[double index]
        {
            get
            {
                return arr[(int)Math.Round(index)];
            }

            set
            {
                arr[(int)Math.Round(index)] = value;
            }
        }
    }
}
