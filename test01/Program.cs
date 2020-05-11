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
            int count = 14;
            var password = MakePassword(count);//MakePasswordメソッドを呼び出す
            Console.WriteLine(password);
        }
        private static string MakePassword(int count)
        {
            Random random = new Random();
            var password = string.Empty;
            for (var i = 0; i < 10; i++)//引数countの値を繰り返しの回数に使用している
            {
                password += random.Next(count);
            }
            return password;
        }
    }
}
