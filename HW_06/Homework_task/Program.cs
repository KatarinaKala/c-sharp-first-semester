using System;

namespace Homework_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Regular regular = new Regular();
            //regular.DoIroning(regular.Irontemps = 300);
            /*regular.DoIroning(regular.Ironprograms = "cotton program");
            regular.DoIroning(regular.Ironprograms = "silk program");
            regular.DoIroning(regular.Ironprograms = "synthetics program");
            regular.DoIroning(regular.Ironprograms = "cotton program");
            regular.Descale();*/
            //regular.DoIroning(regular.Irontemps = 121);
            regular.UseSteam();
            regular.DoIroning(regular.Irontemps = 121);

        }

        interface IRegular
        {
            void Descale();
            void DoIroning(int temperature);
            void DoIroning(string programName);
            void UseSteam();
            /*void TurnOn();
            void TurnOff();*/
        }

        class Regular:IRegular
        {
            protected string type;
            protected int temperature = 0;
            protected string programName;
            protected int cleanCount = 0;
            protected bool useSteam;
            protected string program;

            public virtual string Ironprograms //property 
            { 
                get
                {
                    return program;
                } 
                set
                {
                    Random rnd = new Random();
                    if (value == "synthetics program")
                    {
                        temperature = rnd.Next(90, 120);
                    }
                    else if (value == "silk program")
                    {
                        temperature = rnd.Next(120, 150);
                    }
                    else if (value == "cotton program")
                    {
                        temperature = rnd.Next(150, 200);
                    }
                    else
                    {
                        Console.WriteLine("Invalid program!");
                    }
                }
            }

            public virtual int Irontemps //property 
            {
                get
                {
                    return temperature;
                }
                set
                {
                    if (value >= 90 && value < 120)
                    {
                        program = "synthetics program";
                    }
                    else if (value >= 120 && value < 150)
                    {
                        program = "silk program";
                    }
                    else if (value >= 150 && value < 200)
                    {
                        program = "cotton program";
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature!");
                    }
                }
            }

            public Regular() //added constructor
            {
                type = "Regular";
                useSteam = true;
            }

            public void DoIroning(int ironTemp)
            {
                if (useSteam == true)
                {
                    Console.WriteLine("Ironing with steam");
                    useSteam = false;
                }
                if (cleanCount < 3)
                {
                    temperature = ironTemp;
                    if (temperature < 200 && temperature > 0)
                    {
                        Console.WriteLine("{0} machine is ironing with {1}", type, program);
                        cleanCount++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid temperature for ironing!");
                    }
                }
                else
                {
                    Console.WriteLine("Machine has been used 3 times and needs cleaning!");
                }

            }

            public void DoIroning(string name)
            {
                if (cleanCount < 3)
                {
                    programName = name;
                    Console.WriteLine("{0} machine is ironing with {1} degrees", type, temperature);
                    cleanCount++;
                }
                else
                {
                    Console.WriteLine("Machine has been used 3 times and needs cleaning!");
                }
                if (useSteam == true)
                {
                    Console.WriteLine("Ironing with steam");
                    useSteam = false;
                }
            }

            public void Descale()
            {
                cleanCount = 0;
                Console.WriteLine("Machine is cleaned!");
            }

            public void UseSteam()
            {
                if (temperature >= 120)
                {
                    useSteam = true;
                }
                else
                {
                    useSteam = false;
                }
            }
        }

        class Linen:Regular
        {
            public Linen() //added property
            {
                type = "Linen";
                useSteam = true;
            }

    
        }
    }
}
