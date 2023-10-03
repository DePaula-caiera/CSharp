namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
               new Aluno() {Nome = "Pedro", Idade = 22, Nota = 8.0},
               new Aluno() {Nome = "André", Idade = 21, Nota = 4.0},
               new Aluno() {Nome = "Ana", Idade = 28, Nota = 9.5},
               new Aluno() {Nome = "Pelé", Idade = 17, Nota = 8.8},
               new Aluno() {Nome = "Ana", Idade = 25, Nota = 2.0},
               new Aluno() {Nome = "Julia", Idade = 29, Nota = 7.0},
               new Aluno() {Nome = "Rios", Idade = 22, Nota = 9.0}
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Mayke"));

            if(fulano == null)
            {
                Console.WriteLine("\nAluno Inexistente.\n");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));

            if (sicrano == null)
            {
                Console.WriteLine("\nAluno Inexistente.\n");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var nome in exemploSkip)
            {
                Console.WriteLine(nome.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatoriaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatoriaNotas);

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);

            //usando where
            //var mediaNotas = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            //Console.WriteLine(mediaNotas);
        }
    }
}
