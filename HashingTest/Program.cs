using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HashingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string salt = "nFyC?7I$F6x{​​​​​​​ZJ75u^T~F(e)/*eF(c&lt;Kcu6|3F;62FvG+tIjOnGMk&gt;_[i9=^rN&lt";

            byte[] bytes = Encoding.UTF8.GetBytes(
                "fulano" + "-" + "ciclano" + "-" + "1900/01/12" + "-" + "0586403" + salt);
            
            var crypt = new SHA256Managed();
            var computedHash = crypt.ComputeHash(bytes);

            var hash = string.Empty;

            hash = computedHash.Aggregate(hash, (result, hashByte) => result + hashByte.ToString("x2"));

            Console.WriteLine(hash);
        }
    }
}
