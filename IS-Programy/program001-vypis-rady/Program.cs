string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a"){
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("******* Výpis řady ********");
    Console.WriteLine("***************************");
    Console.WriteLine("***** Martin Jizerský *****");
    Console.WriteLine("***************************");

    // Načtení počáteční hodnoty
    Console.Write("Zadejte první číslo řady (celé číslo):  ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first)){
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:  ");
    }

    // Vstup počáteční hodnoty - špatně řešený
    // Console.Write("Zadejte první číslo řady: ");
    // int first = int.Parse(Console.ReadLine());

    // Načtení koncové hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo):  ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last)){
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu:  ");
    }

    // Načtení diference s kontrolou kladného nenulového čísla
    Console.Write("Zadejte diferenci (kladné celé číslo):  ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || (step <= 0)){
        Console.Write("Nezadali jste kladné celé číslo. Zadejte diferenci znovu:  ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("====================================================");
    Console.WriteLine($"První číslo: {first}, poslední číslo: {last}, diference: {step}");
    Console.WriteLine("====================================================");
    Console.WriteLine();
    Console.WriteLine();


    // Výpis řady
    Console.WriteLine("===== Výpis řady =====");
    if(first <= last){
        int current = first;
        while(current <= last){
            Console.WriteLine(current);
            current += step;
        }
    } else {
        Console.WriteLine("První číslo je větší než poslední.");
        Console.WriteLine("Tento program musí vypsat vzestupnou řadu (od menšího k většímu).");
    }


    // Dotaz směrem k uživateli na opakování

    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter:  ");
    again = Console.ReadLine() ?? "";

}
