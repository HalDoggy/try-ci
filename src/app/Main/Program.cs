using System;
using ClassLibrary1;

namespace Main
{
    class Program
    {
        private static Add m_add = new Add();
        private static Subtraction m_sub = new Subtraction();

        static void Main(string[] args)
        {
            string input = args[0];
            int a;
            int b;

            if (input.Contains('+'))
            {
                a = int.Parse(input.Split('+')[0]);
                b = int.Parse(input.Split('+')[1]);
                Console.WriteLine(m_add.Do(a, b));
            }
            else if (input.Contains('-'))
            {
                a = int.Parse(input.Split('-')[0]);
                b = int.Parse(input.Split('-')[1]);
                Console.WriteLine(m_sub.Do(a, b));
            }
        }
    }
}
