using System;
using System.Collections.Generic;

int Finder(List<int> liste)
{
    int groessteZahl = 0;
    
    for (int i = 0; i < liste.Count; i++)
    {
        if (liste[i] > groessteZahl)
        {
            groessteZahl = liste[i];
        }
    }
    return groessteZahl;
}

List<int> input = new List<int>{3, 5, 7, 2, 8, 6};
int ergebnis = Finder(input);
Console.WriteLine(ergebnis);
