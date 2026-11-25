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
Console.WriteLine($"Kölcsönző teljes bevétele: {jelen.Sum(a=>a.FizetendoOsszeg())} Ft");
Console.WriteLine($"Összes bérelt óraszám: {jelen.Sum(a=>a.BereltOrak)} óra");
Console.WriteLine($"Átlagos kölcsönzési idő: {jelen.Average(a=>a.BereltOrak):f0} óra");
var leg = jelen.MaxBy(a => a.FizetendoOsszeg());
Console.WriteLine($"Legtöbbet fizető bérlő: {leg.BerlonNev} ({leg.FizetendoOsszeg()} Ft)");
Console.WriteLine($"Késés nélkül visszahozott KENU kölcsönzések száma: {jelen.Count(a=>a.HajoTipus=="KENU" && a.KesesPerc==0)} db");
Console.WriteLine("\nKésedelmi pótdíjat fizető bérlők:");
foreach (var pot in jelen)
{
    if (pot.KesesPerc>15)
    {
        Console.WriteLine($"{pot.BerlonNev} ({pot.KesesPerc} perc)");
    }
}