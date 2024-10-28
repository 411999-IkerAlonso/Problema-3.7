using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._7
{
    public class Libro
    {
       public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int Paginas { get; set; }
        public Libro() 
        {
            ISBN = 0; 
            Titulo = string.Empty;
            Autor = string.Empty;
            Paginas = 0;
        }  

        public Libro(int isbn, string titulo, string autor, int paginas)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public override string ToString()
        {
            return $"El libro {Titulo} con ISBN {ISBN} creado por el autor {Autor} tiene {Paginas} páginas" ;
        }

    }
}
