//Problema 3.7
//Biblioteca. Crear una clase Libro que contenga los siguientes atributos:
//▪ ISBN
//▪ Titulo
//▪ Autor
//▪ Número de páginas
//Crear sus respectivos métodos get y set correspondientes para cada atributo.
//Crear el método toString() para mostrar la información relativa al libro con el siguiente formato:
//“El libro con ISBN creado por el autor tiene páginas” 
//Crear una clase Adicional Biblioteca que permite modelar nuestro ordenamiento de libros.
//Agregar los siguientes comportamientos:
//▪ Un constructor con un parámetro, que permite definir el tamaño de la estantería (cantidad de libros).
//Validar que la cantidad sea mayor que cero.
//▪ Un método agregarLibro(unLibro) que permita agregar un libro a la biblioteca siempre que la estantería no se encuentre llena.
//▪ Un método mostrarListado() que permita retornar el estado de la biblioteca como una cadena: [Libro1 |Libro2 |Libro3… |]
using Problema_3._7;

Libro libro1 = new Libro(1, "PERRO", "IKER", 25);
Libro libro2 = new Libro(2, "PERRO1", "IKER", 20);
Biblioteca b1 = new Biblioteca(2);
b1.AgregarLibro(libro2);
b1.AgregarLibro(libro1);
Console.WriteLine(b1.MostrarListado());