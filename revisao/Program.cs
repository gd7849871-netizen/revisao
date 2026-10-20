using revisao;

class Program
{
    static void Main(string[] args)
    {
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
    }
}
