using System;

namespace RpgTurnos
{
    public class Eventos
    {
        private Random random;
        private Personagem personagem;

        public Eventos(Personagem personagem)
        {
            this.personagem = personagem;
            this.random = new Random();
        }

        public void GerarEvento()
        {
            int evento = random.Next(1, 101);

            if (evento <= 75)
            {
                Console.WriteLine("Você foi atacado por um zumbi antigo nas minas esquecidas!");
                personagem.vida -= 30;
                Console.WriteLine($"Você perdeu 30 de vida! Vida restante: {personagem.vida}");
            }
            else if (evento <= 100)
            {
                Console.WriteLine("Você foi atacado por uma múmia do deserto!");
                personagem.vida -= 20;
                Console.WriteLine($"Você perdeu 20 de vida! Vida restante: {personagem.vida}");
            }
        }

        public void GerarEventoPorto()
        {
            int evento = random.Next(1, 101);

            if (evento <= 50)
            {
                Console.WriteLine("Você foi atacado por um viajante misterioso no porto!");
                personagem.vida -= 40;
                Console.WriteLine($"Você perdeu 40 de vida! Vida restante: {personagem.vida}");
            }
        }

        public void GerarEventoIlha()
        {
            int evento = random.Next(1, 101); 
            if (evento <= 50)
            {
                Console.WriteLine("Você foi atacado por um cardume de piranhas na ilha solitária!");
                personagem.vida -= 50;
                Console.WriteLine($"Você perdeu 50 de vida! Vida restante: {personagem.vida}");
            }
        }
    }
}
