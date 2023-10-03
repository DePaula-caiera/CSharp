namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1
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

            Console.WriteLine("= = = APROVADOS = = =");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);

            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("= = = CHAMADA = = =");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("= = = APROVADOS (por Idade) = = =");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
