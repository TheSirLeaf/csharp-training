using ProjectCommon;
using System;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("./Files/venda.json");
try
{
    List<Venda2>? vendas = JsonConvert.DeserializeObject<List<Venda2>>(conteudoArquivo);

    if (vendas != null)
    {
        foreach (Venda2 venda in vendas)
        {
            Console.WriteLine($"Id: {venda.Id}");
            Console.WriteLine($"Produto: {venda.Produto}");
            Console.WriteLine($"Preço: {venda.Preco}");
            Console.WriteLine($"Data da Venda: {venda.DataVenda}");
            Console.WriteLine("---------------");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
}






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