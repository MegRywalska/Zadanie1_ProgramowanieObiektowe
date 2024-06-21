namespace Zadanie1;

public class Osoba
{
    private string _imie;
    public string Nazwisko { get; set; }
    public DateTime? DataUrodzin { get; set; } = null;
    public DateTime? DataSmierci { get; set; } = null;

    public Osoba(string imieNazwisko)
    {
       ImieNazwisko = imieNazwisko;
    }

    public string Imie
    {
        get { return _imie; }
        set
        {

            if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
            {
                _imie = value.Trim();
            }
            else
            {
                throw new ArgumentException("Imie nie może być puste!!!");
            }
        }

    }

    public string ImieNazwisko
    {
        get { return $"{_imie} {Nazwisko}"; }
        set
        {
            string[] personName = value.Split(' ');
            if (personName.Length == 2)
            {
                _imie = personName[0];
                Nazwisko = personName[1];
            }
            else if (personName.Length == 1)
            {
                _imie = personName[0];
                Nazwisko = String.Empty;
            }
            else
            {
                throw new ArgumentException("Podaj imię i nazwisko!");
            }
        }
    }

    public TimeSpan? Wiek
    {
        get
        {
            if (!DataUrodzin.HasValue)
            {
                return null;
            }

            DateTime dataObecnaLubSmierci = DataSmierci ?? DateTime.Now;

            return dataObecnaLubSmierci - DataUrodzin.Value;

        }
    }
}