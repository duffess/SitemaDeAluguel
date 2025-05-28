namespace ProjetoAluguelBicicletas.Models
{
    public class Administrador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool LoginSistema(string usuario, string senha)
        {
            return true;
        }

        public void GerenciarUsuarios()
        {
        }

        public void GerarRelatorios()
        {
        }
    }
}
