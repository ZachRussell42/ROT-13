using System;
namespace ROT_13
{
    public class Encrypt
    {
        // Properties
        private string key;
        private string message;

        // Constructors
        //public Encrypt() {}
        public Encrypt(string key, string message)
        {
            this.key = key;
            this.message = message;
        }

        // Methods
        public void SetKey(string key)
        {
            this.key = key;
        }
        public void SetMessage(string message)
        {
            this.message = message;
        }

        // Encryption method
        public string EncryptedMessage()
        {
            // Define return variable
            string encryptedMessage;
            // alphabet array to draw from
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            // Redefine variables
            int tempKey = Convert.ToInt32(key);
            string tempMessage = message.ToLower();

            // Create temp char array for the user input message
            char[] messageArray = message.ToCharArray();
            char[] encMessageArray = new char[messageArray.Length];

            // Encryption process
            for (int i = 0; i < messageArray.Length; i++)
            {
                char messageLetter = messageArray[i];
                char encLetter = messageArray[i];

                // define new letter
                char newLetter;
                
                // if-else catch to maintain certain characters in the encrypted message
                if (messageLetter != ' ' && messageLetter != '.' && messageLetter != ',' && messageLetter != '\'')
                {
                    int letterPosition = Array.IndexOf(alphabet, messageLetter);
                    int newLetterPosition = (letterPosition + tempKey) % 26;
                    newLetter = alphabet[newLetterPosition];
                }
                else
                {
                    newLetter = messageLetter;
                }

                encMessageArray[i] = newLetter;
            }
            // Join the encrypted message array together to form the return string
            encryptedMessage = String.Join("", encMessageArray);

            // Return message
            return encryptedMessage;
        }
    }
}