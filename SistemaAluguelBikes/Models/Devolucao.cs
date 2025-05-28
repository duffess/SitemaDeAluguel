using System;

namespace ProjetoAluguelBicicletas.Models
{
    public class Devolucao
    {
        public int IdDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Aluguel Aluguel { get; set; }
        public decimal Multa { get; set; }

        public void RegistrarDevolucao(Aluguel aluguel, DateTime dataDevolucao, decimal multa)
        {
            Aluguel = aluguel;
            DataDevolucao = dataDevolucao;
            Multa = multa;

            foreach (var bike in aluguel.Bicicletas)
                bike.MarcarComoDisponivel();
        }
    }
}
