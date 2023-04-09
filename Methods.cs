namespace DZ_CS_9
{
    internal partial class Program
    {
        static Action<int[]>? action;
        static Action[] actions = { DateShow, TimeShow, DayOfWeekShow };
        static Func<double>[] funcs = { TriangleArea, RectangleArea };


        static void ArrayEven(int[] array)
        {
            Console.WriteLine("Even elements of array:");
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        static void ArrayOdd(int[] array)
        {
            Console.WriteLine("Odd elements of array:");
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        static void ArraySimples(int[] array)
        {
            Console.WriteLine("Simple elements of array:");
            foreach (var item in array)
            {
                if (item != 1 && item % 1 == 0 && item % item == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }

        static void ArrayFibonachi(int[] array)
        {
            double GoldLine = (1 + Math.Sqrt(5)) / 2;
            double minusGoldLine = (1 - Math.Sqrt(5)) / 2;
            Console.WriteLine("Fibonachi elements of array:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == (Math.Pow(GoldLine, i + 1) - Math.Pow(minusGoldLine, i + 1)) / Math.Sqrt(5))
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }


        static void TimeShow()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("Current time is:\t" + time.ToLongTimeString());
        }

        static void DateShow()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Current date is:\t" + date.ToShortDateString());
        }

        static void DayOfWeekShow()
        {
            DateTime dayCurrent = DateTime.Now;
            Console.WriteLine("Day of week:\t\t" + dayCurrent.DayOfWeek.ToString());
        }

        static double TriangleArea()
        {
            Console.WriteLine("----------------Triangle area----------------");
            double a, b, c, p;
            // считать площадь будем по формуле Герона
            Console.Write("Enter length of first side:\t");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of second side:\t");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of third side:\t");
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }

        static double RectangleArea()
        {
            Console.WriteLine("----------------Rectangle area----------------");
            double a, b;
            Console.Write("Enter length of first side:\t");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter length of second side:\t");
            b = Convert.ToDouble(Console.ReadLine());
            return a * b;
        }
    }

}
