using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_III
{
    internal class Admin : Usuario
    {
        public Admin(int id, string nome, string email, string senha)
        : base(id, nome, email, senha)
        {
        }

        public void gerenciarAcesso()
        {
            Console.WriteLine("Gerenciando acesso...");
        }
    }
}
