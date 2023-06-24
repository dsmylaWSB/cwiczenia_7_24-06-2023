
int ileDzielnikowLiczbyPierwszej(int n)
{
    if (n <= 5)
        return 0;   //"Podanie n <= 5 powinno zakończyć funkcję wynikiem 0"

    int count = 0;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0 && czyLiczbaPierwsza(i))
            count++;
    }
    return count;
}

bool czyLiczbaPierwsza(int liczba)
{
    if (liczba < 2)
        return false;

    for (int i = 2; i <= Math.Sqrt(liczba); i++)
    {
        if (liczba % i == 0)
            return false;
    }

    return true;
}


Console.Write("Wprowadź liczbę całkowitą większą od 5: ");
int n = int.Parse(Console.ReadLine());

// if został przeze mnie wprowadzony wyłącznie dla czytelności obsługi programu w konsoli
// zupełnie nie jest tu konieczny i różni się tylko wyświetlanym komunikatem

if (n > 5)
{
    int ileDzielnikow = ileDzielnikowLiczbyPierwszej(n);
    Console.WriteLine($"\nLiczba dzielników pierwszych liczby {n}: {ileDzielnikow}");
}
else
{
    Console.WriteLine(ileDzielnikowLiczbyPierwszej(n)); //"Podanie n <= 5 powinno zakończyć funkcję wynikiem 0"
    Console.WriteLine("\nNieprawidłowa wartość");
}
