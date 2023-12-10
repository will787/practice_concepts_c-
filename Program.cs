using System.Runtime.Serialization;
using c__explore_concepts.Models;





Pessoa p1 = new Pessoa();
p1.Nome = "will";
p1.Sobrenome = "vieira";

Pessoa p2 = new Pessoa();
p2.Nome = "Kuma";
p2.Sobrenome = "Barto";

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Inglês";
CursoDeIngles.Alunos = new List<Pessoa>();
//temos sempre que instanciar a listar quando tivermos um método lista<> na nossa classe usada

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();






// Pessoa p1 = new Pessoa();
// p1.Idade = 19;
// p1.Nome = "will";
// p1.Sobrenome = "vieira";
