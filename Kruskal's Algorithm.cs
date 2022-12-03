using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {

        static int V = 5;
        static int[] parent = new int[V];
        static int INF= int.MaxValue ;

        // Find set of vertex i
        static int find(int i)
        {
            while (parent[i] != i)
                i = parent[i];
            return i;
        }
        
        //  union i and j
        static void union(int i, int j)
        {
            int a = find(i);
            int b = find(j);
            parent[a] = b;
        }

        
        static void kruskalMST(int[,] cost)
        {
            int mincost = 0; // Cost of min MST.

            // Make set for every vertex
            for (int i = 0; i < V; i++)
                parent[i] = i;

            // order edges by weight , min : max
            int edge_count = 0;
            while (edge_count < V - 1)
            {
                int min = INF, u = -1, v = -1;
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        if (find(i) != find(j) && cost[i, j] < min)
                        {
                            min = cost[i, j];
                            u = i;
                            v = j;
                        }
                    }
                }

                union(u, v);
                Console.Write(" {0}: Vertices({1}, {2}) , cost={3} \n",
                    ++edge_count, u, v, min);
                mincost += min;
                
            }
            Console.WriteLine("\n Minimum cost= {0}", mincost);
        }

        
        public static void Main(String[] args)
        {
           
            int[,] cost =
                {
                    { 50, 2 , 12,  6, 16 },
                    {  2, 50,  3,  8,  5 },
                    { 12,  3, 50, 11,  7 },
                    {  6,  8, 11, 50,  9 },
                    { 16,  5,  7,  9, 50 },
                };

            //Print
            kruskalMST(cost);
            Console.ReadLine();
        }
    }
                 
    
}
