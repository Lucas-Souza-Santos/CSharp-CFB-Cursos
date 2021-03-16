using System;

namespace Aula41
{
    class Aula41
    {
        static void Main()
        {
            Console.Clear();
            Carro c1 = new Carro();
            c1.SetVelMax(200);
            Console.WriteLine(c1.GetVelMax());
        }

        class Carro
        {
            private int velMax;

            public Carro()
            {
                 this.velMax = 120;
            }

            public int GetVelMax()
            {
                return velMax;
            }

            public void SetVelMax(int value)
            {
                velMax = value;
            }
        }
    }
}