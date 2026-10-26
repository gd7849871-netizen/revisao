    using revisao;  

using System;
using System.Collections.Generic;

//igor

Igormacedo pessoa = new Igormacedo();
    

            pessoa.Idade = 17;
            pessoa.Nome = "Igor";
            pessoa.Sexo = "Masculino";
            pessoa.NumeroCel = "31972432641";
            pessoa.CPF = "16134687685";
            pessoa.Email = "igormacedosilveira5522@gmail.com";

            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Sexo: {pessoa.Sexo}");
            Console.WriteLine($"Numero de Celular: {pessoa.NumeroCel}");
            Console.WriteLine($"CPF: {pessoa.CPF}");
            Console.WriteLine($"Email: {pessoa.Email}");

    



    //======================================================================================================gabriel=============================================================================================================

    personagem Status = new personagem();

    Status.id = 1;
    Status.Nome = "Gabriel";
    Status.Idade = "16";
    Status.raca = "Elfo";
    Status.Dinheiro = "10000";
    Status.Descricao = "jovem guerreiro elfo da tribo dos ventos, com habilidades de combate corpo a corpo, magia e arco, nascido no reino clover com um diferencial de n possuir a habilidade essencial de controle da agonia queé  elento fundamental do controle de mana onde esse reino magia é TUDO , e ele deseja acabar com a discriminação com os fracos e raça carregando com um coisa em mente, A sua magia É n desistir jamais";
    Status  .Forca = 23;
    Status.Inteligencia = 20;
    Status.Agilidade = 25;
    Status.Carisma = 20;
    Status.Mana = 450;
    Status.Arcana = 30;
    Status.Resistencia = 20;
    Status.Agonia = 0;
    Status.determinacao = 100;
    Status.HP = 200;

Status.ExibirDados();