using System;
using System.IO;
using System.Linq;

namespace Challenge_355_Easy_Alphabet_Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = File.ReadAllLines("Input.txt");
            
            foreach (var item in x)
            {
                string Encryption = item.Substring(0, item.IndexOf(" "));
                string Code = item.Substring(item.IndexOf(" ") + 1);
                string Mess = "";
                string LongEncryption = "";

                for (int i = 0; i < Code.Count(); i++)
                {
                    LongEncryption += Encryption[i % Encryption.Count()];
                }

                for (int i = 0; i < LongEncryption.Length; i++)
                {
                    int Location = (LongEncryption[i] - 97) + Code[i];
                    if (Location > 122)
                        Location -= 26;
                    Mess += (char)Location;

                }
                //System.Console.WriteLine("Original Phrase : {0} \t Cypher : {1} \t Encrypted Message{2}", Code, Encryption, Mess);

                Console.WriteLine(Mess);
                
            }

            Console.ReadLine();
        }
    }
}
