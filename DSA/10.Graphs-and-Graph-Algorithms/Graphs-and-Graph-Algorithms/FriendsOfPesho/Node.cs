using System;

namespace FriendsOfPesho
{
    class Node : IComparable
    {
        public int Id { get; set; }

        public long DijkstraDistance { get; set; }

        public bool IsHospital { get; set; }

        public Node(int id)
        {
            this.Id = id;
            this.IsHospital = false;
        }

        public int CompareTo(object obj)
        {
            return this.DijkstraDistance.CompareTo((obj as Node).DijkstraDistance);
        }
    }
}
