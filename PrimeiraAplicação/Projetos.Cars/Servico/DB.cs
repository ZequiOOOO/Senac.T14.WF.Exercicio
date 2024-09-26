using MySql.Data.MySqlClient;
using Servico.model;
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
                var usuario = new CarrosTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString()!,
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
            _cmd.CommandText = "INSERT INTO usuario (Nome) VALUE (?nome)";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = carros.Nome;

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
            _cmd.CommandText = "UPDATE carros SET nome = ?nome WHERE id = (?id)";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = carros.Nome;
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = carros.Id;

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
            _cmd.CommandText = "SELECT * FROM carros WHERE id = ?id";
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
            _reader = _cmd.ExecuteReader();

            var carros = new CarrosTO();

            _reader.Read();
            carros.Id = int.Parse(_reader["id"].ToString()!);
            carros.Nome = _reader["nome"].ToString()!;

            _con.Close();

            return carros;
        }
        public void DeletarCarros(int id)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "DELETE FROM carros WHERE id = (?id)";
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
