using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_nr3
{
    public static class ExtMth
    {
        public static int Ext(this int[] razy)
        {
            for (int i = 0; i < razy.GetLength(0); i++)
            {
                razy[i] = razy[i] * 10;
            }
            int x = razy.GetLength(0);

            return razy[x-1];
        }
    }
}
