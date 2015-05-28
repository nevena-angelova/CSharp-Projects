using System;
using System.Collections.Generic;

namespace FriendsOfPesho
{
    public class Program
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');

            int pointsNumber = int.Parse(inputNumbers[0]);
            int streetsNumber = int.Parse(inputNumbers[1]);
            int hospitalNumber = int.Parse(inputNumbers[2]);

            string[] allHospitals = Console.ReadLine().Split(' ');

            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();

            for (int i = 0; i < streetsNumber; i++)
            {
                string[] street = Console.ReadLine().Split(' ');
                int firstNode = int.Parse(street[0]);
                int secondNode = int.Parse(street[1]);
                int distance = int.Parse(street[2]);

                if (!allNodes.ContainsKey(firstNode))
                {
                    allNodes.Add(firstNode, new Node(firstNode));
                }

                Node firstNodeObject = allNodes[firstNode];

                if (!allNodes.ContainsKey(secondNode))
                {
                    allNodes.Add(secondNode, new Node(secondNode));
                }

                Node secondNodeObject = allNodes[secondNode];

                if (!graph.ContainsKey(firstNodeObject))
                {
                    graph.Add(firstNodeObject, new List<Connection>());
                }

                if (!graph.ContainsKey(secondNodeObject))
                {
                    graph.Add(secondNodeObject, new List<Connection>());
                }

                graph[firstNodeObject].Add(new Connection(secondNodeObject, distance));
                graph[secondNodeObject].Add(new Connection(firstNodeObject, distance));
            }

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int hospital = int.Parse(allHospitals[i]);

                allNodes[hospital].IsHospital = true;
            }

            long result = long.MaxValue;

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospital = int.Parse(allHospitals[i]);

                DijkstraAlgorithm(graph, allNodes[currentHospital]);

                long tempSum = 0;

                foreach (var node in allNodes)
                {
                    if (!node.Value.IsHospital)
                    {
                        tempSum += node.Value.DijkstraDistance;
                    }
                }

                if (tempSum < result)
                {
                    result = tempSum;
                }

                Console.WriteLine(result);
            }
        }

        static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();

            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = long.MaxValue;
            }

            source.DijkstraDistance = 0;

            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();

                if (currentNode.DijkstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var connection in graph[currentNode])
                {
                    var potentialDistance = currentNode.DijkstraDistance + connection.Distance;

                    if (potentialDistance < connection.ToNode.DijkstraDistance)
                    {
                        connection.ToNode.DijkstraDistance = potentialDistance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }
    }
}