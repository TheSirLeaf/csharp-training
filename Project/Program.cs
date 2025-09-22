using ProjectCommon;
using System;
using Newtonsoft.Json;













// int numero = 9;

// bool par = numero.EhPar();

// Console.WriteLine($"O número {numero} é {(par ? "par" : "ímpar")}");









// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.adicionarElementoArray(10);
// arrayInteiro.adicionarElementoArray(20);

// Console.WriteLine(arrayInteiro[0]);
// Console.WriteLine(arrayInteiro[1]);

// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.adicionarElementoArray("Hello");
// arrayString.adicionarElementoArray("World");

// Console.WriteLine(arrayString[0]);
// Console.WriteLine(arrayString[1]);








// string conteudoArquivo= File.ReadAllText("./Files/venda.json");
// List<Venda2>? vendas = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

// var listaAnonimo = vendas?.Select(x => new { x.Produto, x.Preco });

// foreach (var item in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {item.Produto}, Preço: {item.Preco}");
// }   













// var tipoAnonimo = new {Nome = "Patrick", Sobrenome = "Brito", Altura = 1.8, Idade = 30};

// Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
// Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
// Console.WriteLine($"Altura: {tipoAnonimo.Altura}");
// Console.WriteLine($"Idade: {tipoAnonimo.Idade}");
// Console.WriteLine($"Tipo: {tipoAnonimo.GetType()}");















// bool? desejaReceberEmail = null;

// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário deseja receber email.");
// }
// else if(desejaReceberEmail.HasValue && !desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário não deseja receber email.");
// }
// else
// {
//     Console.WriteLine("O usuário não informou sua preferência.");
// }












// string conteudoArquivo = File.ReadAllText("./Files/venda.json");
// try
// {
//     List<Venda2>? vendas = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

//     if (vendas != null)
//     {
//         foreach (Venda2 venda in vendas)
//         {
//             Console.WriteLine($"Id: {venda.Id}");
//             Console.WriteLine($"Produto: {venda.Produto}");
//             Console.WriteLine($"Preço: {venda.Preco}");
//             Console.WriteLine($"Data da Venda: {venda.DataVenda}");
//             Console.WriteLine($"Desconto: {(venda.Desconto.HasValue ? venda.Desconto.Value.ToString() + "%" : "N/A")}");
//             Console.WriteLine("---------------");
//         }
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
// }






// DateTime dataAtual = DateTime.Now;

// List<Venda> vendas = new List<Venda>();

// Venda v1 = new Venda(id: 1, produto: "Caneta", preco: 1.50m, dataVenda: dataAtual);
// Venda v2 = new Venda(id: 2, produto: "Lápis", preco: 0.80m, dataVenda: dataAtual);

// vendas.Add(v1);
// vendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// Console.WriteLine(serializado);

// File.WriteAllText("./Files/venda.json", serializado);












// LerArquivo lerArquivo = new LerArquivo();

// Console.WriteLine("Iniciando leitura do arquivo");
// Console.WriteLine("Escreva o caminho do arquivo");
// string caminho;
// while (string.IsNullOrWhiteSpace(caminho = Console.ReadLine()))
//     Console.WriteLine("Caminho inválido. Tente novamente:");

// var (sucesso, linhas, quantidadeLinhas) = lerArquivo.LerArquivos(caminho);
// if (sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }