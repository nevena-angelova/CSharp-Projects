namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private static void QuickSort(IList<T> collection, int left, int right)
        {

            int i = left;
            int j = right;
            T pivot = collection[(left + right) / 2];

            // arrange the elements that are smaller than the pivot at the left side and the bigger at right by replasing their places only if
            // the i-th element is bigger than the pivot and the j-th element is smaller than the pivot. Otherwise the elements are skiped.
            // the comparison incudes the pivot itself.

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                    i++;
                while (collection[j].CompareTo(pivot) > 0)
                    j--;
                if (i <= j)
                {
                    T tmp = collection[i];
                    collection[i++] = collection[j];
                    collection[j--] = tmp;
                }
            }

            // here i <= j (they are placed somewhere in the middle). QuickSort is applied recursively at first at the left side, by separating
            // it at another 2 pieces, then again to the left side of the left piece and so on till j > left.
            // Then QuickSort is applied at the last parted piece's right side and so on.

            if (j > left)
            {
                QuickSort(collection, left, j);
            }
            if (i < right)
            {
                QuickSort(collection, i, right);
            }
        }
    }
}