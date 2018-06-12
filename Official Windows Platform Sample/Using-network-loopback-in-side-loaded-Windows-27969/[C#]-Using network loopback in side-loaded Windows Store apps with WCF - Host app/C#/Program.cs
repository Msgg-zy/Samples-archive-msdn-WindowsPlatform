using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.ServiceModel.Description;

namespace WcfServiceHost
{

    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("net.tcp://localhost:8888/");

            // Create the ServiceHost.
            using (var host = CreateServiceHost<BooksService, IBooksService>(new Uri(baseAddress, "BooksService")))
            using (var host2 = CreateServiceHost<NorthwindService, INorthwindService>(new Uri(baseAddress, "NWindService")))
            {

                // Open the ServiceHost to start listening for messages. 
                host.Open();
                Console.WriteLine("The service is ready at {0}", host.BaseAddresses.First());
                host2.Open();
                Console.WriteLine("The service is ready at {0}", host2.BaseAddresses.First());

                Console.WriteLine("Press <Enter> to stop the services.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
                host2.Close();
            }

        }

        public static ServiceHost CreateServiceHost<ST, CT>(Uri baseAddress)
        {
            var host = new ServiceHost(typeof(ST), baseAddress);

            //configure service metadata behavior
            var smb = host.Description.Behaviors.Find<ServiceMetadataBehavior>() ?? new ServiceMetadataBehavior();
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            host.Description.Behaviors.Add(smb);

            //add metadata exchange endpoint
            host.AddServiceEndpoint(
                ServiceMetadataBehavior.MexContractName,
                MetadataExchangeBindings.CreateMexTcpBinding(),
                "mex");

            //add service endpoint
            host.AddServiceEndpoint(
                typeof(CT),
                new NetTcpBinding(SecurityMode.None),
                string.Empty);

            return host;
        }
    }
}
