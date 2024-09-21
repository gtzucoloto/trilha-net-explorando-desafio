namespace DesafioProjetoHospedagem.Models;

public class Reserva(int diasReservados)
{
    private List<Pessoa> Hospedes { get; set; } = [];
    private Suite Suite { get; set; }
    private int DiasReservados { get; set; } = diasReservados;

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count > Suite.Capacidade)
        {
            throw new ArgumentException($"A quantidade de hóspedes ({hospedes.Count}) não pode ser maior que a capacidade da suíte ({Suite.Capacidade})");
        }
        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite) => Suite = suite;

    public int ObterQuantidadeHospedes() => Hospedes.Count;

    public decimal CalcularValorDiaria()
    {
        var desconto = DiasReservados >= 10 ? 0.9M : 1M;
        return DiasReservados * Suite.ValorDiaria * desconto;
    }
}