/*
Übung 1: Summe der positiven Zahlen in einer Liste
Aufgabe: Schreibe eine Funktion, die eine Liste von Ganzzahlen nimmt und nur die positiven Zahlen addiert. Am Ende soll die Funktion die Summe der positiven Zahlen zurückgeben.

Hinweise:

Du kannst die ArrayList oder List<int> verwenden.
Verwende eine Schleife und eine Bedingung, um sicherzustellen, dass nur positive Zahlen summiert werden.
Beispiel:

Eingabe: {1, -2, 3, -4, 5}
Ausgabe: 9 (Summe der positiven Zahlen)
*/

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