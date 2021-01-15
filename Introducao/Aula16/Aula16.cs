using System;

namespace Aula16
{
    class Aula16
    {
        static void Main()
        {
            int cont = 0;
            inicio:

            Console.WriteLine("Passei aqui");
                        
            if(cont == 3){
                Console.WriteLine("Adeus");
            }
            else
            {   
                Console.WriteLine(cont);
                cont++;
                goto inicio;
                
            }
        }
    }
}