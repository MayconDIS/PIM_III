using System;
using System.Collections.Generic;
using System.Text;

namespace PIM_III
{
    internal class Tutor : Usuario
    {
        public Tutor(int id, string nome, string email, string senha)
        : base(id,nome,email,senha)
        {
        }

        public void acompnaharDesempenho()
        {
            Console.WriteLine("Acompnhando desempenho...");
        }

        public void gerenciarConteudo()
        {
            Console.WriteLine("Gerenciando conteudo...");
        }
    }
}
