using System;
using System.Collections.Generic;

int Summe(List<int> liste)
{
    int summe = 0;
    
    for (int i = 0; i < liste.Count; i++)
    {
        if (liste[i] >= 0)
        {
            summe = summe + liste[i];
        }
    }
    return summe;
}

List<int> input = new List<int>{1, -2, 3, -4, 5 };
int ergebnis = Summe(input);
Console.WriteLine(ergebnis);
