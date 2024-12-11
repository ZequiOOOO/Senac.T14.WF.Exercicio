using MySql.Data.MySqlClient;
using servico.model;
using servico.Model;
using servico.models;
using System.Reflection.PortableExecutable;

namespace servico
{
    public class DB
    {
        private readonly MySqlConnection _con;
        private MySqlCommand? _cdm;
        private MySqlDataReader? _reader;

        public DB()
        {
            _con = new MySqlConnection("Server=127.0.0.1;Database=lojaclientes;Uid=root;Pwd=;SslMode=none");
        }

        public List<ProdutoTO> GetProdutos()
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "SELECT * FROM produto";
            _reader = _cdm.ExecuteReader();

            var listaProduto = new List<ProdutoTO>();

            while (_reader.Read())
            {
                var produto = new ProdutoTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString() ?? string.Empty,
                    Descricao = _reader["descricao"] as string,
                    Preco = _reader["preco"] != DBNull.Value ? Convert.ToDecimal(_reader["preco"]) : 0m,
                    Estoque = _reader["estoque"] != DBNull.Value ? Convert.ToInt32(_reader["estoque"]) : 0,
                    DataAdicionado = _reader["data_adicionado"] != DBNull.Value ? Convert.ToDateTime(_reader["data_adicionado"]) : DateTime.MinValue
                };

                listaProduto.Add(produto);
            }

            return listaProduto;

        }

        public void DeletarProduto(int id)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "DELETE FROM produto WHERE id = @id ";
            _cdm.Parameters.Add("@id", MySqlDbType.Int64, id);

        }
        public void InserirProduto(ProdutoTO produto)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;

            _cdm.CommandText = @"INSERT INTO Produto (nome, descricao, preco, estoque, data_adicionado) VALUES (@nome, @descricao, @preco, @estoque, @data_adicionado)";
            _cdm.Parameters.AddWithValue("@nome", produto.Nome);
            _cdm.Parameters.AddWithValue("@descricao", produto.Descricao ?? (object)DBNull.Value);
            _cdm.Parameters.AddWithValue("@preco", produto.Preco);
            _cdm.Parameters.AddWithValue("@estoque", produto.Estoque);
            _cdm.Parameters.AddWithValue("@data_adicionado", produto.DataAdicionado == DateTime.MinValue ? (object)DBNull.Value : produto.DataAdicionado);
            _cdm.ExecuteNonQuery();
        }

        public void UpdateProduto(ProdutoTO produto)
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.CommandText = "UPDATE Produto SET nome = ?nome, descricao = ?descricao, preco = ?preco, estoque = ?estoque, data_adicionado = ?data_adicionado WHERE id = ?id";
            _cdm.Parameters.Add("?id", MySqlDbType.Int32).Value = produto.Id;
            _cdm.Parameters.Add("?nome", MySqlDbType.VarChar).Value = produto.Nome;
            _cdm.Parameters.Add("?descricao", MySqlDbType.Text).Value = produto.Descricao;
            _cdm.Parameters.Add("?preco", MySqlDbType.Decimal).Value = produto.Preco;
            _cdm.Parameters.Add("?estoque", MySqlDbType.Int32).Value = produto.Estoque;
            _cdm.Parameters.Add("?data_adicionado", MySqlDbType.Timestamp).Value = produto.DataAdicionado;

            _cdm.ExecuteNonQuery();
            _con.Close();
        }

        public List<ClienteTO> GetClientes()
        {
            _con.Open();
            _cdm = new MySqlCommand();
            _cdm.Connection = _con;
            _cdm.CommandText = "SELECT * FROM cliente";
            _reader = _cdm.ExecuteReader();

            var listaCliente = new List<ClienteTO>();

            while (_reader.Read())
            {
                var cliente = new ClienteTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString() ?? string.Empty,
                    Sobrenome = _reader["sobrenome"].ToString() ?? string.Empty,
                    Email = _reader["email"].ToString() ?? string.Empty,
                    Telefone = _reader["telefone"]?.ToString(),
                    Endereco = _reader["endereco"]?.ToString(),
                    Cidade = _reader["cidade"]?.ToString(),
                    Estado = _reader["estado"]?.ToString(),
                    Cep = _reader["cep"]?.ToString(),
                    DataCadastro = _reader["data_cadastro"] != DBNull.Value
                              ? Convert.ToDateTime(_reader["data_cadastro"])
                              : DateTime.MinValue
                };

                listaCliente.Add(cliente);
            }

            return listaCliente;

        }
    }

}