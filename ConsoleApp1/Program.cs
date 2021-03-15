using System;

namespace ConsoleApp1
{
    class Program
    {
        const int N = 8;
        const int M = 8;
        const int Y = 8;
        const int U = 8;

        static void Print2(int n, int m, int[,] a)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write(a[i, j] + "=======");
                Console.Write("\r\n");
            }
        }

        static void Main(string[] args)
        {
            int[,] Map = new int[U, Y];
            Map[2, 2] = 1;

            int[,] A = new int[N, M];
            int i, j;
            for (j = 0; j < M; j++)
                A[0, j] = 1;
            for (i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (j = 1; j < M; j++)
                    if (Map[i, j] == 0)
                    {
                        A[i, j] = A[i, j - 1] + A[i - 1, j];
                    }
                    else if (Map[i, j] == 1)
                    {
                        A[i, j] = 0;
                    };

            }

            Print2(N, M, A);
        }
    }
}
