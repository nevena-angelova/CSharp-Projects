using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray
{
    class BitArray : IEnumerable<int>
    {
        ulong bitArray64;

        public BitArray(ulong bitArray64)
        {
            this.bitArray64 = bitArray64;
        }

        public int[] ConvertToBits() // converts the ulong number into a bits array
        {
            int[] bits = new int[64];
            ulong value = this.bitArray64; // if the original field is used, at the end of the loop its value is 0, and if it is used later it is still 0

            for (int i = 0; i < 64; i++)
            {
                bits[i] = (int)value % 2;
                value /= 2;
            }

            return bits;
        }

        public int this[int index] // returns the indexed bit
        {
            get { return this.ConvertToBits()[index]; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i]; // uses the implemented indexer[]
            }
        }

        public override bool Equals(object obj)
        {
            BitArray temp = obj as BitArray;

            if (temp == null)
            {
                return false;
            }

            return this.bitArray64.Equals(temp.bitArray64);
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            return BitArray.Equals(first, second);
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            return !BitArray.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
