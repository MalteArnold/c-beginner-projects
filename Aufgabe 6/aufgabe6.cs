List<int> umkehrer(List<int> liste1)
{
    List<int> liste2 = new List<int>();
    int laenge = liste1.Count;
    
    for (int i = 1; i <= laenge; i++)
    {
        liste2.Add(liste1[laenge - i]);
    }
    return liste2;
}

List<int> input = new List<int>{1, 2, 3, 4, 5};
List<int> ergebnis = umkehrer(input);
Console.WriteLine(string.Join(", ", ergebnis));
