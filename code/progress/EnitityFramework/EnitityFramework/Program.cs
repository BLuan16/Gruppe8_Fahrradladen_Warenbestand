using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnitityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            FahrradladenEntities1 context = new FahrradladenEntities1();

            DbSet<ProduktKategorie> kategorien= context.ProduktKategorie;

            foreach (var item in kategorien)
            {
                Console.WriteLine(item.Bezeichnung);
            }

            Console.ReadLine();
        }
    }
}
