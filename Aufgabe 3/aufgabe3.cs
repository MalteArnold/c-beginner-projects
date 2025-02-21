int zaehler(List<int> liste)
{
    int gerade = 0;
    
    for (int i = 0; i < liste.Count; i++)
    {
        if (liste[i] % 2 == 0)
        {
            gerade++;
        }
    }
    return gerade;
}

List<int> input = new List<int>{1, 2, 3, 4, 5, 6};
int ergebnis = zaehler(input);
Console.WriteLine(ergebnis);
