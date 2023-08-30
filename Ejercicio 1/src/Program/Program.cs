using System;
using System.Collections.Generic;
namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Sector sector1 = new Sector("Poesia",1);
            Sector sector2 = new Sector("Programación",1);
            Shelve shelve1 = new Shelve("1");
            Shelve shelve2 = new Shelve("2");
            Shelve shelve3 = new Shelve("3");
            Shelve shelve4 = new Shelve("4");
            sector1.AgregarEstante(shelve1);
            sector1.AgregarEstante(shelve2);
            shelve1.AgregarLibro(book1);
        }
    }
}