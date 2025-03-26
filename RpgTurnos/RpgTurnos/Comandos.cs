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
                else
                {
                    Console.WriteLine("Comando não reconhecido. Digite 'help' para ver os comandos.");
                }
            }
        }
    }
}