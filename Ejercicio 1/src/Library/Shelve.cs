using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace SRP
{
    public class Shelve{

        public string codigo { get; set; }

        public List<Book> listaLibros { get; set;}

        public Shelve(string codigo){
            this.codigo = codigo;
        }
        public void AgregarLibro (Book Libro){
            this.listaLibros.Add(Libro);
            listaLibros = new List<Book>();
        }
        }

    }


