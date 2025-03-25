using System;

namespace RpgTurnos
{
    public enum classePersonagem
    {
        Guerreiro = 1,
        Arqueiro = 2,
        Mago = 3,
        Monge = 4,
        Barbaro = 5,
        Assassino = 6
    }

    public class Personagem
    {
        public string nome;
        public classePersonagem classe;
        public int vida;
        public int energia;
        public int ataque;
        public int resistencia;
        public int nivel;
        public int experiencia;
        public int vidaPorNivel;
        public int energiaPorNivel;

        public void criarPersonagem()
        {
            nome = obterNome();
            classe = escolherClasse();
            definirAtributos();
            mostrarDetalhes();
        }

        private string obterNome()
        {
            Console.WriteLine("Digite o nome do seu personagem:");
            return Console.ReadLine() ?? "";
        }

        private classePersonagem escolherClasse()
        {
            int escolha;
            do
            {
                mostrarMenuClasse();
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    if (escolha == 1)
                    {
                        return classePersonagem.Guerreiro;
                    }
                    else if (escolha == 2)
                    {
                        return classePersonagem.Arqueiro;
                    }
                    else if (escolha == 3)
                    {
                        return classePersonagem.Mago;
                    }
                    else if (escolha == 4)
                    {
                        return classePersonagem.Monge;
                    }
                    else if (escolha == 5)
                    {
                        return classePersonagem.Barbaro;
                    }
                    else if (escolha == 6)
                    {
                        return classePersonagem.Assassino;
                    }
                }
                Console.WriteLine("Opção inválida! Tente novamente.");
            } while (true);
        }


        private static void mostrarMenuClasse()
        {
            Console.Clear();
            Console.WriteLine("CLASSES DISPONÍVEIS:");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Arqueiro");
            Console.WriteLine("3 - Mago");
            Console.WriteLine("4 - Monge");
            Console.WriteLine("5 - Bárbaro");
            Console.WriteLine("6 - Assassino");
            Console.Write("Escolha uma classe (1-6): ");
        }

        private void definirAtributos()
        {
            experiencia = 0;
            nivel = 1;

            switch (classe)
            {
                case classePersonagem.Guerreiro:
                    vida = 200;
                    energia = 50;
                    ataque = 10;
                    resistencia = 10;
                    vidaPorNivel = 25;
                    energiaPorNivel = 5;
                    break;
                case classePersonagem.Arqueiro:
                    vida = 125;
                    energia = 125;
                    ataque = 14;
                    resistencia = 6;
                    vidaPorNivel = 15;
                    energiaPorNivel = 15;
                    break;
                case classePersonagem.Mago:
                    vida = 75;
                    energia = 175;
                    ataque = 16;
                    resistencia = 4;
                    vidaPorNivel = 5;
                    energiaPorNivel = 25;
                    break;
                case classePersonagem.Monge:
                    vida = 150;
                    energia = 100;
                    ataque = 8;
                    resistencia = 12;
                    vidaPorNivel = 20;
                    energiaPorNivel = 10;
                    break;
                case classePersonagem.Barbaro:
                    vida = 250;
                    energia = 30;
                    ataque = 18;
                    resistencia = 8;
                    vidaPorNivel = 30;
                    energiaPorNivel = 3;
                    break;
                case classePersonagem.Assassino:
                    vida = 100;
                    energia = 150;
                    ataque = 20;
                    resistencia = 5;
                    vidaPorNivel = 10;
                    energiaPorNivel = 20;
                    break;
            }
        }

        private void mostrarDetalhes()
        {
            Console.Clear();
            Console.WriteLine($"Bem-vindo {nome}, você é um {classe}!");
            Console.WriteLine($"Nível: {nivel}");
            Console.WriteLine($"Experiência: {experiencia}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Energia: {energia}");
            Console.WriteLine($"Ataque: {ataque}");
            Console.WriteLine($"Resistência: {resistencia}");
            Console.WriteLine($"Vida por nível: {vidaPorNivel}");
            Console.WriteLine($"Energia por nível: {energiaPorNivel}");
        }
    }
}