using System;

namespace RpgTurnos
{
    class Itens
    {
        string[,] equipamentos = new string[20, 5];

        public void cadastrarItem()
        {
            // !cabeçalho
            equipamentos[0, 0] = "Item";
            equipamentos[0, 1] = "Tipo";
            equipamentos[0, 2] = "Valor";
            equipamentos[0, 3] = "Dano";
            equipamentos[0, 4] = "Defesa";
            equipamentos[0, 5] = "Slots";

            // !itens
            // adaga
            equipamentos[1, 0] = "Adaga";
            equipamentos[1, 1] = "Arma de curto alcance";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "2";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";
            // espada longa
            equipamentos[2, 0] = "Espada longa";
            equipamentos[2, 1] = "Arma de médio alcance";
            equipamentos[2, 2] = "50";
            equipamentos[2, 3] = "8";
            equipamentos[2, 4] = "0";
            equipamentos[2, 5] = "2";
            // arco curto
            equipamentos[3, 0] = "Arco";
            equipamentos[3, 1] = "Arma de longo alcance";
            equipamentos[3, 2] = "35";
            equipamentos[3, 3] = "5";
            equipamentos[3, 4] = "0";
            equipamentos[3, 5] = "1";
            // cajado místico
            equipamentos[4, 0] = "Cajado místico";
            equipamentos[4, 1] = "Arma de longo alcance";
            equipamentos[4, 2] = "45";
            equipamentos[4, 3] = "3";
            equipamentos[4, 4] = "0";
            equipamentos[4, 5] = "3";
            // escudo grande
            equipamentos[5, 0] = "Escudo grande";
            equipamentos[5, 1] = "Defesa";
            equipamentos[5, 2] = "60";
            equipamentos[5, 3] = "1";
            equipamentos[5, 4] = "7";
            equipamentos[5, 5] = "2";
            // armadura de couro
            equipamentos[6, 0] = "Armadura de couro";
            equipamentos[6, 1] = "Defesa";
            equipamentos[6, 2] = "25";
            equipamentos[6, 3] = "0";
            equipamentos[6, 4] = "4";
            equipamentos[6, 5] = "2";
            // elmo de ferro
            equipamentos[7, 0] = "Elmo de ferro";
            equipamentos[7, 1] = "Proteção";
            equipamentos[7, 2] = "30";
            equipamentos[7, 3] = "0";
            equipamentos[7, 4] = "3";
            equipamentos[7, 5] = "1";
            // poção de vida
            equipamentos[8, 0] = "Poção de vida";
            equipamentos[8, 1] = "Consumível";
            equipamentos[8, 2] = "15";
            equipamentos[8, 3] = "0";
            equipamentos[8, 4] = "0";
            equipamentos[8, 5] = "0";
            // anel de ouro
            equipamentos[9, 0] = "Anel de ouro";
            equipamentos[9, 1] = "Acessório";
            equipamentos[9, 2] = "100";
            equipamentos[9, 3] = "0";
            equipamentos[9, 4] = "0";
            equipamentos[9, 5] = "1";
            // botas de aço
            equipamentos[10, 0] = "Botas de aço";
            equipamentos[10, 1] = "Defesa";
            equipamentos[10, 2] = "55";
            equipamentos[10, 3] = "0";
            equipamentos[10, 4] = "2";
            equipamentos[10, 5] = "1";
            // capa noturna
            equipamentos[11, 0] = "Capa Noturna";
            equipamentos[11, 1] = "Especiais";
            equipamentos[11, 2] = "175";
            equipamentos[11, 3] = "0";
            equipamentos[11, 4] = "2";
            equipamentos[11, 5] = "1";
            // amuleto de fogo
            equipamentos[12, 0] = "Amuleto de fogo";
            equipamentos[12, 1] = "Acessório";
            equipamentos[12, 2] = "90";
            equipamentos[12, 3] = "4";
            equipamentos[12, 4] = "0";
            equipamentos[12, 5] = "1";
            // martelo de guerra
            equipamentos[13, 0] = "Martelo de guerra";
            equipamentos[13, 1] = "Arma de médio alcance";
            equipamentos[13, 2] = "70";
            equipamentos[13, 3] = "10";
            equipamentos[13, 4] = "0";
            equipamentos[13, 5] = "3";
            // balestra
            equipamentos[14, 0] = "Balestra";
            equipamentos[14, 1] = "Arma de longo alcance";
            equipamentos[14, 2] = "85";
            equipamentos[14, 3] = "12";
            equipamentos[14, 4] = "0";
            equipamentos[14, 5] = "2";
            // placas de mithil
            equipamentos[15, 0] = "Placas de mithril";
            equipamentos[15, 1] = "Armadura";
            equipamentos[15, 2] = "150";
            equipamentos[15, 3] = "0";
            equipamentos[15, 4] = "12";
            equipamentos[15, 5] = "4";
            // grimório velho
            equipamentos[16, 0] = "Grimório velho";
            equipamentos[16, 1] = "Especiais";
            equipamentos[16, 2] = "?";
            equipamentos[16, 3] = "15";
            equipamentos[16, 4] = "0";
            equipamentos[16, 5] = "3";
            // bracelete de defesa
            equipamentos[17, 0] = "Bracelete de defesa";
            equipamentos[17, 1] = "Acessório";
            equipamentos[17, 2] = "80";
            equipamentos[17, 3] = "0";
            equipamentos[17, 4] = "5";
            equipamentos[17, 5] = "1";
            // flechas de prata
            equipamentos[18, 0] = "Flechas de prata";
            equipamentos[18, 1] = "Munição";
            equipamentos[18, 2] = "5";
            equipamentos[18, 3] = "3";
            equipamentos[18, 4] = "0";
            equipamentos[18, 5] = "10";
            // pergamiho antigo
            equipamentos[19, 0] = "Pergaminho antigo";
            equipamentos[19, 1] = "Livro";
            equipamentos[19, 2] = "25";
            equipamentos[19, 3] = "7";
            equipamentos[19, 4] = "0";
            equipamentos[19, 5] = "0";
            // Luvas de ferro
            equipamentos[20, 0] = "Luvas de ferro";
            equipamentos[20, 1] = "Armadura";
            equipamentos[20, 2] = "40";
            equipamentos[20, 3] = "0";
            equipamentos[20, 4] = "3";
            equipamentos[20, 5] = "1";

            ListarItens();
        }

        public void ListarItens()
        {
            Console.Clear();
            for (int i = 0; i < equipamentos.GetLength(0); i++)
            {
                for (int j = 0; j < equipamentos.GetLength(1); j++)
                {
                    Console.Write(equipamentos[i, j].PadRight(18));
                }
                Console.WriteLine();
            }
        }
    }
}