using KalandparkJegykezelo;
using System.IO;

List<Jegyvasarlas> jegyek = new List<Jegyvasarlas>();
Console.WriteLine("Napi jegyvásárlások:");
foreach (var sor in File.ReadAllLines("jegyek.txt"))
{
    Jegyvasarlas peldany = new Jegyvasarlas(sor);
    jegyek.Add(peldany);
    Console.WriteLine(peldany);
}
Console.WriteLine("\nStatisztika:");
Console.WriteLine($"Kalandpark teljes napi bevétele: {jegyek.Sum(x=>x.FizetendoOsszeg())} Ft");
Console.WriteLine($"Legtöbbet fizető látogató: {jegyek.MaxBy(x => x.FizetendoOsszeg()).LatogatoNev} ({jegyek.Max(x=>x.FizetendoOsszeg())} Ft)");