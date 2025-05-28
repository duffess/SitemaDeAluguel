namespace ProjetoAluguelBicicletas.Models
{
    public class Bicicleta
    {
        public int IdBicicleta { get; set; }
        public string Modelo { get; set; }
        public string Status { get; set; } = "Disponível";

        public bool IsDisponivel() => Status == "Disponível";

        public void MarcarComoAlugada() => Status = "Alugada";

        public void MarcarComoDisponivel() => Status = "Disponível";
    }
}
