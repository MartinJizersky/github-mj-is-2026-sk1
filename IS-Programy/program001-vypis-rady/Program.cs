string again = "a";

// Řidící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A" 
// Jakýkoli jiný vstup program ukončí
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("******* Výpis řady ********");
    Console.WriteLine("***************************");
    Console.WriteLine("***** Martin Jizerský *****");
    Console.WriteLine("***************************");



    // Dotaz směrem k uživateli na opakování
    Console.WriteLine("");
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter:  ");
    again = Console.ReadLine() ?? "";
}
