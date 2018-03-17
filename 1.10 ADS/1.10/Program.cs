using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._10
{
    public class GraphCode
    {
        public class Edge
        {
            public int FirstNode;
            public int SecondNode;

            public Edge(int firstNode, int secondNode)
            {
                this.FirstNode = firstNode;
                this.SecondNode = secondNode;
            }

            public override string ToString()
            {
                return FirstNode + " " + SecondNode;
            }
        }

        private readonly List<Edge> Edges = new List<Edge>();

        public override string ToString()
        {
            string str = null;
            foreach (var edge in Edges)
                str += "\r\n" + edge;
            return "Edges:" + str;
        }

        public GraphCode(int[,] mi)
        {
            var nodes = new List<int>();
            for (int j = 0; j < mi.GetLength(1); j++)
            {
                nodes.Clear();
                for (int i = 0; i < mi.GetLength(0); i++)
                {
                    if (mi[i, j] != 0)
                        nodes.Add(i);
                }
                var edge = new Edge(nodes[0], nodes[1]);
                Edges.Add(edge);
            }
        }

        public int[,] GetMi()
        {
            var matrix = new int[Edges.Count() - 1, Edges.Count()];
            for (int i = 0; i < Edges.Count() - 1; i++)
            {
                for (int j = 0; j < Edges.Count(); j++)
                {
                    if ((Edges[i].FirstNode == j) || (Edges[i].SecondNode == j))
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        public void Insert(int i, int j)
        {
            Edge edge = new Edge(i, j);
            Edges.Add(edge);
        }

        public void Delete(int i, int j)
        {
            for (int k = 0; k < Edges.Count; k++)
            {
                if (Edges[k].FirstNode == i && Edges[k].SecondNode == j)
                {
                    Edges.Remove(Edges[k]);
                    break;
                }
            }
        }

        public List<Edge> GraphCod(int i)
        {
            var list = new List<Edge>();
            foreach (var edge in Edges)
            {
                if (edge.FirstNode == i || edge.SecondNode == i)
                    if (!list.Contains(edge))
                        list.Add(edge);
            }
            return list;
        }

        public void Modify(int i)
        {
            for (int k = 0; k < Edges.Count(); k++)
            {
                if (Edges[k].FirstNode == i || Edges[k].SecondNode == i)
                {
                    Delete(Edges[k].FirstNode, Edges[k].SecondNode);
                }
            }
        }

        public List<int> Show(int m)
        {
            var list = new List<int>();
            var count = 0;
            var mi = GetMi();
            for (int i = 0; i < mi.GetLength(0); i++)
            {
                for (int j = 0; j < mi.GetLength(1); j++)
                {
                    if (mi[i, j] == 1)
                    {
                        count++;
                    }
                }
                if (count >= m)
                {
                    list.Add(i);
                }
                count = 0;
            }
            return list;
        }
    }

    public class Program
    {
        static void Main()
        {

        }
    }
}
