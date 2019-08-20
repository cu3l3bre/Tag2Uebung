using System;


namespace Tag2Uebung
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Uebung Tag2: Spielereien mit String YOLO");
            Console.WriteLine();

            // string ist ein Keyword bzw alias für System.String
            // nen anderen Unterschied gibts scheinbar nicht
            // das gleiche gilt auch für diverse andere Datentypen


            String myString = "Hallo";

            //Console.WriteLine("Bitte geben Sie einen Text ein:");
            //myString = Console.ReadLine();


            Console.WriteLine(myString);
            Console.WriteLine("Länge des Strings ist " + myString.Length);

            for(int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + myString[i]);
            }


            myString = myString.Replace("Ha", "Lol");
            Console.WriteLine("Replaced "+ myString);

            myString = myString.Substring(0, 3);
            Console.WriteLine("Teil des strings " + myString);

            myString = myString.ToUpper();
            Console.WriteLine("In GROSS " + myString);

            myString = myString.ToLower();
            Console.WriteLine("In klein " + myString);

            Console.WriteLine("Unicode " + (int) myString[0]);
            Console.WriteLine("Unicode " + (int) myString[1]);
            Console.WriteLine("Unicode " + (int) myString[2]);
            //Console.WriteLine((int) myString[3]);

            myString = myString.Insert(3, "..."); // wird vor dem index eingefuegt
                                                  // lol = 0,1,2, ist der dritte index \0?
            Console.WriteLine("Was inserted " + myString);

            //myString = myString.Trim('l','.');  // lösche von links und rechts
            myString = myString.Trim('l');

            Console.WriteLine("Trimmen mit 'l': " + myString);

            Console.ReadKey();

        }
    }
}
