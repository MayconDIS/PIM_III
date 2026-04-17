using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_III
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public void Login()
        {
            Console.WriteLine("Usuário logado com sucesso!");
        }
    }
}
