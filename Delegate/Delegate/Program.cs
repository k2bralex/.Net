using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate.View;
using Delegate;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Academy View = new Academy();
            //View.Run();

            //Team newTeam = new Team();
            //newTeam.Run();

            Publish p = new Publish();

            p.Show();

            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }
    }
}
