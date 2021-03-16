using Aula43.interfaces;

namespace Aula43.classes
{
    public class Carro: Veiculo, Combate
    {
        public Carro()
        {

        }

        public bool ligado;

        public void ligar()
        {
            this.ligado = true;
        }
        public void desligar()
        {
            this.ligado = false;
        }
        public void info()
        {

        }
        public void disparar()
        {

        }
    }
}