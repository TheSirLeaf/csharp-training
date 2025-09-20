using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCommon
{
    public class LerArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivos(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                int quantidadeLinhas = linhas.Length;
                return (true, linhas, quantidadeLinhas);
            }
            catch (Exception ex)
            {
                return (false, new string[] { ex.Message }, 0);
            }
        }
    }
}