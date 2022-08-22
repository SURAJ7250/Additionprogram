using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Addition \n2.Substraction \n3.Exit");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("choose an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Add code = new Add();
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        code.Addition(a, b);
                        break;
                    case 2:
                        Substraction sub1 = new Substraction();
                        int c = Convert.ToInt32(Console.ReadLine());
                        int d = Convert.ToInt32(Console.ReadLine());
                        sub1.substraction(c, d);
                        break;

                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("choose an correct option");
                        break;


                }
            }
        }
    }
}
