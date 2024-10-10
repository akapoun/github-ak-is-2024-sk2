using System;

class Program {

    static void Main() {

        // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("********* Výpis řady ********");
            Console.WriteLine("*****************************");
            Console.WriteLine("******* Antonín Kapoun ******");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine();

            // Vstup od uživatel - TO-DO

            // Logika pro výpis řady - TO-DO


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }


    }


}