using System;

namespace RpgTurnos
{
    public class Comandos
    {
        private Mapa _mapa;

        public Comandos(Mapa mapa)
        {
            _mapa = mapa;
        }

        public void Processar()
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
                    Console.WriteLine("!a - Mostrar atributos do personagem.");
                }
                else if (comando == "!m")
                {
                    _mapa.mostrarLugaresDisponiveis();
                }
                else if (comando.StartsWith("!m "))
                {
                    string lugar = comando.Substring(3).Trim();
                    _mapa.viajarPara(lugar);
                }
                else if (comando == "!a")
                {
                    MostrarAtributosPersonagem();
                }
                else
                {
                    Console.WriteLine("Comando não reconhecido. Digite 'help' para ver os comandos.");
                }
            }
        }

        private void MostrarAtributosPersonagem()
        {
            var personagem = _mapa.Personagem;
            Console.WriteLine($"Nome: {personagem.nome}");
            Console.WriteLine($"Classe: {personagem.classe}");
            Console.WriteLine($"Vida: {personagem.vida}");
            Console.WriteLine($"Energia: {personagem.energia}");
            Console.WriteLine($"Ataque: {personagem.ataque}");
            Console.WriteLine($"Resistência: {personagem.resistencia}");
            Console.WriteLine($"Nível: {personagem.nivel}");
            Console.WriteLine($"Experiência: {personagem.experiencia}");
            Console.WriteLine($"Vida por Nível: {personagem.vidaPorNivel}");
            Console.WriteLine($"Energia por Nível: {personagem.energiaPorNivel}");
        }
    }
}
