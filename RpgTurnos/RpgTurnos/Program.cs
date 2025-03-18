using System;

namespace RpgTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem Char = new Personagem();
            Char.criarPersonagem();
            Itens Equips = new Itens();
            Equips.cadastrarItem();
        }
    }
}