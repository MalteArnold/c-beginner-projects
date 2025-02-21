/*
Übung 2: Maximale Zahl in einer Liste
Aufgabe: Schreibe eine Funktion, die die größte Zahl aus einer Liste von Ganzzahlen findet und zurückgibt.

Hinweise:

Verwende eine Schleife, um jede Zahl zu überprüfen und die größte Zahl zu speichern.
Denke daran, wie du mit der ersten Zahl beginnen und die größte Zahl in der Liste ermitteln kannst.
Beispiel:

Eingabe: {3, 5, 7, 2, 8, 6}
Ausgabe: 8
*/

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