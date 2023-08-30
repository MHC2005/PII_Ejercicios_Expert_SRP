using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SRP
{
    public class Sector
    {
        public string nombre { get; set; }

        public int id { get; set; }

        public  List<Shelve> listaShelve { get; set; }

        public Sector(String nombre, int id){
            this.nombre=nombre;
            this.id=id;
        }
        public void AgregarEstante (Shelve Estante){
        this.listaShelve.Add(Estante);
        }

    }
}