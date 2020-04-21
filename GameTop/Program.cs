using System;
using GameTop.lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFoda(
                new Jogador1("Ronaldo"),
                new jogador2());
            jogo.iniciarJogo();
        }
    }

   
}
