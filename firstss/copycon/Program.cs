using System;

namespace copycon
{
    class MainClass
    {
        int x =100, y= 200;


        public static void Main(string[] args)
        {
            MainClass m = new MainClass();
            MainClass m1 = new MainClass();
            MainClass m2 = new MainClass();

            Console.WriteLine(m.x+ "  "+m.y);
            Console.WriteLine(m1.x + "  " + m1.y);
            Console.ReadLine();
            
        }
    }
}
