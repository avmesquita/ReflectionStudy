using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesCheckup
{
    public class Livro : ILivro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
