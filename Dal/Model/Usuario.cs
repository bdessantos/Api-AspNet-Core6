using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario(int id, string nome, string senha)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
        }
    }
}
