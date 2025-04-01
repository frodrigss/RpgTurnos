using System;

namespace RpgTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Deseja começar um novo jogo? (s para sim, n para não): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "s")
                {
                    Console.Clear();
                    Personagem Char = new Personagem();
                    Char.criarPersonagem();

                    Console.WriteLine("Pressione Enter para iniciar o jogo...");
                    Console.ReadLine();
                    Console.Clear();

                    Mapa mapa = new Mapa(Char);
                    mapa.iniciarJogo();
                }
                else if (resposta == "n")
                {
                    Console.WriteLine("Saindo do jogo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, por favor digite 's' ou 'n'.");
                }
            }
        }
    }
}
