
class Program
{
    static void Main(string[] args)
    {
        Notatka notatka1 = new Notatka("Notatka 1", "Treść notatki 1");
        Notatka notatka2 = new Notatka("Notatka 2", "Treść notatki 2");

        notatka1.Wyswietl();
        notatka2.Wyswietl();

        notatka1.Diagnostyka(); ;
        notatka2.Diagnostyka(); ;

        Console.ReadKey();
    }
}

public class Notatka
{
    private static uint LicznikNotatek = 0;
    private uint identyfikator;
    private string tytul;
    private string tresc;

    public Notatka(string tytul, string tresc)
         
    {
        LicznikNotatek++;
        identyfikator = LicznikNotatek;
        this.tytul = tytul;
        this.tresc = tresc;
    }

    public void Wyswietl()
    {
        Console.WriteLine($"Tytuł: {tytul}");
        Console.WriteLine($"Treść: {tresc}");
    }

    public void Diagnostyka()
    {
        Console.WriteLine($"Identyfikator: {identyfikator}; Tytuł: {tytul}; Treść: {tresc}");
    }

}