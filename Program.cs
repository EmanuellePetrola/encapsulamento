internal class Pessoa
{
    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set
        {
            _nome = value;
        }
    }
}
}

Pessoa p = new Pessoa();
p.Nome = "Marcos";
Console.WriteLine(p.Nome);



