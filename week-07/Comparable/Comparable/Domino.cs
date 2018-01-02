using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    class Domino : IComparable
    {
        private readonly int[] Values;

        public int CompareTo(object domino)
        {
            Domino otherDomino = domino as Domino;
            if (this.Values[0] < otherDomino.Values[0])
            {
                return -1;
            }
            else if (this.Values[0] == otherDomino.Values[0])
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
