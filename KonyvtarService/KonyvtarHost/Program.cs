using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using KonyvtarService;

namespace KonyvtarHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(KonyvtarService.Service1)))
            {
                host.Open();
                Console.WriteLine("Host has started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
