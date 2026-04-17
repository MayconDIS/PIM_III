using System;
using System.Collections.Generic;

namespace PIM_III
{
    internal class Aluno : Usuario
    {
        public Simulado Simulado { get; set; }
        public Desempenho Desempenho { get; set; }
        public XP XP { get; set; }
        public Moedas Moedas { get; set; }
        public Acessibilidade Acessibilidade { get; set; }
        public List<Duvidas> Duvidas { get; set; }

        public Aluno(int id, string nome, string email, string senha)
            : base(id, nome, email, senha)
        {
            Duvidas = new List<Duvidas>();
        }

        public void EstudarFlashCard()
        {
            Console.WriteLine("Estudando com Flashcard...");
        }

        public void RealizarSimulado()
        {
            Console.WriteLine("Fazendo simulado...");
        }

        public void VisualizarProgresso()
        {
            Console.WriteLine("Visualizando progresso...");
        }
    }
}