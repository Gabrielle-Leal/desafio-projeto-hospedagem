using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        // Método para cadastrar hóspedes
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Número de hóspedes excede a capacidade da suíte.");
            }
        }

        // Método para cadastrar a suíte
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // Método para calcular o valor total da diária
        public double CalcularValorDiaria()
        {
            double valorTotal = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados > 10)
            {
                valorTotal *= 0.90; // Aplicando 10% de desconto
            }

            return valorTotal;
        }

        // Método para obter a quantidade de hóspedes
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
    }
}