namespace Zadanie1;

public class Osoba
{
    private string _imie;
    private string _nazwisko;
    private DateTime DataUrodzin;
    private DateTime DataSmierci;
    private string imieNazwisko;
    private int wiek;

    public Osoba(string imieNazwisko)
    {
        this.imieNazwisko = imieNazwisko;
    }

    public string Imie
    {
        get { return _imie; }
        set { }

    }

    public string ImieNazwisko
    {
        get { return null;}
        set{ }
    }

    public int Wiek
    {
        get { return wiek; }
    }
}