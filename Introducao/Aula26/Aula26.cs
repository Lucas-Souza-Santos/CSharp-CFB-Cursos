using System;

namespace Aula26
{
    class Aula26
    {
        static void Main()
        {
            int divi, divis, quoc, rest;
            divi = 10; divis = 5;
            quoc = divide(divi, divis, out rest);

            Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", divi, divis, quoc, rest);
            
        }

        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente; 
            quociente = dividendo / divisor;
            resto = dividendo % divisor;

            return quociente;
             
        }
    }
}
