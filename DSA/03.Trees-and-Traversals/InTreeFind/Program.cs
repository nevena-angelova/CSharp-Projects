/// You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node),
/// each in the range (0..N-1).
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Node<int>[] nodes = new Node<int>[n];

        for (int i = 0; i < n; i++)
        {
            nodes[i] = new Node<int>(i);
        }

        for (int j = 1; j <= n - 1; j++)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            int parent = int.Parse(inputSplit[0]);
            int child = int.Parse(inputSplit[1]);

            nodes[parent].Children.Add(nodes[child]);
            nodes[child].HasParent = true;
        }

        // a) find the root node
        Node<int> root = FindRoot(nodes);
        Console.WriteLine("The root of the tree is: {0}", root.Value);

        // b) find all leaf nodes
        List<Node<int>> listNodes = FindLeafs(nodes);
        Console.Write("The leafs in the tree are: ");

        foreach (Node<int> listNode in listNodes)
        {
            Console.Write("{0}, ", listNode.Value);
        }

        Console.WriteLine();

        // c) find all middle nodes
        List<Node<int>> middleNodes = FindMiddleNodes(nodes);
        Console.Write("The middle nodes in the tree are: ");

        foreach (Node<int> middleNode in middleNodes)
        {
            Console.Write("{0}, ", middleNode.Value);
        }

        Console.WriteLine();

        // d) find the longest path in the tree

        int maxPath = FindMaxPath(FindRoot(nodes));
        Console.WriteLine("The longest path is: {0}", maxPath);

    }

    public static Node<int> FindRoot(Node<int>[] nodes)
    {
        foreach (Node<int> node in nodes)
        {
            if (!node.HasParent)
            {
                return node;
            }
        }

        throw new ArgumentException("The tree has no root!");
    }

    public static List<Node<int>> FindLeafs(Node<int>[] nodes)
    {
        List<Node<int>> listNodes = new List<Node<int>>();

        foreach (Node<int> node in nodes)
        {
            if (node.Children.Count == 0)
            {
                listNodes.Add(node);
            }
        }

        return listNodes;
    }

    public static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
    {
        List<Node<int>> middleNodes = new List<Node<int>>();

        foreach (Node<int> node in nodes)
        {
            if (node.Children.Count > 0 && node.HasParent)
            {
                middleNodes.Add(node);
            }
        }

        return middleNodes;
    }

    public static int FindMaxPath(Node<int> root)
    {
        if (root.Children.Count == 0)
        {
            return 0;
        }

        int maxPath = 0;

        foreach (Node<int> child in root.Children)
        {
            maxPath = Math.Max(maxPath, FindMaxPath(child));
        }

        return maxPath + 1;
    }
}