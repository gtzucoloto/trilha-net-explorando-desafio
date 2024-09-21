using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

try
{
    // Cria os modelos de hóspedes e cadastra na lista de hóspedes
    List<Pessoa> hospedes = [
        new (nome: "José", sobrenome:"Silva"),
        new (nome: "Maria",sobrenome:"Soares")
    ];

    // Cria a suíte
    var suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 300);

    // Cria uma nova reserva, passando a suíte e os hóspedes
    var reserva = new Reserva(diasReservados: 20);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine($"Hóspedes({reserva.ObterQuantidadeHospedes()}): {string.Join(", ", hospedes.Select(h => h.NomeCompleto))}.");
    Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}