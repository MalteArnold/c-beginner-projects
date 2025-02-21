List<int> fibonacci(int zahl)
{
    int zaehler1 = 0;
    int zaehler2 = 1;
    List<int> liste = new List<int>();
    
    liste.Add(zaehler1);
    liste.Add(zaehler2);
    
    for (int i = 0; i < (zahl - 2); i++)
    {
        int summe = zaehler1 + zaehler2;
        liste.Add(summe);
        zaehler1 = zaehler2;
        zaehler2 = summe;
    }
    return liste;
}

int input = 5;
List<int> liste = fibonacci(input);
Console.WriteLine(string.Join(", ", liste));
