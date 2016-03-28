﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CogNetworks
{
    class ShortestPathAlgo
    {
        int current, prev, next, source, destination;
        public string[] route=new string[9];

        int[,] graph = new int[9, 9] {{0, 4, 0, 0, 0, 0, 0, 8, 0},
                                  {4, 0, 8, 0, 0, 0, 0, 11, 0},
                                  {0, 8, 0, 7, 0, 4, 0, 0, 2},
                                  {0, 0, 7, 0, 9, 14, 0, 0, 0},
                                  {0, 0, 0, 9, 0, 10, 0, 0, 0},
                                  {0, 0, 4, 0, 10, 0, 2, 0, 0},
                                  {0, 0, 0, 14, 0, 2, 0, 1, 6},
                                  {8, 11, 0, 0, 0, 0, 1, 0, 7},
                                  {0, 0, 2, 0, 0, 0, 6, 7, 0}
                                 };

        /// <summary>
        /// Method to calculate the shortest path
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="src"></param>
        /// <returns></returns>
        public int dijkstra(int src, int destination)
        {
            int[] dist = new int[9]; //output array
            src -=1;
            int minimumDistance = 0;

            // sptSet[i] will true if vertex i is included in shortest
            // path tree or shortest distance from src to i is finalized
            Boolean[] sptSet = new Boolean[9];

            // Initialize all distances as INFINITE and stpSet[] as false
            for (int i = 0; i < 9; i++)
            {
                dist[i] = Int32.MaxValue;
                sptSet[i] = false;
            }

            // Distance of source vertex from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < 9 - 1; count++)
            {
                // Pick the minimum distance vertex from the set of vertices
                // not yet processed. u is always equal to src in first
                // iteration.
                int u = minDistance(dist, sptSet);

                // Mark the picked vertex as processed
                sptSet[u] = true;

                // Update dist value of the adjacent vertices of the
                // picked vertex.
                for (int v = 0; v < 9; v++)

                    // Update dist[v] only if is not in sptSet, there is an
                    // edge from u to v, and total weight of path from src to
                    // v through u is smaller than current value of dist[v]
                    if (!sptSet[v] && graph[u, v] != 0 &&
                            dist[u] != Int32.MaxValue &&
                            dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        route[v] = route[v]+ graph[u, v].ToString()+",";
                        if (destination-1==v && u==src)
                        {
                            minimumDistance = dist[v];
                        }
                    }

            }

            // print the constructed distance array
            // printSolution(dist, 9,src);
            return minimumDistance;
        }


        int minDistance(int[] dist, Boolean[] sptSet)
        {
            // Initialize min value
            int min = Int32.MaxValue, min_index = -1;

            for (int v = 0; v < 9; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        // A utility function to print the constructed distance array
        void printSolution(int[] dist, int n, int src)
        {
            String msg = "";
            for (int i = 0; i < 9; i++)
                msg += String.Format("{0}   {1}\n", i + 1, dist[i]);

            //MessageBox.Show(msg, "Table");
            System.Windows.Forms.MessageBox.Show(msg);
            //int[] newarray = new int[9] { Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, Int32.MaxValue };
            //for (int i = 0; i < 9; i++)
            //{
            //    if (dist[i] == 0 || i == prev)
            //    {

            //    }
            //    else
            //    {

            //        newarray[i] = dist[i];
            //    }

            //}
        }


        int indexofSmallestElement(int[] array, int size)
        {
            int index = 0;

            for (int i = 1; i < size; i++)
            {
                if (array[i] < array[index])
                    index = i;
            }

            return index;
        }
    }
}
