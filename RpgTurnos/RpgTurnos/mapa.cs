using System;

namespace RpgTurnos
{
    public class Mapa
    {
        public Personagem Personagem { get; private set; }

        private string[] locais;
        private bool[,] conexoes;
        public string inicioLocal;

        public Mapa(Personagem personagem)
        {
            this.Personagem = personagem;
            inicioLocal = "Cidade central";
            locais = new string[]
            {
            "Cidade central",
            "Minas esquecidas",
            "Porto",
            "Cidade da floresta",
            "Deserto sem fim",
            "Ilha solitária"
            };

            conexoes = new bool[locais.Length, locais.Length];

            conexoes[0, 1] = true; // Cidade central <-> Minas esquecidas
            conexoes[0, 2] = true; // Cidade central <-> Porto
            conexoes[0, 3] = true; // Cidade central <-> Cidade da floresta
            conexoes[0, 4] = true; // Cidade central <-> Deserto sem fim

            conexoes[1, 0] = true; // Minas esquecidas <-> Cidade central
            conexoes[1, 3] = true; // Minas esquecidas <-> Cidade da floresta

            conexoes[2, 0] = true; // Porto <-> Cidade central
            conexoes[2, 5] = true; // Porto <-> Ilha solitária

            conexoes[3, 0] = true; // Cidade da floresta <-> Cidade central
            conexoes[3, 1] = true; // Cidade da floresta <-> Minas esquecidas

            conexoes[4, 0] = true; // Deserto sem fim <-> Cidade central

            conexoes[5, 2] = true; // Ilha solitária <-> Porto
        }

        public void iniciarJogo()
        {
            Console.WriteLine($"Bem-vindo, {Personagem.nome}! Você está na {inicioLocal}. Digite 'help' para ver os comandos.");
            Comandos comandos = new Comandos(this);
            comandos.Processar();
        }

        public void mostrarLugaresDisponiveis()
        {
            Console.WriteLine("Locais disponíveis para viajar:");
            int indiceAtual = Array.IndexOf(locais, inicioLocal);

            if (indiceAtual == -1)
            {
                Console.WriteLine("Local atual inválido.");
                return;
            }

            for (int i = 0; i < locais.Length; i++)
            {
                if (conexoes[indiceAtual, i])
                {
                    Console.WriteLine("- " + locais[i]);
                }
            }
        }

        public void viajarPara(string lugar)
        {
            int indiceAtual = Array.IndexOf(locais, inicioLocal);
            int indiceDestino = Array.FindIndex(locais, l => l.Equals(lugar, StringComparison.OrdinalIgnoreCase));

            if (indiceDestino == -1)
            {
                Console.WriteLine("Local não encontrado.");
                return;
            }

            if (conexoes[indiceAtual, indiceDestino])
            {
                inicioLocal = locais[indiceDestino];
                Console.Clear();
                Console.WriteLine($"Você viajou para {inicioLocal}!");

                // Chama os eventos dependendo do local
                Eventos eventos = new Eventos(Personagem);

                if (inicioLocal == "Minas esquecidas")
                {
                    eventos.GerarEvento(); // Gera o evento de Zumbi Antigo
                }
                else if (inicioLocal == "Deserto sem fim")
                {
                    eventos.GerarEvento(); // Gera o evento de Múmia do Deserto
                }
                else if (inicioLocal == "Porto")
                {
                    eventos.GerarEventoPorto(); // Gera o evento de Viajante Misterioso
                }
                else if (inicioLocal == "Ilha solitária")
                {
                    eventos.GerarEventoIlha(); // Gera o evento de Cardume de Piranhas
                }
            }
            else
            {
                Console.WriteLine("Local não acessível a partir daqui.");
            }
        }
    }

}