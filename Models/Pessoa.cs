namespace DesafioProjetoHospedagem.Models;

public class Pessoa(string nome, string sobrenome)
{
    private string Nome { get; } = nome;
    private string Sobrenome { get; } = sobrenome;
    
    public Pessoa(string nome) : this(nome, string.Empty) { }
    
    public string NomeCompleto => string.IsNullOrWhiteSpace(Sobrenome) ? Nome.ToUpper() : $"{Nome} {Sobrenome}".ToUpper();
}