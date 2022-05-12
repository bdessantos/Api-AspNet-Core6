namespace Api.AuthJWTBearer
{


    public class UsuarioAutenticao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Funcao { get; set; }
        public string? Chave { get; set; }

        public UsuarioAutenticao(int id, string nome, string senha, string funcao)
        {
            Id = id;
            Senha = senha;
            Nome = nome;
            Funcao = funcao;
        }
    }
}
