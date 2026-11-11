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

//Exercício 4 - Sistema de notificações
Console.WriteLine("\n===== 4. Notificações =====");
List<Notificacao> notificacoes = new List<Notificacao>
            {
                new Notificacao(),
                new NotificacaoEmail(),
                new NotificacaoSMS(),
                new NotificacaoPush()
            };
foreach (Notificacao n in notificacoes)
{
    n.Enviar();
}

//Exercício 5 - Sistema de entregas
Console.WriteLine("\n===== 5. Entregas =====");
List<Entrega> entregas = new List<Entrega>
            {
                new EntregaExpressa(100),
                new EntregaEconomica(100),
                new RetiradaLocal()
            };
foreach (Entrega e in entregas)
{
    Console.WriteLine($"{e.GetType().Name}: R$ {e.CalcularFrete():F2}");
}

//Exercício 6 - Sistema de exportação e impressão
Console.WriteLine("\n===== 6. Documentos =====");
Relatorio relatorio = new Relatorio();
Contrato contrato = new Contrato();
relatorio.Imprimir();
relatorio.Exportar();
contrato.Imprimir();