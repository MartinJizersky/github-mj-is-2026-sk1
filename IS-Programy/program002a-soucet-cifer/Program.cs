using System.ComponentModel.DataAnnotations;

string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a"){
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Ciferný součet ********");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Martin Jizerský *******");
    Console.WriteLine("*******************************");

    // Načtení hodnoty
    Console.Write("Zadejte celé číslo:  ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number)){
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu:  ");
    }


    // Načtení druhé hodnoty
    Console.Write("Zadejte číslo řady (celé číslo):  ");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb)){
        Console.Write("Nezadali jste celé číslo. Zadejte druhé číslo znovu:  ");
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
    int sum = 0;    // Neutrální hodnota pro sčítání je 0
    int digit;      // Proměnná pro uložení právě zjištěné číslice   

}
