using System;
using System.Collections.Generic;

namespace HW_10
{
    class Program
    {
        static void Main(string[] args)
        {
            IdCode idCode = new IdCode("49710120252");
            idCode.PrintInfo();
        }

        class IdCode
        {
            private string idCode;
            private int genderNr;
            private string gender;
            private string dayCheck;
            private string day;
            private string monthNr;
            private string month;
            private string yearCheck;
            private string year;
            private string placeCheck;
            private string place;
            private char nrOfBirths;
            private int lastNr;
            Dictionary<int, string> MonthDict = new Dictionary<int, string>()
            {
                {01, "January"},
                {02, "February"},
                {03, "March"},
                {04, "April"},
                {05, "May"},
                {06, "June"},
                {07, "July"},
                {08, "August"},
                {09, "September"},
                {10, "October"},
                {11, "November"},
                {12, "December"},
            };

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
                genderNr = int.Parse(idCode[0].ToString()); //making char into int

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

            public void Day()
            {
                dayCheck += idCode[5];
                dayCheck += idCode[6];

                int dayNr = int.Parse(dayCheck);

                if (dayNr > 0 && dayNr <= 31)
                {
                    day = dayCheck;
                }
                else
                {
                    Console.WriteLine("Invalid day for birthday! Day has to be between 1-31.");
                }
            }

            public void Month()
            {
                monthNr += idCode[3];
                monthNr += idCode[4];

                int monthNumber = int.Parse(monthNr);

                if (monthNumber > 0 && monthNumber <= 12)
                {
                    month = MonthDict[monthNumber];
                }
                else
                {
                    Console.WriteLine("Invalid month for birthday! Month has to be between 1-12");
                }
            }

            public void Year()
            {
                if (genderNr < 3)
                {
                    yearCheck += "18";
                }
                else if (genderNr > 2 && genderNr < 5)
                {
                    yearCheck += "19";
                }
                else
                {
                    yearCheck += "20";
                }
                yearCheck += idCode[1];
                yearCheck += idCode[2];

                int yearNr = int.Parse(yearCheck);

                if (yearNr >= 1800 && yearNr <= 2019)
                {
                    year = yearCheck;
                }
                else
                {
                    Console.WriteLine("Invalid year for birth! Year has to be between 1800-2019");
                }
            }

            public void Places()
            {
                nrOfBirths = idCode[9];

                for (int i = 7; i < 10; i++)
                {
                    placeCheck += idCode[i];
                }

                int placeNr = int.Parse(placeCheck);

                switch (placeNr)
                {
                    case int n when (n >= 001 && n <= 010):
                        place = "Kuressaare Haigla";
                        break;
                    case int n when (n >= 011 && n <= 019):
                        place = "Tartu Ülikooli Naistekliinik";
                        break;
                    case int n when (n >= 021 && n <= 220):
                        place = "Ida-Tallinna Keskhaigla";
                        break;
                    case int n when (n >= 221 && n <= 270):
                        place = "Ida-Viru Keskhaigla";
                        break;
                    case int n when (n >= 271 && n <= 370):
                        place = "Maarjamõisa Kliinikum";
                        break;
                    case int n when (n >= 371 && n <= 420):
                        place = "Narva haigla";
                        break;
                    case int n when (n >= 421 && n <= 470):
                        place = "Pärnu Haigla";
                        break;
                    case int n when (n >= 471 && n <= 490):
                        place = "Pelgulinna Sünnitusmaja";
                        break;
                    case int n when (n >= 491 && n <= 520):
                        place = "Järvamaa haigla";
                        break;
                    case int n when (n >= 521 && n <= 570):
                        place = "Rakvere Haigla";
                        break;
                    case int n when (n >= 571 && n <= 600):
                        place = "Valga Haigla";
                        break;
                    case int n when (n >= 601 && n <= 650):
                        place = "Viljandi Haigla";
                        break;
                    case int n when (n >= 651 && n <= 710):
                        place = "Lõuna-Eesti Haigla";
                        break;
                    default:
                        place = "Unknown place";
                        break;
                }
            }

            public void CheckNr()
            {
                int checkNr = 0;
                int makeToInt = int.Parse(idCode[10].ToString());

                for (int i = 0; i < idCode.Length - 1; i++)
                {
                    int check = int.Parse(idCode[i].ToString()); //making id code chars to integers

                    if (i == 9)
                    {
                        checkNr += check;
                    }
                    else
                    {
                        checkNr += (check * (i + 1));
                    }
                }

                if (checkNr % 11 == 10 && makeToInt == 0)
                {
                    lastNr = 0;
                }
                else if (checkNr % 11 == makeToInt)
                {
                    lastNr = checkNr % 11;
                }
                else
                {
                    Console.WriteLine("Invalid last number!");
                }
            }

            public void PrintInfo()
            {
                SetGender();
                Day();
                Month();
                Year();
                Places();
                CheckNr();
                Console.WriteLine("Id code is: {0} \nGender is: {1} \nBirthday is: {2}.{3}.{4} " +
                    "\nPlace is: {5} \nNr of births: {6} \nCheck number: {7}",
                    idCode, gender, day, month, year, place, nrOfBirths, lastNr);
            }
        }
    }
}
