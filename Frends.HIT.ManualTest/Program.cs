using Frends.HIT.CSV;

var date = new DateTime(2000, 1, 1);

var headers = new List<string>()
{
    "Dosage",
    "Drug",
    "Patient",
    "Date"
};

var data = new List<List<object>>()
{
    new List<object>() {25, "Indocin", "David", date},
    new List<object>() {50, "Enebrel", "Sam", date},
    new List<object>() {10, "Hydralazine", "Christoff", date},
    new List<object>() {21, "Combiv;ent", "Janet", date},
    new List<object>() {100, "Dilantin", "Melanie", date}
};

var result = CSV.Create(
    new CreateInput() { 
        InputType = CreateInputType.List, 
        Delimiter = ";", 
        Data = data, 
        Headers = headers
    }, 
    new CreateOption() { 
        CultureInfo = "fi-FI",
        ForceQuotesAroundValues = true,
        ForcedQuoteCharacter = "\""
    }
);

Console.WriteLine(result.Csv);
Console.WriteLine("Hold");

//             Assert.That(result.Csv,
// Is.EqualTo(
// @"Dosage;Drug;Patient;Date
// 25;Indocin;David;1.1.2000 0.00.00
// 50;Enebrel;Sam;1.1.2000 0.00.00
// 10;Hydralazine;Christoff;1.1.2000 0.00.00
// 21;""Combiv;ent"";Janet;1.1.2000 0.00.00
// 100;Dilantin;Melanie;1.1.2000 0.00.00
// "));
        