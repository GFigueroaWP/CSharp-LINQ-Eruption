List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
Console.WriteLine("La primera erupcion de Chile:");
Eruption firstEruptionChile = eruptions.First(c => c.Location == "Chile");
Console.WriteLine(firstEruptionChile);

Console.WriteLine("La primera erupcion de hawaii:");
Eruption firstEruptionHawaii = eruptions.First(c => c.Location == "Hawaiian Is");
if (firstEruptionHawaii != null)
{
    Console.WriteLine(firstEruptionHawaii);
}
else
{
    Console.WriteLine("No se encontró ninguna erupción en Hawaiian Is.");
}

Console.WriteLine("La primera erupcion de despues de 1900 en nueva zelanda:");
Eruption firstEruptionNewZealand = eruptions.First(c => c.Location == "New Zealand" && c.Year > 1900);
Console.WriteLine(firstEruptionNewZealand);

IEnumerable<Eruption> highElevationEruptions = eruptions.Where(c => c.ElevationInMeters > 2000);
PrintEach(highElevationEruptions, "Erupciones con elevación superior a 2000m:");

IEnumerable<Eruption> eruptionsStartingWithL = eruptions.Where(c => c.Volcano.StartsWith("L"));
PrintEach(eruptionsStartingWithL, "Erupciones con nombre de volcán que comienza con 'L':");
Console.WriteLine($"Número de erupciones encontradas: {eruptionsStartingWithL.Count()}");

int highestElevation = eruptions.Max(c => c.ElevationInMeters);
Console.WriteLine($"La elevación más alta es: {highestElevation}");

Eruption highestElevationEruption = eruptions.First(c => c.ElevationInMeters == highestElevation);
Console.WriteLine($"El volcán con la elevación más alta ({highestElevation}m) es: {highestElevationEruption.Volcano}");

IEnumerable<string> volcanoNames = eruptions.Select(c => c.Volcano).OrderBy(c => c);
PrintEach(volcanoNames, "Nombres de los volcanes en orden alfabético:");

IEnumerable<Eruption> eruptionsBefore1000 = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano);
PrintEach(eruptionsBefore1000, "Erupciones que ocurrieron antes del año 1000 CE en orden alfabético según el nombre del volcán:");

IEnumerable<string> volcanoNames1000 = eruptions.Where(c => c.Year < 1000).OrderBy(c => c.Volcano).Select(c => c.Volcano);
PrintEach(volcanoNames1000, "Nombres de los volcanes que tuvieron erupciones antes del año 1000 CE en orden alfabético:");
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
