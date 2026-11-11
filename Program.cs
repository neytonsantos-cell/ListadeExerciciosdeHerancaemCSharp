using ListadeExerciciosdeHerancaemCSharp;

//Exercício 1 - Sistema de veículos
Console.WriteLine("===== 1. Veículos =====");
Veiculo carro = new Carro("Toyota", "Corolla", 4);
Veiculo moto = new Motocicleta("Honda", "CB 500", 500);
Console.WriteLine("Informações do Carro:");
carro.ExibirInformacoes();
Console.WriteLine();
Console.WriteLine("Informações da Motocicleta:");
moto.ExibirInformacoes();

//Exercício 2 - Sistema de produtos digitais
Console.WriteLine("\n===== 2. Produtos digitais =====");
ProdutoDigital ebook = new Ebook("C# na Prática", 49.90m, 320);
ProdutoDigital curso = new CursoOnline("Curso de POO", 199.90m, 40);
Console.WriteLine("Informações do Ebook:");
ebook.ExibirDetalhes();
Console.WriteLine();
Console.WriteLine("Informações do Curso:");
curso.ExibirDetalhes();

//Exercício 3 - Sistema de jogos
Console.WriteLine("\n===== 3. Jogos =====");
Jogo digital = new JogoDigital("Hollow Knight", "PC", 9.5);
Jogo fisico = new JogoFisico("God of War", "PlayStation 5", "Blu-ray");
Console.WriteLine("Informações do Jogo Digital:");
digital.ExibirInformacoes();
Console.WriteLine();
Console.WriteLine("Informações do Jogo Físico:");
fisico.ExibirInformacoes();