﻿using System;
using System.Threading;

namespace TIC_TAC_TOE
{ 
    class Program
    {

        static char[] arr = {'0','1','2','3','4','5','6','7','8','9'};

        static int player = 1;
        static int chois;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1 : X and Player2 : 0");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 chance");
                }
                else
                {
                    Console.WriteLine("Player 1 chance");
                }

                Console.WriteLine("\n");
                board();

                chois = int.Parse(Console.ReadLine());

                if (arr[chois] != 'X' && arr[chois] != '0')
                {
                    if (player % 2 == 0)
                    {
                        arr[chois] = '0';
                        player++;
                    }
                    else
                    {
                        arr[chois] = 'X';
                        player++;
                    }

                }
                else
                {
                    Thread.Sleep(2000);

                }

                flag = Checkwin();

            }while (flag != 1 && flag != -1);

            Console.Clear();
            board();

            if (flag == 1)
            {
                Console.WriteLine("Player 1 has won", (player % 2) + 1);

            }
            else
            {
                Console.WriteLine("Draw");

            }
            Console.ReadLine();

        }
        private static void board()
        {
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", arr[1], arr[2], arr[3]);
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", arr[4], arr[5], arr[6]);
                Console.WriteLine("___|___|___");
                Console.WriteLine("   |   |   ");
                Console.WriteLine(" {0} | {1} | {2} ", arr[7], arr[8], arr[9]);
                Console.WriteLine("___|___|___");
           
        }

        private static int Checkwin()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;

            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;

            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;

            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;

            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;

            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;

            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;

            }
            else if (arr[7] == arr[5] && arr[5] == arr[3])
            {
                return 1;

            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
                
            }
            else
            {
                return 0;
            }
        }


        
    }
}
