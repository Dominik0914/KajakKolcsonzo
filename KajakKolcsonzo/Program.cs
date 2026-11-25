using KajakKolcsonzo;
List<Kolcsonzes> jelen = new List<Kolcsonzes>();
foreach(string sor in File.ReadAllLines("kolcsonzesek.txt").Skip(1))
{
    jelen.Add(new Kolcsonzes(sor));
}