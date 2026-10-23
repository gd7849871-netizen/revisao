using System;
using System.Collections.Generic;

namespace revisao
{




    using System;

    public static class
    {
        public static List<personagem> BancoDados = new List<personagem>();
        public static void Adicionar()
        {
            personagem personagem = new personagem();
            personagem.id = BancoDados.Count > 0 ? BancoDados.Count + 1 : 1;
            Console.WriteLine("Usuário digite seu nome");
            personagem.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            personagem.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("raca");
            personagem.raca = Console.ReadLine();
           Console.WriteLine("Digite a quantidade de dinheiro");
            personagem.Dinheiro = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a descrição do personagem");
            personagem.Descricao = Console.ReadLine();
            Console.WriteLine("Digite a força do personagem");
            personagem.Forca = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a inteligência do personagem");
            personagem.Inteligencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a agilidade do personagem");
            personagem.Agilidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o carisma do personagem");
            personagem.Carisma = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de mana do personagem");
            personagem.Mana = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de arcana do personagem");
            personagem.Arcana = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a resistência do personagem");
            personagem.Resistencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a agonia do personagem");
            personagem.Agonia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a determinação do personagem");
            personagem.determinacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de HP do personagem");
            personagem.HP = int.Parse(Console.ReadLine());


            BancoDados.Add(personagem);
        }
        public static void ListarProvas()
        {
            foreach (Prova item in BancoDados)
            {
                item.ExibirDados();
            }
        }
    }

}