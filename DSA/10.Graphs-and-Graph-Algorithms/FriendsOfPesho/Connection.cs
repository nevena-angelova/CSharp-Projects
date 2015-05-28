using System;

namespace FriendsOfPesho
{
    class Connection
    {
        public Node ToNode { get; set; }

        public long Distance { get; set; }

        public Connection(Node node, long distance)
        {
            this.ToNode = node;
            this.Distance = distance;
        }
    }
}
