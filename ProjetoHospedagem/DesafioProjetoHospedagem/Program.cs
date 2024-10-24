using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Criando lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Criando a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Criando a reserva
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibindo o resultado
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");
