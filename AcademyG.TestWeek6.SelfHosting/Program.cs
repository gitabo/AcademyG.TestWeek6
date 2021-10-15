using AcademyG.TestWeek6.WCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.TestWeek6.SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(GestioneOrdiniService)))
            {
                host.Open();

                Console.WriteLine("=== GestioneOrdini WCF Running ===");
                Console.WriteLine("Press any key to end ...");
                Console.ReadKey();
            }
        }
    }
}
