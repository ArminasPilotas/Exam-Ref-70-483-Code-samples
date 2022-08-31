using System;

namespace DebugApplicationsAndImplementSecurity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SymmetricEncryption.EncryptSomeText("hello");
            Console.ReadKey();
        }
    }
}
