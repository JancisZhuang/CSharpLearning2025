using System;

namespace MyApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*1 - Hello, World!*/
            //Console.WriteLine("Hello, World!");
            //Console.ReadKey(); // 👈 关键！防止窗口关闭

            /*2 - string*/
            //string aFriend = "Bill";
            //Console.WriteLine("Hewllo " + aFriend);
            //aFriend = "Maira";
            //Console.WriteLine($"Hello {aFriend}");

            /*$字符串插值*/
            //string firstFriend = "Bill";
            //string secondFriend = "Maira";
            //Console.WriteLine($"My first friend is {firstFriend} and second is {secondFriend}");

            //Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            //Console.WriteLine($"old name: {secondFriend}  New name:{secondFriend.Replace("M","D")}");
            
            /*Trim 去除空格*/
            //string greeting = "   Hello World!   ";
            //Console.WriteLine($"[{greeting}]");

            //string trimmedGreeting = greeting.TrimStart();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.TrimEnd();
            //Console.WriteLine($"[{trimmedGreeting}]");

            //trimmedGreeting = greeting.Trim();
            //Console.WriteLine($"[{trimmedGreeting}]");

            /*  replace */
            string songLyrics = "You say goodbye, and I say hello";
            //Console.WriteLine(songLyrics);
            //songLyrics = songLyrics.Replace("goodbye", "hello");
            //Console.WriteLine(songLyrics);
            /* upper lower */
            //Console.WriteLine(songLyrics.ToLower());
            //Console.WriteLine(songLyrics.ToUpper());
            /* contains */
            //Console.WriteLine(songLyrics.Contains("hello"));
            //Console.WriteLine(songLyrics.Contains("greeting"));


            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("goodbay"));







            //Console.ReadKey();
        }
    }
}