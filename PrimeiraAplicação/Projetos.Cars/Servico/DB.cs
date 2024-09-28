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
            _con = new MySqlConnection("Server=127.0.0.1;Database=carro;Uid=root;Pwd=;SslMode=none");
        }

        public List<CarrosTO> GetCarros()
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "SELECT * FROM carro";
            _reader = _cmd.ExecuteReader();

            var listaCarros = new List<CarrosTO>();

            while (_reader.Read())
            {
                var carros = new CarrosTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString()!,
                    Fabricante = _reader["Fabricante"].ToString()!,
                    Marca = _reader["Marca"].ToString()!,
                    Modelo = _reader["Modelo"].ToString()!,
                    Ano = int.Parse(_reader["Ano"].ToString()!),
                };
                listaCarros.Add(carros);
            }
            _con.Close();
            return listaCarros;
        }
        public void AddCarros(CarrosTO carros)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "INSERT INTO carro (nome, Modelo, Marca, Fabricante, Ano ) VALUE (?nome, ?Modelo, ?Marca, ?Fabricante, ?Ano) ";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = carros.Nome;
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = carros.Id;
            _cmd.Parameters.Add("?Modelo", MySqlDbType.VarChar).Value = carros.Modelo;
            _cmd.Parameters.Add("?Marca", MySqlDbType.VarChar).Value = carros.Marca;
            _cmd.Parameters.Add("?Fabricante", MySqlDbType.VarChar).Value = carros.Fabricante;
            _cmd.Parameters.Add("?Ano", MySqlDbType.Int64).Value = carros.Ano;

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

        public void UpdateAlterarCarros(CarrosTO carros)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "UPDATE carro SET nome = ?nome, Modelo  =?modelo, Marca = ?Marca, Ano = ?Ano WHERE id = (?id) ";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = carros.Nome;
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = carros.Id;
            _cmd.Parameters.Add("?Modelo", MySqlDbType.VarChar).Value = carros.Modelo;
            _cmd.Parameters.Add("?Marca", MySqlDbType.VarChar).Value = carros.Marca;
            _cmd.Parameters.Add("?Fabricante", MySqlDbType.VarChar).Value = carros.Fabricante;
            _cmd.Parameters.Add("?Ano", MySqlDbType.Int64).Value = carros.Ano;

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
        public CarrosTO GetCarrosById(int id)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "SELECT * FROM carro WHERE id = ?id";
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
            _reader = _cmd.ExecuteReader();

            var carros = new CarrosTO();

            _reader.Read();
            carros.Id = int.Parse(_reader["id"].ToString()!);
            carros.Nome = _reader["nome"].ToString()!;
            carros.Marca = _reader["Marca"].ToString()!;
            carros.Modelo= _reader["Modelo"].ToString()!;
            carros.Fabricante = _reader["fabricante"].ToString()!;
            carros.Ano = int.Parse(_reader["ano"].ToString()!);

            _con.Close();

            return carros;
        }

       
        public void DeletarCarros(int id)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "DELETE FROM carro WHERE id = (?id)";
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;


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

    }
}
