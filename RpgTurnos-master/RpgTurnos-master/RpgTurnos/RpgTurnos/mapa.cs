using System;
using System.Collections.Generic;
using System.Linq;

namespace RpgTurnos
{
    public class Mapa
    {
        private Dictionary<string, List<string>> conexoes;
        public string inicioLocal;
        private Personagem personagem;

        public Mapa(Personagem personagem)
        {
            this.personagem = personagem;
            inicioLocal = "Cidade central";
            conexoes = new Dictionary<string, List<string>>
            {
                { "Cidade central", new List<string> { "Minas esquecidas", "Porto", "Cidade da floresta", "Deserto sem fim" } },
                { "Minas esquecidas", new List<string> { "Cidade central", "Cidade da floresta" } },
                { "Porto", new List<string> { "Cidade central", "Ilha solitária" } },
                { "Cidade da floresta", new List<string> { "Cidade central", "Minas esquecidas" } },
                { "Deserto sem fim", new List<string> { "Cidade central" } },
                { "Ilha solitária", new List<string> { "Porto" } }
            };
        }

        public void iniciarJogo()
        {
            Console.WriteLine("Iniciando o jogo...");
            Console.WriteLine($"Bem vindo, {personagem.nome}! Você está na {inicioLocal}. Digite 'help' para ver os comandos.");
            processarComandos();
        }

        private void processarComandos()
        {
            while (true)
            {
                Console.Write("> ");
                string comando = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (comando == "help")
                {
                    Console.WriteLine("Comandos disponíveis:");
                    Console.WriteLine("!m - Mostrar locais disponíveis para viajar.");
                    Console.WriteLine("!m [nome do local] - Viajar para o local especificado.");
                }
                else if (comando == "!m")
                {
                    mostrarLugaresDisponiveis();
                }
                else if (comando.StartsWith("!m "))
                {
                    string lugar = comando.Substring(3).Trim();
                    viajarPara(lugar);
                }
                else
                {
                    Console.WriteLine("Comando não reconhecido. Digite 'help' para ver os comandos.");
                }
            }
        }

        private void mostrarLugaresDisponiveis()
        {
            Console.WriteLine("Locais disponíveis para viajar:");
            foreach (var local in conexoes[inicioLocal])
            {
                Console.WriteLine("- " + local);
            }
        }

        private void viajarPara(string lugar)
        {
            var lugarDisponivel = conexoes[inicioLocal].FirstOrDefault(l =>
                string.Equals(l, lugar, StringComparison.OrdinalIgnoreCase));

            if (lugarDisponivel != null)
            {
                inicioLocal = lugarDisponivel;
                Console.WriteLine($"Você viajou para {inicioLocal}!");
            }
            else
            {
                Console.WriteLine("Local não encontrado ou não acessível a partir daqui.");
            }
        }
    }
}