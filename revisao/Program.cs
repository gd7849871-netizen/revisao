using revisao;

class Program
{
    static void Main(string[] args)
    {
        Igormacedo pessoa = new Igormacedo();

        pessoa.Idade = 17;
        pessoa.Nome = "Igor";
        pessoa.Sexo = "Masculino";
        pessoa.NumeroCel = 31972432641;
        pessoa.CPF = 16134687685;
        pessoa.Email = "igormacedosilveira5522@gmail.com";

        Cosole.WriteLine($"Idade: {pessoa.Idade}");
        Cosole.WriteLine($"Nome: {pessoa.Nome}");
        Cosole.WriteLine($"Sexo: {pessoa.Sexo}");
        Cosole.WriteLine($"Numero de Celular: {pessoa.NumeroCel}");
        Cosole.WriteLine($"CPF: {pessoa.CPF}");
        Cosole.WriteLine($"Email: {pessoa.Email}");
    }
}
