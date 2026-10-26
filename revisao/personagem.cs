public class personagem
{


    public List<string> Status { get; set; } = new List<string>();

    // Informações básicas

    public string Nome { get; set; }
    public string Idade { get; set; }
    public string raca { get; set; }

    public string Descricao { get; set; }

    // Atributos principais

    public List<int> statuInt { get; set; } = new List<int>();
    public int id { get; set; }
    public string Dinheiro { get; set; }
    public int Forca { get; set; }
    public int Inteligencia { get; set; }
    public int Agilidade { get; set; }
    public int Carisma { get; set; }

    // Atributos mágicos
    public int Mana { get; set; }
    public int Arcana { get; set; }

    // Atributos de resistência
    public int Resistencia { get; set; }
    public int Agonia { get; set; }
    public int determinacao { get; set; }
    // Pontos de vida
    public int HP { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Raça: {raca}");
        Console.WriteLine($"Dinheiro: {Dinheiro}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Força: {Forca}");
        Console.WriteLine($"Inteligência: {Inteligencia}");
        Console.WriteLine($"Agilidade: {Agilidade}");
        Console.WriteLine($"Carisma: {Carisma}");
        Console.WriteLine($"Mana: {Mana}");
        Console.WriteLine($"Arcana: {Arcana}");
        Console.WriteLine($"Resistência: {Resistencia}");
        Console.WriteLine($"Agonia: {Agonia}");
        Console.WriteLine($"Determinação: {determinacao}");
        Console.WriteLine($"HP: {HP}");

        foreach (String item in Status)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine("Gabarito");
        int contador = 0;

        foreach (char g in statuInt)
        {
            contador++;
            Console.WriteLine($"{contador} - {g}");
        }
    }
}