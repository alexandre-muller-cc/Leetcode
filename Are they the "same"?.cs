sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AreTheySame
        {
            public static bool comp(int[] a, int[] b)
            {
                if ((a == null) || (b == null)) return false;
                int[] aa = a.Select(s => s * s).ToArray();
                Array.Sort(aa);
                Array.Sort(b);
                return aa.SequenceEqual(b);

            }
        }
