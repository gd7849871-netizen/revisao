public class personagem
{
    public List<string> Status { get; set; } = new List<string>();

    // Informações básicas
    public int id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string raca { get; set; }
    public double Dinheiro { get; set; }
    public string Descricao { get; set; }

    // Atributos principais
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
}