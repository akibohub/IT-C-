using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Chapter1-4 記号をランダムに	生成せよ！
/// </summary>
namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 10;
            var password = MakeMark(count);
            Console.WriteLine(password);
        }     
        private static string MakeMark(int count)
        {
            string[] marks = { "!", "#", "$", "%", "&", "@" };
            Random random = new Random();
            var password = string.Empty;
            for(var i = 0; i < count; i++)
            {
                var n = random.Next(marks.Length);//Lengthプロパティで配列の要素数を取得できる　今回は6
                password += marks[n];
            }
            return password;
        }
        
            //英大文字をランダムに生成するメソッド　文字数は引数countの値に準ずる
       private static string MakeUpperLetter(int count)
        {
            
            Random random = new Random();
            var password = string.Empty;
            for(var i = 0; i < count; i++)
            {
                var n = random.Next(65, 91);
                var c = (char)n;
                password += c.ToString();
            }
            return password;
        }
       
            //英小文字をランダムに生成するメソッド　文字数は引数countの値に準ずる
            private static string MakeLowerLetter(int count)
        {
            Random random = new Random();
            var password = string.Empty;
            for(var i = 0; i < count; i++)
            {
                var n = random.Next(97, 123);
                var c = (char)n;
                password += c.ToString();
            }
            return password;
        }



        //数字をランダムに生成するメソッド　文字数は引数countの値に準ずる
        private static string MakePassword(int count)
        {
            Random random = new Random();
            var password = string.Empty;
            for(var i = 0; i < count; i++)
            {
                password += random.Next(10);
            }
            return password;
        }
       
    }
}
