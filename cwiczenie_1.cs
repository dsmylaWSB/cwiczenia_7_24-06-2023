// pierwszy sposób - działa dla przypadków >24h
string FormatujCzas(int sekundy)
{
    int godziny = sekundy / 3600;
    int minuty = (sekundy % 3600) / 60;
    int pozostaleSekundy = sekundy % 60;

    string formatowanyCzas = $"{godziny:D2}:{minuty:D2}:{pozostaleSekundy:D2}";

    return formatowanyCzas;
}

//drugi sposób - zeruje licznik po 24h
void formatuj(int sekundy)
{
    TimeSpan time = TimeSpan.FromSeconds(sekundy);
    string str = time.ToString(@"hh\:mm\:ss");
    Console.WriteLine(str);
}




int czasWsekundach = int.Parse(Console.ReadLine());
string sformatowanyCzas = FormatujCzas(czasWsekundach);
Console.WriteLine(sformatowanyCzas);

Console.WriteLine("\n");
formatuj(czasWsekundach);

