using MySql.Data.MySqlClient;
using Servico.model;

namespace Servico
{
    public class Db
    {
        private readonly MySqlConnection _con;
        private MySqlCommand? _cmd;
        private MySqlDataReader? _reader;

        public Db()
        {
            _con = new MySqlConnection("Server=127.0.0.1;Database=teste;Uid=root;Pwd=;SslMode=none");
        }

        public List<UsuarioTO> GetUsuarios()
        {
           _con.Open();
           _cmd = new MySqlCommand();
           _cmd.Connection = _con;
           _cmd.CommandText = "SELECT * FROM usuario";
           _reader = _cmd.ExecuteReader();

            var listaUsuario = new List<UsuarioTO>();

            while (_reader.Read()){
                var usuario = new UsuarioTO()
                {
                    Id = int.Parse(_reader["id"].ToString()!),
                    Nome = _reader["nome"].ToString()!,
                };
                listaUsuario.Add(usuario);
            }
            _con.Close();
            return listaUsuario;
        }
         public void AddUsuario(UsuarioTO usuario)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "INSERT INTO usuario (Nome) VALUE (?nome)";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = usuario.Nome;

            if(_cmd.ExecuteNonQuery() >= 1)
            { 
                //true
            }
            else 
            {
                //false
            }
            _con.Close();
        }

        public void UpdateAlterarUsuario(UsuarioTO usuario)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "UPDATE usuario SET nome = ?nome WHERE id = (?id)";
            _cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value=usuario.Nome;
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = usuario.Id;

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
        public UsuarioTO GetUsuarioById(int id)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "SELECT * FROM usuario WHERE id = ?id";
            _cmd.Parameters.Add("?id", MySqlDbType.Int64).Value = id;
            _reader = _cmd.ExecuteReader();

            var usuario = new UsuarioTO();

            _reader.Read();
            usuario.Id = int.Parse(_reader["id"].ToString()!);
            usuario.Nome = _reader["nome"].ToString()!;

            _con.Close();

            return usuario;
        }
        public void DeletarUsuario(int id)
        {
            _con.Open();
            _cmd = new MySqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandText = "DELETE FROM usuario WHERE id = (?id)";
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
    