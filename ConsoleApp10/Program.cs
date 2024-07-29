using System.Security.Cryptography;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class2 p1 = new Class2();
            p1._tckimlikno = "12345678912";

            Console.WriteLine("tc kimlik numaraniz : " + p1._tckimlikno);

        }
    }
}
