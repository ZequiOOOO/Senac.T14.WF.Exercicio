using MySql.Data.MySqlClient;
using Servico.Model;
using Servico.Model;

namespace Servico
{
    public class DB
    {
        private readonly MySqlConnection _con;
        private MySqlCommand? _cmd;
        private MySqlDataReader? _reader;

        public DB()
        {
            _con = new MySqlConnection("Server=localhost;Port=3306;Database=lojaCliente;Uid=root;Pwd=;SslMode=none");
        }

        public List<ClientesTO> GetClientes()
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "SELECT * FROM clientes";
            _reader = _cmd.ExecuteReader();

            var listaCarros = new List<ClientesTO>();

            while (_reader.Read())
            {
                var carros = new clientesTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString()!,
                    Fabricante = _reader["Fabricante"].ToString()!,
                    Marca = _reader["Marca"].ToString()!,
                    Modelo = _reader["Modelo"].ToString()!,
                    Ano = int.Parse(_reader["Ano"].ToString()!),
                };
                listaCarros.Add(clientes);
            }
            _con.Close();
            return listaCarros;
        }
        public void AddCliente(ClientesTO clientes)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "INSERT INTO carro (nome, Modelo, Marca, Fabricante, Ano ) VALUE (?nome, ?Modelo, ?Marca, ?Fabricante, ?Ano) ";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = clientes.Nome;
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = clientes.Id;
            _cmd.Parameters.Add("?Modelo", MySqlDbType.VarChar).Value = clientes.Modelo;
            _cmd.Parameters.Add("?Marca", MySqlDbType.VarChar).Value = clientes.Marca;
            _cmd.Parameters.Add("?Fabricante", MySqlDbType.VarChar).Value = clientes.Fabricante;
            _cmd.Parameters.Add("?Ano", MySqlDbType.Int64).Value = clientes.Ano;

            if (_cmd.ExecuteNonQuery() >= 1)
            {
                //true
            }
            else
            {
                //false
            }
            _con.Close();
        }

        public void UpdateAlterarClientes(clientesTO clientes)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "UPDATE carro SET nome = ?nome, Modelo  =?modelo, Marca = ?Marca, Ano = ?Ano WHERE id = (?id) ";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = clientes.Nome;
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = clientes.Id;
            _cmd.Parameters.Add("?Modelo", MySqlDbType.VarChar).Value = clientes.Modelo;
            _cmd.Parameters.Add("?Marca", MySqlDbType.VarChar).Value = clientes.Marca;
            _cmd.Parameters.Add("?Fabricante", MySqlDbType.VarChar).Value = clientes.Fabricante;
            _cmd.Parameters.Add("?Ano", MySqlDbType.Int64).Value = clientes.Ano;

            if (_cmd.ExecuteNonQuery() >= 1)
            {
                //true
            }
            else
            {
                //false
            }
            _con.Close();
        }
        public clientesTO GetClientessById(int id)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "SELECT * FROM clientes WHERE id = ?id";
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
            _reader = _cmd.ExecuteReader();

            var clientess = new clientesTO();

            _reader.Read();
            clientes.Id = int.Parse(_reader["id"].ToString()!);
            clientes.Nome = _reader["nome"].ToString()!;
            clientes.Marca = _reader["Marca"].ToString()!;
            clientes.Modelo= _reader["Modelo"].ToString()!;
            clientes.Fabricante = _reader["fabricante"].ToString()!;
            c.Ano = int.Parse(_reader["ano"].ToString()!);

            _con.Close();

            return carros;
        }

       
       

    }
}
