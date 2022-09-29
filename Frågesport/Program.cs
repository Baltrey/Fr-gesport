Console.WriteLine("Hej, Välkommen till min frågesport, jag kommer fråga 6 frågor och du ska få så många poäng som möjligt!!!");
Thread.Sleep(500);
Console.WriteLine("Vad är ditt namn?");
string namn = Console.ReadLine();
Thread.Sleep(500);
Console.WriteLine($"Hej {namn}");
while (true)
{
    int points = 0;
    Console.WriteLine("okej första frågan");
    Thread.Sleep(500);
    Console.WriteLine("Är bananer radioaktiva?");
    Console.WriteLine("1 Ja");
    Console.WriteLine("2 nej");
    Console.WriteLine("3 Bananer existerar inte");
    string svar = Console.ReadLine();
    if (svar == "1")
    {
        points++;
        Console.WriteLine($"Bra gjort du svarade rätt och har nu {points} poäng");
        Thread.Sleep(500);
    }
    else
    {
        Thread.Sleep(500);
    }
    Console.WriteLine("okej andra frågan");
    Thread.Sleep(500);
    Console.WriteLine("Är det soligt idag");
    Console.WriteLine("1 Ja");
    Console.WriteLine("2 nej");
    Console.WriteLine("3 Hur ska jag veta det????!!!");
    svar = Console.ReadLine();
    if (svar == "1" || svar == "2" || svar == "3")
    {
        points++;
        Console.WriteLine($"Bra gjort du svarade rätt och har nu {points} poäng");
        Thread.Sleep(500);
    }
    else
    {
        Thread.Sleep(500);
    }
    Console.WriteLine("okej tredje frågan");
    Thread.Sleep(500);
    Console.WriteLine("Vad väger mest 1kg fjädrar eller 11kg sten");
    Console.WriteLine("1 fjädrar");
    Console.WriteLine("2 sten");
    Console.WriteLine("3 De väger lika mycket");
    svar = Console.ReadLine();
    if (svar == "2")
    {
        points++;
        Console.WriteLine($"Bra gjort du svarade rätt och har nu {points} poäng");
        Thread.Sleep(500);
    }
    else
    {
        Thread.Sleep(500);
    }
    Console.Clear();
    if (points > 2)
    {
        Console.WriteLine("Bra!!! du fick alla rätt");
    }
    if (points == 2)
    {
        Console.WriteLine("Du fick inte alla rätt men det var nära!!!");
    }
    else
    {
        Console.WriteLine("Det där gick inte så bra hoppas det går bättre nästa gång:)");
    }
    Console.WriteLine("Vill du köra igen? [Y or N]");

    bool toContinue = false;
    bool invalidResponse = true;

    while (invalidResponse)
    {
        // få svar
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
            toContinue = true;
            invalidResponse = false;
        }
        else if (answer == "N")
        {
            invalidResponse = false;
        }
    }

    if (toContinue != true) return;
}

