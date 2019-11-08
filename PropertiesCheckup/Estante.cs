using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesCheckup
{
    public class Estante : IEstante
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public IList<Livro> Livros { get; set; }

        public Estante()
        {
            this.Livros = new List<Livro>();
        }
    }
}
