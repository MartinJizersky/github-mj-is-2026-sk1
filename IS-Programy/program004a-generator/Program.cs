using System.ComponentModel.DataAnnotations;

string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a"){
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("******* Generátor pseudonáhodných čísel ********");
    Console.WriteLine("************************************************");
    Console.WriteLine("**************** Martin Jizerský ***************");
    Console.WriteLine("************************************************");

    // Počet generovaných čísel
    Console.Write("Zadejte počet generovaných čísel (přirozené číslo):  ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0){
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet znovu:   ");
    }


    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo):  ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound)){
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu:  ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno dolní meze):  ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound){
        Console.Write("Nezadali jste celé číslo větší nebo rovno dolní meze. Zadejte horní mez znovu:  ");
    }

    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("====================================================");
    Console.WriteLine($"Počet čísel: {n}, Dolní mez: {lowerBound}, Horní mez: {upperBound}");
    Console.WriteLine("====================================================");
    Console.WriteLine();
    Console.WriteLine();


   // Zde budeme pokračovat konkrétním algoritmem

    // Deklarace a alokace pole v paměti
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru náhodných čísel
    Random myRandNumb = new  Random();      // Jiná proměnná
    //Random myRandNumb = new  Random(50);

    // Generování náhodných čísel a jejich uložení do pole
    int positive = 0;
    int negative = 0;
    int zero = 0;
    int even = 0;
    int odd = 0;

    Console.WriteLine("Vygenerováná pseudonáhodná čísla:  ");
    for (int i = 0; i < myRandNumbs.Length; i++) {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1); 
        Console.Write($"{myRandNumbs[i]}; ");

        if(myRandNumbs[i] < 0)
            negative++;
        else if(myRandNumbs[i] > 0)
            positive++;
        else
            zero++;

        // Sudá nebo lichá čísla
        if(myRandNumbs[i] % 2 == 0)
            even++;
        else    
            odd++;
    }

    Console.WriteLine("");
    Console.WriteLine("=======================================");
    Console.WriteLine($"Počet kladných čísel: {positive}");
    Console.WriteLine($"Počet záporných čísel: {negative}");
    Console.WriteLine($"Počet nul: {zero}");
    Console.WriteLine($"Počet sudých čísel: {even}");
    Console.WriteLine($"Počet lichých čísel: {odd}");
    Console.WriteLine("=======================================");


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine("");
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter:  ");
    again = Console.ReadLine() ?? "";

}