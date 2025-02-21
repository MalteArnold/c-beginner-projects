string Wochentag(int zahl)
{
    List<string> tage = new List<string>{"Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"};
    
    string tag = tage[zahl - 1];
    
    return tag;
}

int input = 5;
string tag = Wochentag(input);
Console.WriteLine(tag);
