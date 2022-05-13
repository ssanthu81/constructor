using System;
namespace cons
{
    
    public class expcon
    {
        int x;
        public expcon(int i)
        {
            i = x;
            Console.WriteLine("expcon" + i);

        }
        public void  dis(){

            Console.WriteLine("expcon" +x);

            }
            static void Main(string[] args)
            {

                expcon c1 = new expcon(10);
            expcon c2 = new expcon(20);
        c1.dis();

        Console.WriteLine();
            }
        }
    }

