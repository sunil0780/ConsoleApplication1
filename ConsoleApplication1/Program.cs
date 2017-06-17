using System;
using System.Collections.Generic;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            var payload = new Dictionary<string, object>
            {
                { "claim1", 0 },
                { "claim2", "claim2-value" }
            };
            var secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

          var stp=  Identity.Identity.Encrypt_Token(payload, secret);
            Console.WriteLine(stp);
            var ppt = Identity.Identity.Decrypt_Token(stp, secret);
            Console.WriteLine(ppt);
            Console.ReadLine();
        }
    }
}
