using System;

namespace io_sdk_csharp_dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = (args != null && args.Length > 0) ? args[0] : null;

            string jsonString = Import.Process(connectionString);

            Console.WriteLine(jsonString);
        }
    }
}
