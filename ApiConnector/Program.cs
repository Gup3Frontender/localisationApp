using System;

namespace ApiConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Run();
        }

        static void Run()
        {
            RequestSender RS = new RequestSender();

            Console.WriteLine("Gdzie jesteś?");
            string input = Console.ReadLine();

            Console.WriteLine("czego szukasz?");
            string type = Console.ReadLine();
            
            RS.FindNear(RS.GetLocalisationByName(input) ,type);

            Console.Read();
        }
    }
}
