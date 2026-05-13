Console.WriteLine("Hello, World!");
Console.WriteLine("Funky nugget is cool.");

class Persoon
{
    public string naam = "Jasper";
    public int leeftijd = 18;
    public string geslacht ="M";
    public string nation = "NLD";
    public string job = "Student";

    public void Groet()
    {
        // Veranderd op basis van taal/nationaliteit
        
        if (nation = "NLD")
        {
            Console.WriteLine($"Gegroet, ik ben {naam}.");
        } else
        {
            Console.WriteLine($"Salutations, I'm {naam}.");
        }
    }

    // Andere methods hier
}