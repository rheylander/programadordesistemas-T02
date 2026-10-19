using System;

namespace MatrizesWinFormsAssentos
{
    internal static class MapaCsv
    {
        internal static bool TryParse(string[] arquivo, out int[,] estados, out string erro)
        {
            estados = null;
            erro = "Arquivo inválido. Use dimensões de 2 a 30 e estados 0, 1 ou 2.";
            if (arquivo == null || arquivo.Length == 0 || arquivo[0] == null)
                return false;

            string[] header = arquivo[0].Split(';');
            int linhas, colunas;
            if (header.Length != 2 ||
                !int.TryParse(header[0], out linhas) ||
                !int.TryParse(header[1], out colunas) ||
                linhas < 2 || linhas > 30 || colunas < 2 || colunas > 30)
                return false;

            if (arquivo.Length != linhas + 1)
            {
                erro = "Arquivo inválido: quantidade de linhas diferente do cabeçalho.";
                return false;
            }

            int[,] novoMapa = new int[linhas, colunas];
            for (int r = 0; r < linhas; r++)
            {
                if (arquivo[r + 1] == null) return false;
                string[] partes = arquivo[r + 1].Split(';');
                if (partes.Length != colunas)
                {
                    erro = "Arquivo inválido: quantidade de colunas na linha " + (r + 2) + ".";
                    return false;
                }

                for (int c = 0; c < colunas; c++)
                {
                    int valor;
                    if (!int.TryParse(partes[c], out valor) || valor < 0 || valor > 2)
                    {
                        erro = "Valor inválido em [" + r + "," + c + "]. Use 0, 1 ou 2.";
                        return false;
                    }
                    novoMapa[r, c] = valor;
                }
            }

            estados = novoMapa;
            erro = null;
            return true;
        }
    }
}

