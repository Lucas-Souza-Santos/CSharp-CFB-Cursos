namespace Aula34
{
    public class Carro : Veiculo
    {
        private int velMax;
        private bool ligado;
        public Carro(int velMax, bool ligado) : base(velMax, ligado)
        {
            this.velMax = velMax;
            this.ligado = ligado;
        }

        public new int getVelMax()
        {
            return this.velMax;
        }
        public new void setVelMax(int v)
        {
            this.velMax = v;
        }
        public new bool getLigado()
        {
            return this.ligado;
        }
        public new void setLigado(bool l)
        {
            this.ligado = l;
        }

        
    }
}