using System;
using System.Collections.Generic;

namespace ProjetoAluguelBicicletas.Models
{
    public class Aluguel
    {
        public int IdAluguel { get; set; }
        public DateTime DataInicio { get; set; }
        public Cliente Cliente { get; set; }
        public List<Bicicleta> Bicicletas { get; set; } = new List<Bicicleta>();

        public void RegistrarAluguel(Cliente cliente, List<Bicicleta> bicicletas, DateTime dataInicio)
        {
            Cliente = cliente;
            Bicicletas = bicicletas;
            DataInicio = dataInicio;

            foreach (var bike in bicicletas)
                bike.MarcarComoAlugada();

            cliente.AdicionarAluguel(this);
        }
    }
}
