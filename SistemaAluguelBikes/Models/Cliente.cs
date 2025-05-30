using System.Collections.Generic;

namespace ProjetoAluguelBicicletas.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Aluguel> Alugueis { get; set; } = new List<Aluguel>();

        public void AdicionarAluguel(Aluguel aluguel)
        {
            Alugueis.Add(aluguel);
        }

        public override string ToString()
        {
            return Nome;  
        }
    }
}
