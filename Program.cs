using System;
using System.Text.RegularExpressions;

namespace DZ_CS_9
{
    internal partial class Program
    {
        public static void Iventsubscriber(string msg) => Console.WriteLine(msg);
        static void Main()
        {
            //Ex1();
            //Ex2();
            Ex3();
           
        }
        static void Ex1()
        {
            Console.WriteLine("-------------------Excercise 1-------------------");

            
            int[] ar = { 1, 1, 2, 3, 5, 8, 13 };
            action += ArrayEven;
            action += ArrayOdd;
            action += ArraySimples;
            action += ArrayFibonachi;
            action(ar);
            // метод по поиску чисел Фибоначчи работает как то криво, не смог разобраться до конца((
        }
        static void Ex2()
        {
            Console.WriteLine("-------------------Excercise 2-------------------");
            foreach (var action in actions)
            {
                action.Invoke();
            }


            double tArea = funcs[0].Invoke();
            Console.WriteLine("Area of the triangle:\t" + Math.Round(tArea, 3) + " sm^2");

            double rArea = funcs[1].Invoke();
            Console.WriteLine("Area of the rectangle:\t" + Math.Round(rArea, 3) + " sm^2");
        }
        static void Ex3()
        {
            CreditCard obj = new("1234 4321 5678 8675", "John Doe", new DateOnly(2023, 03, 15), 1485, 5000, 5100, 100000);
            obj.Confirmation += Iventsubscriber;
            obj.MoneyOperations += Iventsubscriber;
            bool correct = true;
            do
            {
                Console.Write("Choose operation:\n1. Show info\n2. Add money on card\n" +
                              "3. Take money from card\n4. Change PIN\n5. Exit\n");
                int chooser = Convert.ToInt32(Console.ReadLine());
                switch (chooser)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(obj.ToString());
                        break;
                    case 2:
                        Console.Clear();
                        obj.AddMoney();
                        break;
                    case 3:
                        Console.Clear();
                        obj.RemoveMoney();
                        break;
                    case 4:
                        Console.Clear();
                        obj.ChangePIN();
                        break;
                    case 5:
                        Console.Clear();
                        correct = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input!");
                        correct = true;
                        break;
                }

            } while (correct);
        }
    }
}