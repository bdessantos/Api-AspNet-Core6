using Dal.Model;

namespace Api.Repositorio
{
    public static class UsuarioRepositorio
    {
        public static Usuario? Get(string Nome, string Senha)
        {
            var lstUsuario = new List<Usuario>();
            lstUsuario.Add(new Usuario(1, "Bruno", "123456"));

            return lstUsuario.Where(x => x.Nome.ToLower() == Nome.ToLower() && x.Senha == x.Senha).FirstOrDefault();
        }
    }
}
