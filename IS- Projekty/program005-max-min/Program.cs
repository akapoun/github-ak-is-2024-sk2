﻿string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("********* Generátor pseudonáhodných čísel ********");
            Console.WriteLine("**************************************************");
            Console.WriteLine("***************** Antonín Kapoun *****************");
            Console.WriteLine("**********************************************\n\n");
            Console.WriteLine();
            
            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
            Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo):");

            }
            
            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo):");

            }

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo):");

            }

            Console.WriteLine("\n\n==========================");
            Console.WriteLine("Uživatelský vstup: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("============================\n\n");

            // deklarace pole
            int[] myArray = new int[n];
            
            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");

            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);
            }         

            int max = myArray[0];
            int min = myArray[0];
            int posMax = 0;
            int posMin = 0;

            for(int i=1; i < n; i++) {
                if(myArray[i] > max) {
                    max = myArray[i];
                    posMax = i;
                }

                if(myArray[i] < min) {
                    min = myArray[i];
                    posMin = i;
                }

            }

            Console.WriteLine("\n\nMaximum = {0}", max);
            Console.WriteLine("Minimum = {0}\n\n", min);

            Console.WriteLine("Maximum je na pozici {0}", posMax);
            Console.WriteLine("Minimum je na pozici {0}", posMin);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }