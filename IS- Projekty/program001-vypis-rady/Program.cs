﻿using System;

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

            // Vstup od uživatel - špatná varianta
             //Console.Write("Zadejte první číslo řady: ");
             //int first = int.Parse(Console.ReadLine());
            
            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte první číslo řady (celé číslo): ")
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo):");

            }

            Console.Write("Zadejte polední číslo řady (celé číslo): ")
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady (celé číslo):");

            }

            Console.Write("Zadejte diference (celé číslo): ")
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu diference (celé číslo):");

            }

            // Výpis uživatelského vstupu
            Console.WriteLine();
            Console.WriteLine("=============================");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0}", last);
            Console.WriteLine("Diference: {0}", step);
            Console.WriteLine();
            Console.WriteLine();
            

            // Logika pro výpis řady - TO-DO


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }


    }


}