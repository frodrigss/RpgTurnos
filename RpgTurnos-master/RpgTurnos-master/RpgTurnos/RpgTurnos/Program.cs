using System;

namespace RpgTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem Char = new Personagem();
            Char.criarPersonagem();

            Mapa mapa = new Mapa(Char);
            mapa.iniciarJogo();
        }
    }
}