namespace ProjectCommon;

public class Pessoa
{
    public Pessoa()
    { 
        
    }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public Pessoa(string nome, string sobrenome, int idade)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Idade = idade;
    }
    private string _nome = string.Empty;
    private int _idade = 0;

    public string? NomeCompleto
    {
        get
        {
            return $"{Nome} {Sobrenome}".ToUpper();
        }
    }
    public string? Sobrenome { get; set; }

    public string Nome
    {
        get
        {
            return _nome.ToUpper();
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio ou nulo.");
            }
            _nome = value;
        }
    }

    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser negativa.");
            }
            _idade = value;
        }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
