using Dal.Model;

namespace Api.Repositorio
{
    public static class PessoaRepositorio
    {
        public static List<Pessoa> GetPessoas()
        {
            var lstPessoas = new List<Pessoa>();
            lstPessoas.Add(new Pessoa(1, "Marcos"));
            lstPessoas.Add(new Pessoa(2, "Carlos"));
            lstPessoas.Add(new Pessoa(3, "Ricardo"));
            lstPessoas.Add(new Pessoa(4, "Maria"));
            lstPessoas.Add(new Pessoa(5, "Keila"));

            return lstPessoas;
        }
    }
}
