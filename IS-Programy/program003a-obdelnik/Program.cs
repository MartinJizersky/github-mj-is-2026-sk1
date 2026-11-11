using System.ComponentModel.DataAnnotations;

string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a"){
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("******* Vykreslování obdelníku ********");
    Console.WriteLine("***************************************");
    Console.WriteLine("*********** Martin Jizerský ***********");
    Console.WriteLine("***************************************");

    // Načtení hodnoty
    Console.Write("Zadejte šířku obrazce (celé kladné číslo):   ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte šířku znovu:  ");
        Console.ResetColor();
    }


    // Načtení druhé hodnoty
    Console.Write("Zadejte výšku obrazce (celé kladné číslo):   ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte výšku znovu:  ");
        Console.ResetColor();
    }



    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("====================================================");
    Console.WriteLine($"Šířka: {width}, výška: {height}");
    Console.WriteLine("====================================================");
    Console.WriteLine();
    Console.WriteLine();


   // Zde budeme pokračovat konkrétním algoritmem

    // Jádro vykreslovacího algoritmu
    // Vnější cyklus, který nám bude hlídat počet řádků
    for (int i = 1; i <= height; i++){
        Console.WriteLine(" ");
    }




    // Dotaz směrem k uživateli na opakování

    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter:  ");
    again = Console.ReadLine() ?? "";

}