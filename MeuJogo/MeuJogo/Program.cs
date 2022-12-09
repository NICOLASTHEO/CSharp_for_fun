using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuJogo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Theo, Dev C# dotnet");
            int x;
            x = 1001;
            Console.WriteLine(x);
            int y = 1000;
            Console.WriteLine(y);
            int calculo = x - y;
            Console.WriteLine("the result in x, "+x+" less y, "+y+" is: "+ calculo);
            float fl = 1.5f;
            Console.WriteLine("The float f is equal to: " + fl);
            string s = "Development in C#";
            Console.WriteLine(s);

            //Working with IF//
            int i = 1;
            int fi = 2;
            if (x!=y)
            {
                i = 5;
                fi = i + 1;
            }
            else
            {
                i = fi;
            }
            Console.WriteLine(i + " e " + fi);


            //LOOPS WITH: WHILE
            Console.WriteLine("The computer is fast, but");
            int w = 0;
            while (w < 5)
            {
                Console.WriteLine("I'm faster!");
                w++;       // It's the same w = w + 1;
            }
            Console.WriteLine(w);

            //LOOPS WITH: FOR
            Console.WriteLine("WHILE writes a lot,");

            for (int wh = 0; wh < 5; wh++)  // init, verify, increment
            {
                Console.WriteLine("FOR is faster though");
            }
            for (int teste = 0; teste <= 100; teste++)
            {
                Console.WriteLine(teste);
            }
            int yy = f(2);
            Console.WriteLine(yy);
            // above is the same that:
            Console.WriteLine(f(2));
            ImImproving();
        }
        // CREATING A FUNCTION TO BE USE INTO THE MAIN "ABOVE", AND THEN CALLING IT
        static int f(int x)
        {
            return x + 1;
        }
       
        static void ImImproving()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Always improving 10 times!");
            }
        }


    }
}
