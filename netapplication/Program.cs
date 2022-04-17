using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int num = 4;
            string name = "Abrar";
            /*
            Console.WriteLine(num);
            Console.WriteLine(number);
            Console.WriteLine("Starting");
            Console.WriteLine(name);
            addNumber(); */
            trueJudge(true);
        }

        static void addNumber()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+b);
            Console.ReadLine();
        }

        static void trueJudge(bool a)
        {
            if (a == true){
                Console.WriteLine("It's true");
            }
            else if (a == false)
            {
                Console.WriteLine("It's false");
            }
        }

       
    }
}
