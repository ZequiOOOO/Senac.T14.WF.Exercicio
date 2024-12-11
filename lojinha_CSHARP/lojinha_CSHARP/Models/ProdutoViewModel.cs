﻿namespace lojinha_CSHARP.Models
{
    public class ProdutoViewModel
    {
            public List<Produto> listaProduto { get; set; } = [];

            public List<string> erros { get; set; } = [];

            public bool ExisteErros => erros.Count > 0;
        }
}
