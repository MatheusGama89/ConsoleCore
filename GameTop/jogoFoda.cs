using GameTop.Interface;

namespace GameTop
{
    public class jogoFoda{

        public iJogador _jogador1 { get; }
        public iJogador _jogador2 { get; }
        public jogoFoda(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void iniciarJogo()
        {
            System.Console.Write(_jogador1.Chuta());
            System.Console.Write(_jogador1.Passe());
            System.Console.Write(_jogador1.Corre());

            System.Console.Write("------Jogador 2------ \n");

            System.Console.Write(_jogador2.Chuta());
            System.Console.Write(_jogador2.Passe());
            System.Console.Write(_jogador2.Corre());
        }
    }
}