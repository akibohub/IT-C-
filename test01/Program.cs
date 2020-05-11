using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello");
            //Console.ReadLine();
            //var message = "welcome to the csharp's world";
            //Console.WriteLine(message);
            Random random = new Random();
            var password = string.Empty;
            for(var i = 0; i < 10; i++)
            {
                password += random.Next(10);
            }
            Console.WriteLine(password);



        }
    }
}
