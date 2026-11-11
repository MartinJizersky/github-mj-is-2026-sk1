using System.ComponentModel.DataAnnotations;

string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a"){
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Ciferný součin ********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Martin Jizerský *******");
    Console.WriteLine("*******************************");

    // Načtení hodnoty
    Console.Write("Zadejte celé číslo:  ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)){
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu:  ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("====================================================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("====================================================");
    Console.WriteLine();
    Console.WriteLine();


   // Zde budeme pokračovat konkrétním algoritmem

    // Příprava pomocných proměnných pro výpočet
    int numberBackup = number;
    int sum = 1;    // U součinu je třeba začínat 1
    int digit;      // Proměnná pro uložení právě zjištěné číslice   

    // Ošetření záporných čísel (znaménko nemá vliv na číslice)
    if (number < 0){
        number = -number;
    }
    // Zvláštní případ pro nulu
    if (number == 0){
        sum = 0;
    } else {
        Console.WriteLine();     
        Console.WriteLine("Průběh rozkladu čísla na číslice (zprava)");

        // Matematický rozklad čísla pomocí cyklu
        // Modulo - určení zbytku po celočíselném dělení
        while (number != 0) {
            digit = number % 10;    // Modulo 10 - získáme poslední číslici
            sum = sum * digit;

            Console.WriteLine($"Získaná číslice: {digit}");

            number = number / 10;   // Celočíselné dělení 10 odstraní poslední číslici
        }    
    }

    // Výpis výsledku)
    Console.WriteLine();
    Console.WriteLine("====================================================");
    Console.WriteLine($"Součin čísla {numberBackup} je: {sum}");
    Console.WriteLine("====================================================");


    // Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter:  ");
    again = Console.ReadLine() ?? "";
}
