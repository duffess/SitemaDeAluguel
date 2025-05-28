using System;

namespace ProjetoAluguelBicicletas.Models
{
    public class Recibo
    {
        public int IdRecibo { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal Valor { get; set; }
        public Aluguel Aluguel { get; set; }
        public Devolucao Devolucao { get; set; }

        public static Recibo GerarRecibo(Aluguel aluguel, Devolucao devolucao = null)
        {
            return new Recibo
            {
                IdRecibo = new Random().Next(1000, 9999),
                DataEmissao = DateTime.Now,
                Aluguel = aluguel,
                Devolucao = devolucao,
                Valor = devolucao != null ? 100 + devolucao.Multa : 100
            };
        }
    }
}
