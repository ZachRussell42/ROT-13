using System;

namespace ROT_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main executable
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Input '1' to encypt a message, '2' to decrypt a message, or '3' to exit:");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Input message you would like to enrypt:");
                    string inputMessage = Console.ReadLine();
                    Console.WriteLine("Input a number for the key:");
                    string inputKey = Console.ReadLine();
                    Encrypt firstEnc = new Encrypt(inputKey, inputMessage);

                    string encMessage = firstEnc.EncryptedMessage();
                    Console.WriteLine($"The encrypted message is: '{encMessage}'\nPress 'enter' to continue:");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Input message you would like to decrypt:");
                    string inputMessage = Console.ReadLine();
                    Console.WriteLine("Input the key number:");
                    string inputKey = Console.ReadLine();
                    Decrypt firstDec = new Decrypt(inputKey, inputMessage);
                    
                    string decMessage = firstDec.DecryptedMessage();
                    Console.WriteLine($"The decrypted message is: '{decMessage}'\nPress 'enter' to continue:");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input, press 'enter' to try again:");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
