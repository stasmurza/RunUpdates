using System;

namespace InstallUpdates
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                GetAndInstallUpdates getAndInstallUpdates = new GetAndInstallUpdates(args);
                getAndInstallUpdates.Start();               
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.ReadLine();
                throw;
            }
        }

    }
}
