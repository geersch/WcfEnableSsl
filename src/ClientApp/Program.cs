using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using ClientApp.ServiceReference;

namespace ClientApp
{
    class Program
    {
        static void Main()
        {
            ServicePointManager.ServerCertificateValidationCallback += 
                CustomXertificateValidation;

            using (var proxy = new CustomerServiceClient())
            {
                var customers = proxy.GetCustomers();
                foreach(var customer in customers)
                {
                    Console.WriteLine(String.Format("{0} {1}", customer.FirstName, customer.LastName));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static bool CustomXertificateValidation(object sender, X509Certificate cert,
            X509Chain chain, SslPolicyErrors error)
        {
            var certificate = (X509Certificate2) cert;

            // Inspect the server certficiate here to validate 
            // that you are dealing with the correct server.
            // If so return true, if not return false.
            return true;
        }
    }
}
