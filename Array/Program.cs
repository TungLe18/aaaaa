using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ////mang mot chieu
            //string[] Strudent = { "Nguyen Van A", "Nguyen Van B"};
            //int[] mark;
            //mark = new int[2];
            //mark[0] = 10;
            //mark[1] = 9;

            //Console.WriteLine(Strudent[0] + ":" + mark[0]);
            //Console.ReadLine();

            ////mang 2 chieu
            //int[,] so = new int[10, 10];
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        so[i, j] = (i + 1) * j;
            //        Console.WriteLine(" " + so[i, j]);
            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();


            ////mang hai chieu duwoc dinh nghia truoc

            //string[][] compai = new string[2][];
            //compai[0] =new string[] { "Tung", "Nguyet" };
            //compai[1] = new string[] { "Tung", "Quynh" };
            //for (int i = 0; i < compai.GetLength(0); i++)
            //{
            //    Console.Write("List" + (i + 1) + "have:");
            //    for (int j = 0; j < compai.GetLength(0); j++)

            //    {
            //        Console.Write(compai[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.ReadLine();

            //khai bao phan tu foreach
            int[] so = new int[10];
            for (int i = 0; i < 10; i++)
            {
                so[i] = i;
            }
                foreach (int Socanin in so)
                {

                    Console.WriteLine(Socanin);
                }
                Console.ReadLine();
            }
         
        }
        }
    

