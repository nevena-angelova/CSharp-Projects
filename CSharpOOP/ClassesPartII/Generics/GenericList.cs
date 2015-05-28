// ex. 5, ex. 6, ex. 7

using System;
using System.Text;

namespace Generics
{
    public class GenericList<T>
    {

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        // add element

        public void AddElement(T element)
        {
            if (this.elements.Length > count)
            {
                this.elements[count] = element;
                count++;
            }
            else
            {
                AutoGrow();
                this.elements[count] = element;
                count++;
            }
        }

        // accsess element by index

        public T this[int index]
        {
            get
            {
                if (index < count)
                {
                    return this.elements[index];
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
                }
            }
        }

        // remove element by index

        public void RemoveElement(int index)
        {
            if (index < count)
            {
                T[] temp = new T[count - 1];
                int tempIndex = 0;

                // goes trough all the items in "elements" and if "i" is not = to the given index
                // adds the current element to the temp array, wich length is 1 less than the length of "elements" array

                for (int i = 0; i < count; i++)
                {
                    if (i != index)
                    {
                        temp[tempIndex] = this.elements[i];
                        tempIndex++;
                    }
                }

                // assign the temp array to "elements" array and decrease "count" by 1

                this.elements = temp;

                count--;
            }
            else
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }
        }

        // insert element at position

        public void InsertElementAt(T element, int index)
        {
            if (index < count)
            {
                T[] temp = new T[count + 1];
                int tempIndex = 0;

                // goes trough all the items in "elements" array and if "i" is = to the given index
                // adds the given by index element to the temp array

                for (int i = 0; i < count; i++)
                {
                    if (i == index)
                    {
                        temp[tempIndex] = element;
                        tempIndex++;
                    }

                    temp[tempIndex] = elements[i];
                    tempIndex++;
                }

                this.elements = temp;
                count++;
            }
            else
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }
        }

        // clear all the elements

        public void ClearElements()
        {
            int capacity = elements.Length;
            this.elements = new T[capacity]; // assign a new blank array with the former capacity
            count = 0;
        }

        // find element by its value

        public int FindElementByValue(T value)
        {
            return Array.IndexOf(this.elements, value);
        }

        // override ToString

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(elements[i]);
            }

            return result.ToString();
        }

        // Auto Grow Functionality (ex. 6)

        public void AutoGrow()
        {
            int capacity = this.elements.Length;
            T[] temp = new T[capacity * 2];

            for (int i = 0; i < count; i++)
            {
                temp[i] = this.elements[i];
            }

            this.elements = temp;

        }

        // find minimal (ex. 7)

        public static T Min<T>(GenericList<T> list) where T : IComparable<T>
        {
            T min = list[0];

            for (int i = 0; i < list.count ; i++)
            {
                if (list[i].CompareTo(min) <= 0)
                {
                    min = list[i];
                }
            }

            return min;
        }

        // find maximal (ex. 7)

        public static T Max<T>(GenericList<T> list) where T : IComparable<T>
        {
            T max= list[0];

            for (int i = 0; i < list.count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }

    }
}
