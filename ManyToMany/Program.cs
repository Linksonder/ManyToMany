using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ManyToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();

            //Test Data:
            //context.Modules.Add(new Module{Naam = "Module 1"});
            //context.Docenten.Add(new Docent { Naam = "Docent 1" });
            //context.SaveChanges();

            var module = context.Modules.Include(m => m.Docenten).First();
            var docent = context.Docenten.Include(d => d.Modules).First();

            //test scenario
            module.Docenten.Add(docent);

            //Save changes
            context.Modules.Attach(module);
            context.SaveChanges();


            module = context.Modules.Include(m => m.Docenten).First();
            docent = context.Docenten.Include(d => d.Modules).First();

            Console.WriteLine(module.Naam + ":" + module.Docenten.Count() + " docenten");
            Console.WriteLine(docent.Naam + ":" + docent.Modules.Count() + " modules");

            Console.ReadLine();

        }
    }
}
