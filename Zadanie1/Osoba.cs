namespace Zadanie1;

public class Osoba
{
    private string imie;
    private string nazwisko;
    private DateTime? DataUrodzin { get; set; }
    private DateTime? DataSmierci { get; set; }

    public Osoba(string imieNazwisko)
    {
       ImieNazwisko = imieNazwisko;
    }

    public string Imie
    {
        get { return imie; }
        set
        {

            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                imie = value.Trim();
            }
            else
            {
                throw new ArgumentException("Imie nie może być puste!!!");
            }
        }

    }

    public string ImieNazwisko
    {
        get { return $"{imie} {nazwisko}"; }
        set
        {
            string[] personName = value.Split(' ');
            if (personName.Length == 2)
            {
                imie = personName[0];
                nazwisko = personName[1];
            }
            else if (personName.Length == 1)
            {
                imie = personName[0];
                nazwisko = String.Empty;
            }
            else
            {
                throw new ArgumentException("Podaj imię i nazwisko");
            }
        }
    }

    public TimeSpan? Wiek
    {
        get
        {
            if (DataUrodzin.HasValue )
            {            
                if(DataSmierci.HasValue)
                {
                    return DataSmierci.Value - DataUrodzin.Value;
                }
                else
                {
                    return DateTime.Now - DataUrodzin.Value;
                }
                
            }
            else
            {
                return null;
            }
        }
    }
}