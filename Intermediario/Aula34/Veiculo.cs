namespace Aula34
{
    public class Veiculo
    {
        private int velMax;
        private bool ligado;

        public Veiculo(int velMax, bool ligado) 
        {
            this.setVelMax(velMax);
            this.setLigado(ligado);
        }
        
        public bool getLigado()
        { 
            return this.ligado;
        }
        public void setLigado(bool l) 
        { 
            this.ligado = l;
        }
        public int getVelMax() 
        { 
            return this.velMax;
        }
        public void setVelMax(int v) 
        { 
            this.velMax = v;
        }
            
    }
}