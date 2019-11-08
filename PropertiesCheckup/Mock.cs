using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesCheckup
{
    public class Mock
    {
        public IEstante GenerateModel()
        {
            var obj = new Estante();
            obj.Id = 1;
            obj.Nome = "Estante 1";            
            obj.Livros.Add(new Livro() { Id = 1, Nome = "Livro 1" });
            obj.Livros.Add(new Livro() { Id = 2, Nome = "Livro 2" });
            obj.Livros.Add(new Livro() { Id = 3, Nome = "Livro 3" });

            return obj;        
        }

    }
}
