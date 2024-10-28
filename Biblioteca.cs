using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3._7
{
    public class Biblioteca
    {
        Libro[] estanteria;
        int ultimo;
        public Biblioteca(int tamanio)
        {
            if (tamanio > 0)
            {
                estanteria = new Libro[tamanio];
            }
            else if(tamanio<= 0)
            {
                throw new ArgumentException("El tamaño de la estantería debe ser mayor que cero");
            }
            ultimo = 0;

        }
        public void AgregarLibro(Libro libro)
        {
            if (ultimo < estanteria.Length)
            {
                estanteria[ultimo] = libro;
                ultimo++;
            }
            else Console.WriteLine("La estanteria esta llena y no pueden agregarse mas libros");
        }

        public string MostrarListado()
        {
            string listado = "";
            foreach(Libro libro in estanteria)
            {
                if(libro != null)
                {
                    listado += libro.ToString() + " | ";
                }
            }
            return listado;
        }

    }
}
