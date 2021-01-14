using System;
namespace ROT_13
{
    public class Decrypt
    {
        // Properties
        private string key;
        private string encMessage;

        // Constructors
        //public Decrypt() {}
        public Decrypt(string key, string encMessage)
        {
            this.key = key;
            this.encMessage = encMessage;
        }

        // Methods
        public void SetKey(string key)
        {
            this.key = key;
        }
        public void SetEncMessage(string encMessage)
        {
            this.encMessage = encMessage;
        }

        // Decryption method
        public string DecryptedMessage()
        {
            // Define return variable
            string decryptedMessage;
            // Alphabet array to draw from
            char[] alphabet = new char[] { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' };
            
            // Redefine variables
            int tempKey = Convert.ToInt32(key);
            string tempMessage = encMessage.ToLower();

            // Create temp char array for the user input message
            char[] encMessageArray = encMessage.ToCharArray();
            char[] decMessageArray = new char[encMessageArray.Length];

            // Decryption process
            for (int i = 0; i < encMessageArray.Length; i++)
            {
                char encMessageLetter = encMessageArray[i];
                char decLetter = encMessageArray[i];

                // define new letter
                char newLetter;

                // if-else catch to maintain certain characters in the decrypted message
                if (encMessageLetter != ' ' && encMessageLetter != '.' && encMessageLetter != ',' && encMessageLetter != '\'')
                {
                    int letterPosition = Array.IndexOf(alphabet, decLetter);
                    int newLetterPosition = (letterPosition + tempKey) % 26;
                    newLetter = alphabet[newLetterPosition];
                }
                else
                {
                    newLetter = encMessageLetter;
                }
                decMessageArray[i] = newLetter;
            }
            // Join the decrypted message array together to form the return string
            decryptedMessage = String.Join("", decMessageArray);

            return decryptedMessage;
        }
    }
}