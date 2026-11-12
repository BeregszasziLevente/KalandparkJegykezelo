using KalandparkJegykezelo;
using System.IO;

List<Jegyvasarlas> jegyek = new List<Jegyvasarlas>();

foreach (var sor in File.ReadAllLines("jegyek.txt"))
{
    Jegyvasarlas peldany = new Jegyvasarlas(sor);
    jegyek.Add(peldany);
}