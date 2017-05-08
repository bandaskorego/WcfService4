using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfServiceContract;

namespace WcfServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Krok 1 Utworz URI dla bazowego adresu serwisu.       
            Uri baseAddress = new Uri("http://localhost:10003/newHost1");
            // Krok 2 Utworz instancje serwisu.       
            ServiceHost mojHost = new ServiceHost(typeof(Operation1), baseAddress);
            try
            {
                // Krok 3 Dodaj endpoint. 
                WSHttpBinding mojBanding = new WSHttpBinding();
                mojHost.AddServiceEndpoint(typeof(IOperation1), mojBanding, "startEndPoint1");

                // Krok 4 Ustaw wymiane metadanych.        
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                mojHost.Description.Behaviors.Add(smb);

                // Krok 5 Uruchom serwis.   
                mojHost.Open();
                Console.WriteLine("Serwis jest uruchomiony.");
                Console.WriteLine("Nacisnij <ENTER> aby zakonczyc.");
                Console.WriteLine();
                Console.ReadLine();
                mojHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                mojHost.Abort();
            }
        }
    }
}
