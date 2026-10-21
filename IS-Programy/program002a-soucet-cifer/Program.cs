using System.ComponentModel.DataAnnotations;

string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a"){
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("******* Název programu ********");
    Console.WriteLine("***************************");
    Console.WriteLine("***** Martin Jizerský *****");
    Console.WriteLine("***************************");

    // Načtení hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo):  ");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa)){
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
    Console.WriteLine($"První číslo: {aaa}, další číslo: {bbb}");
    Console.WriteLine("====================================================");
    Console.WriteLine();
    Console.WriteLine();


   // Zde budeme pokračovat konkrétním algoritmem

}
