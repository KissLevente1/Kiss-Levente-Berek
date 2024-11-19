using Kiss_Levente_Berek;

//27 perc

List<Dolgozo> dolgozok = new List<Dolgozo>();
StreamReader sr = new StreamReader(@"..\..\..\src\berek2020.txt");
sr.ReadLine();
while (!sr.EndOfStream)
{
    dolgozok.Add(new Dolgozo(sr.ReadLine()));
}
sr.Close();

Console.WriteLine("3. feladat:");
Console.WriteLine($"{dolgozok.Count} dolgozó adata szerepel a forrásban.");

Console.WriteLine("\n4. feladat: ");
var atlagBer2020 = dolgozok.Average(d => d.Ber);
Console.WriteLine($"2020-as átlagbér: {Math.Round(atlagBer2020/1000,1)}");

Console.WriteLine("\n5. feladat:");
Console.Write("Részleg neve: ");
string reszlegInput = Console.ReadLine();
var legtobbFizetes = dolgozok.OrderByDescending(d => d.Ber).First();
Console.WriteLine($"Legnagyobb bérrel remdelkező dolgozó adatai: {legtobbFizetes.Nev} {legtobbFizetes.Nem} {legtobbFizetes.Reszleg} {legtobbFizetes.BelepesEv} {legtobbFizetes.Ber}");

Console.WriteLine("\n6. feladat: ");
var reszlegek = dolgozok.GroupBy(d=>d.Reszleg).Select(g => new { Reszleg = g.Key, DolgozoSzam = g.Count() }).ToList();
Console.WriteLine("Statisztika: ");
foreach (var item in reszlegek)
{
    Console.WriteLine($"{item.Reszleg} {item.DolgozoSzam}");
}
