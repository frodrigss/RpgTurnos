using System;

namespace RpgTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do personagem
            Personagem Char = new Personagem();
            Char.criarPersonagem();

            // Aguarda o usuário pressionar Enter
            Console.WriteLine("Pressione Enter para iniciar o jogo...");
            Console.ReadLine();
            Console.Clear();

            // Inicializa o mapa e o jogo
            Mapa mapa = new Mapa(Char);
            mapa.iniciarJogo();
        }
    }
}