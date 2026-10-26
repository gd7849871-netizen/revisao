using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace revisao
{
    public class PersonagemRepository
    {
        private const string MeuBanco  = "Data Source=.Personagens.db";

        public static void InicializarBanco()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                CREATE TABLE IF NOT EXISTS Personagens (
                    id INTEGER PRIMARY KEY ,
                    Nome TEXT NOT NULL,
                    Idade TEXT NOT NULL,
                    raca TEXT NOT NULL,
                    Dinheiro TEXT NOT NULL,
                    Descricao TEXT NOT NULL,
                    forca INTEGER NOT NULL,
                    inteligencia INTEGER NOT NULL,
                    agilidade INTEGER NOT NULL,
                    carisma INTEGER NOT NULL,
                    mana INTEGER NOT NULL,
                    arcana INTEGER NOT NULL,
                    resistencia INTEGER NOT NULL,
                    agonia INTEGER NOT NULL,    
                    determinacao INTEGER NOT NULL,
                    HP INTEGER NOT NULL

             
               );
";
            comando.ExecuteNonQuery();
        }
        public static void AdicionarPersonagem(personagem personagem)
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();
            using var comando = conexao.CreateCommand();
            comando.CommandText = @"
                INSERT INTO Personagens (Nome, Idade, raca, Dinheiro, Descricao, forca, inteligencia, agilidade, carisma, mana, arcana, resistencia, agonia, determinacao, HP)
                VALUES ($Nome, $Idade, $raca, $Dinheiro, $Descricao, $forca, $inteligencia, $agilidade, $carisma, $mana, $arcana, $resistencia, $agonia, $determinacao, $HP);
            ";
            comando.Parameters.AddWithValue("$Nome", personagem.Nome);
            comando.Parameters.AddWithValue("$Idade", personagem.Idade);
            comando.Parameters.AddWithValue("$raca", personagem.raca);
            comando.Parameters.AddWithValue("$Descricao", personagem.Descricao);



            comando.Parameters.AddWithValue("$Dinheiro", personagem.Dinheiro);
            comando.Parameters.AddWithValue("$forca", personagem.Forca);
            comando.Parameters.AddWithValue("$inteligencia", personagem.Inteligencia);
            comando.Parameters.AddWithValue("$agilidade", personagem.Agilidade);
            comando.Parameters.AddWithValue("$carisma", personagem.Carisma);
            comando.Parameters.AddWithValue("$mana", personagem.Mana);
            comando.Parameters.AddWithValue("$arcana", personagem.Arcana);
            comando.Parameters.AddWithValue("$resistencia", personagem.Resistencia);
            comando.Parameters.AddWithValue("$agonia", personagem.Agonia);
            comando.Parameters.AddWithValue("$determinacao", personagem.determinacao);
            comando.Parameters.AddWithValue("$HP", personagem.HP);


            comando.ExecuteNonQuery();
        }

            public static List<personagem> ListarPersonagens()

        
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM Personagens";


            using var leitor = comando.ExecuteReader();
            var personagens = new List<personagem>();

            while (leitor.Read())
            {
                var personagem = new personagem
                {
                    id = leitor.GetInt32(0),
                    Nome = leitor.GetString(1),
                    Idade = leitor.GetString(2),
                    raca = leitor.GetString(3),
                    Dinheiro = leitor.GetString(4),
                    Descricao = leitor.GetString(5),
                    Forca = leitor.GetInt32(6),
                    Inteligencia = leitor.GetInt32(7),
                    Agilidade = leitor.GetInt32(8),
                    Carisma = leitor.GetInt32(9),
                    Mana = leitor.GetInt32(10),
                    Arcana = leitor.GetInt32(11),
                    Resistencia = leitor.GetInt32(12),
                    Agonia = leitor.GetInt32(13),
                    determinacao = leitor.GetInt32(14),
                    HP = leitor.GetInt32(15)
                };
                personagens.Add(personagem);
            }
            return personagens;
        }
    }
