using System;
using System.Collections.Generic;

namespace CarNumbers
{
    class Program
    {

    }

    class RegistrationNr
    {
        public List<string> codes = new List<string>();
        Random random = new Random();

        public string CreateNumbers(string letters)
        {
            string generatedCode = "";

            if (letters.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    generatedCode += random.Next(0, 10);
                }
                generatedCode += letters;
            }

            return generatedCode;
        }

        public List<string> CreateCodes(string letters)
        {
            for (int i = 0; i < 4; i++)
            {
                codes.Add(CreateNumbers(letters));
            }

            return codes;
        }
    }
}
