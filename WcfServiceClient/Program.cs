using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient.ServiceReference1;
using WcfServiceClient.ServiceReference2;

namespace WcfServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation1Client client = new Operation1Client();
            Operation2Client client1 = new Operation2Client();
            double result = client.sumNumbersBetween(52, 56);
            Console.WriteLine("TESTY");
            Console.WriteLine("sumNumbersBetween = " + result);


            result = client.modulo(7, 3);
            Console.WriteLine("TESTY");
            Console.WriteLine("modulo = " + result);

            // Użyj zmiennej „client” do wywoływania operacji dla usługi.

            // Zawsze zamykaj klienta.
            
            

            String strRes = client1.concat("Pan", " Jan");
            Console.WriteLine("TESTY");
            Console.WriteLine("Concat = " + strRes);

            strRes = client1.reverse("Pan");
            Console.WriteLine("TESTY");
            Console.WriteLine("reverse = " + strRes);

            strRes = client1.multiplay("Pan", 3);
            Console.WriteLine("TESTY");
            Console.WriteLine("multiplay = " + strRes);

            client1.Close();
            client.Close();

        }
    }
}
