using System.Runtime.Serialization;
using c__explore_concepts.Models;
using System.Globalization;

Queue<int> fila = new Queue<int>();

fila.Enqueue(3); // primeiro elemento
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(1); // ultimo elemento

fila.Dequeue(); // sempre irá remover o primeiro elemento

foreach (var fil in fila)
{
    Console.WriteLine(fil);
}























// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }    
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. A pasta não foi encontrada: {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"O diretório não foi encontrado: {ex.Message}");
// }
// catch (Exception ex) // ex é a variável que ele retornou, o tipo de exceção que irá guardar
// {
    
//     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("deu");
// }




















// string dataFormat = "2023-13-17 10:00";

// bool sucess = DateTime.TryParseExact(dataFormat, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture,  //culture none é um padrão 
//                         DateTimeStyles.None, out DateTime data); //datetime none também é um padrão

// // DateTime data = DateTime.Parse("20/12/2022 17:17");
// if(sucess){
//     Console.WriteLine($"Obtemos sucesso na nosso tipo DateTime convert: {data}");
// }
// else
// {
//     Console.WriteLine($"Não conseguimos converter, foi de {sucess} é o output foi {data}");
// }



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal ValorMonetario = 40002.42M;
// Console.WriteLine(ValorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(ValorMonetario.ToString("C1")); //tira o prefixo da moeda só devolve os numeros
// // ou também C1

// double Porcentagem = .3421;
// Console.WriteLine(Porcentagem.ToString("P"));

// int numero = 102030;
// Console.WriteLine(numero.ToString("##-##-##"));


// ApresentacaoFoots af1 = new ApresentacaoFoots("William", "AmigoDoUiU");
// af1.SelecionarCardapios();
// af1.NotaAvaliacao();












// Pessoa p1 = new Pessoa(nome: "William", sobrenome: "Vieira");
// Pessoa p2 = new Pessoa(nome: "Kuma", sobrenome: "Barto");
// Curso CursoDeIngles = new Curso();
// CursoDeIngles.Nome = "Inglês";
// CursoDeIngles.Alunos = new List<Pessoa>();
// //temos sempre que instanciar a listar quando tivermos um método lista<> na nossa classe usada

// CursoDeIngles.AdicionarAluno(p1);
// CursoDeIngles.AdicionarAluno(p2);
// CursoDeIngles.ListarAlunos();






// Pessoa p1 = new Pessoa();
// p1.Idade = 19;
// p1.Nome = "will";
// p1.Sobrenome = "vieira";
