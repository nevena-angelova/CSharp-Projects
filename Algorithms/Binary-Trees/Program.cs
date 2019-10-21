using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class Program
    {
        static void Main()
        {
            //var admins = new BST<int, string>();


            //admins.Put(11, "Nevena");

            //admins.Put(21, "Petur");

            //admins.Put(2, "Lili");

            //admins.Put(3, "Sasho");

            //admins.Put(33, "Mimi");

            //admins.Put(6, "Ani");


            var letters = new BST<string, int>();


            letters.Put("S", 1);
            letters.Put("X", 2);
            letters.Put("E", 3);
            letters.Put("A", 4);
            letters.Put("C", 5);
            letters.Put("R", 6);
            letters.Put("H", 7);
            letters.Put("M", 8);


            //var floor = letters.Floor("G");

            //var node = letters.GetNode("E");


            //var size = letters.Size();

            //var keys = letters.Keys();

            var min = letters.Min();

        }
    }
}
