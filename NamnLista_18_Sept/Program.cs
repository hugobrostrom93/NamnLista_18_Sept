// Deklarera namnlista

List<string> NamnLista = new();
NamnLista.Add("Robin"); // Lägger till namn i listan för att slippa göra det varje gång
NamnLista.AddRange(new string[] // Eller så kan man använda en array om man vill för att mata in
{
    "Batman", "Batwoman", "Catwoman", "Alfred", "Nightwing"
});

while (true) // skapar en evig loop
{
    Console.WriteLine("+----------------+");
    Console.WriteLine("|    NamnLista   |");
    Console.WriteLine("+----------------+");
    Console.WriteLine("1 - Lägg till namn");
    Console.WriteLine("2 - Hitta namn");
    Console.WriteLine("3 - Ta bort namn");
    Console.WriteLine("4 - Visa alla namn");
    Console.WriteLine("5 - Avsluta");

    // Loop som upprepar sig tills man matat in en siffra
    int choice = 0; // användarens val av funktion
    while (true) // En evig loop // Så länge chioce = 0 så körs loopen nedan
    {
        string input = Console.ReadLine(); // Väljer menyval

        // Vi frågar TryParse om den kan omvandla texten till en siffra
        // TryParse returnerar true om talet (input) går att göra til len siffra
        // TryParse returnerar false om input är trams
        // Om TryParse kan omvanldas till en siffra lägger den värdet i variabeln
        if (int.TryParse(input, out choice))
        {
            // Om användaren väljer en siffra mellan 1 och 2 
            // hoppa ut ur den eviga loopen
            if (choice > 0 && choice < 6) break;
        }
        Console.WriteLine("Felaktig input");
    }

    if (choice == 1)
    {
        Console.Write("Ange ett namn: ");
        string newName = Console.ReadLine();
        if (newName != "") NamnLista.Add(newName);
        Console.WriteLine($"{newName} har nu lagts till i din lista");
    }

    else if (choice == 2)
    {
        Console.WriteLine("Vad söker du? ");
        string find = Console.ReadLine().ToLower(); // Ta input och omvandla till lower case
        List<string> found = new();
        for (int i = 0; i < NamnLista.Count; i++) // Kör en loop från 0 till antallet träffar den har hittat
        {
            // Hämtar ett värde från listan
            string current = NamnLista[i];
            if (current.ToLower().Contains(find)) found.Add(current); // .Contains kollar om något du skrivit in (find) finns i din namnlista (current) och lägger sedan till den i found listan??
        }

        Console.WriteLine("Här är de namn som matchar listan:");
        // Skriver ut hela listan
        for (int i = 0; i < found.Count; i++)
        {
            Console.WriteLine(found[i]);
        }
    }

    else if (choice == 3) // Användare valde 3
    {
        // Skriv kod här för att söka upp ett namn och radera det
        Console.WriteLine("Vilket namn vill du radera?");
        string val = Console.ReadLine();
        for (int i = 0; i < NamnLista.Count; i++) 
            if (val == NamnLista[i]) NamnLista.Remove(val);
        Console.WriteLine($"{val} har nu tagits bort från listan!");
    }

    else if (choice == 4)
    {
        // Skriv kod som skriver ut hela namnlistan 
        Console.WriteLine("Här är hela listan:");
        for (int i = 0; i < NamnLista.Count; i++)
        {
            Console.WriteLine(NamnLista[i]);
        }

    }
    else if (choice == 5)
    {
        // Hoppa ut ur den eviga loopen och därmed avsluta programmet
        break;
    }

    // Gör en linje för att skilja på vad man gjort och huvudmenyn
    Console.WriteLine();
    Console.WriteLine("-------------------------------------------------------------------");
    Console.WriteLine();
}

