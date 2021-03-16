using System;

namespace Aula35
{
    class Aula35
    {
        static void Main()
        {
            Carro c1 = new Carro("Rapidãõ", "Vermelho");

            Console.WriteLine("Cor....................: {0}", c1.cor);
            Console.WriteLine("Nome...................: {0}", c1.nome);
            Console.WriteLine("Rodas..................: {0}", c1.getRodas());
            Console.WriteLine("VelMax.................: {0}", c1.velMax);
            Console.WriteLine("Ligado.................: {0}", c1.getLigado());
            
            Console.WriteLine("-----------------------------------");

            CarroCombate cc1 = new CarroCombate();
            
            Console.WriteLine("Cor....................: {0}", cc1.cor);
            Console.WriteLine("Nome...................: {0}", cc1.nome);
            Console.WriteLine("Rodas..................: {0}", cc1.getRodas());
            Console.WriteLine("VelMax.................: {0}", cc1.velMax);
            Console.WriteLine("Monição.................: {0}", cc1.monicao);
        }
        
        class Veiculo
        {
            private int rodas; 
            public int velMax;
            private bool ligado;
            
            public Veiculo(int rodas)
            {
                this.rodas = rodas;
            }
            public void ligar()
            {
                ligado = true; 
            }
            public void desligar()
            {
                ligado = false; 
            }
            public string getLigado()
            {
                return (ligado ? "Sim": "Não");
            }

            public int getRodas()
            {
                return rodas;
            }
            public void setRodas(int rodas)
            {
                if(rodas < 0)
                {
                    this.rodas = 0;
                }
                else if(rodas > 8)
                {
                    this.rodas = 0;
                }
                else
                {
                    this.rodas = rodas;
                }
            }
        }

        class Carro:Veiculo
        {
            public string nome {get; set;}
            public string cor {get; set;}
            public Carro(string nome, string cor): base(0)
            {
                desligar();
                setRodas(2);
                velMax = 120;
                this.nome = nome;
                this.cor = cor;
            }
        }

        class CarroCombate: Carro
        {
            public int monicao;

            public CarroCombate(): base("Carro de Combate", "Verde")
            {
                monicao = 100;
            }
        }
    }
}