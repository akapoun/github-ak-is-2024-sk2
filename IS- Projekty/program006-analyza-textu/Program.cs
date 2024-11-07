 // chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("********* Analýza textu *********");
            Console.WriteLine("*********************************");
            Console.WriteLine("********* Antonín Kapoun ********");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine();
            
            Console.WriteLine("Zadejte text pro analýzu: ");
            string myText = Console.ReadLine();

            string samohlasky = "aeiouyáéíóúůýAEIOUYÁÉÍÓÚŮÝ";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";

            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in myText) {
                if(souhlasky.Contains(znak)) {
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)) {
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(znak)) {
                    pocetCislic++;
                }
                else
                    pocetOstatnich++;

            }

            Console.WriteLine("\n\nPočet souhlásek: {0}", pocetSouhlasek);
            Console.WriteLine("Počet samohlásek: {0}", pocetSamohlasek);
            Console.WriteLine("Počet číslic: {0}", pocetCislic);
            Console.WriteLine("Počet ostatních znaků: {0}", pocetOstatnich);


            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
