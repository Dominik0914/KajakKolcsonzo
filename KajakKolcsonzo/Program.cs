using KajakKolcsonzo;
List<Kolcsonzes> jelen = new List<Kolcsonzes>();
foreach(string sor in File.ReadAllLines("kolcsonzesek.txt").Skip(1))
{
    jelen.Add(new Kolcsonzes(sor));
}
Console.WriteLine("Adatok beolvasása a kolcsonzesek.txt fájlból...");
Console.WriteLine("\nRögzített hajókölcsönzések:");
foreach(var szov in jelen)
{
    Console.WriteLine(szov);
}
Console.WriteLine("\nÖsszesített statisztika:");