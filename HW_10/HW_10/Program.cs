using System;

namespace HW_10
{
    class Program
    {
        static void Main(string[] args)
        {
            IdCode idCode = new IdCode("39710120252");
            idCode.PrintInfo();
        }

        class IdCode
        {
            public string idCode;
            public string gender;

            public IdCode(string code)
            {
                if (code.Length == 11)
                {
                    idCode = code;
                }
                else
                {
                    Console.WriteLine("Invalid id code! Id code has to be 11 digits long!");
                }
            }

            public void SetGender()
            {
                int genderNr = int.Parse(idCode[0].ToString());

                if (genderNr % 2 != 0 && genderNr < 6)
                {
                    gender = "male";
                }
                else if (genderNr % 2 == 0 && genderNr < 7)
                {
                    gender = "female";
                }
                else
                {
                    Console.WriteLine("Invalid first number");
                }
            }

            public void PrintInfo()
            {
                SetGender();
                Console.WriteLine("Id code is: {0} and gender is: {1}", idCode, gender);
            }
        }
    }
}
