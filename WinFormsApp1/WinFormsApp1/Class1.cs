using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class User

    {

        [Key]
        public int id {get; set;}

        public string Nome {get; set;}

        public string Email {get; set;}

        public string Senha {get; set;}
        
    }
}
