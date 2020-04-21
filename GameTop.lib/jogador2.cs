using GameTop.Interface;

namespace GameTop.lib
{
    public class jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas Chutando \n";
        }

        public string Corre()
        {
            return "Maradona estas Correndo\n";
        }

        public string Passe()
        {
            return "Maradona estas Passando\n";
        }
    }
}