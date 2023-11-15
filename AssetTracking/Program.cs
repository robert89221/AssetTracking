
using AssetTracking;


//  skapa lista med tillgångar

var assets = new List<Asset>();
PopulateInventory();


//  skriv ut alla tillgångar, sorterade först efter kontor, sen efter inköpsdatum

var query = from Asset item in assets
            orderby item.Location.ToString(), item.PurchaseDate
            select item;

Console.WriteLine("Type        Brand       Model          Office      Date       Price USD        Local price\n");

foreach (var result in query)
{
    //  beräkna antalet dagar till EOL (3 år från inköpsdatum) och färgsätt texten

    var days = (result.PurchaseDate + new TimeSpan(3*365, 0, 0, 0) - DateTime.Today).Days;

    if      (days < 90)     Console.ForegroundColor = ConsoleColor.Red;
    else if (days < 180)    Console.ForegroundColor = ConsoleColor.Yellow;
    else                    Console.ForegroundColor = ConsoleColor.Green;
 
    Console.WriteLine(result);
}


//  lägg till lite prylar

void PopulateInventory()
{
    assets.Add(new Asset("Computer", "Lenovo",  "L23",        "M", new DateTime(2021, 4, 11),  2100));
    assets.Add(new Asset("Phone",    "Xiaomi",  "X12",        "T", new DateTime(2022, 5, 6),    245));
    assets.Add(new Asset("Tablet",   "Samsung", "Pad P4",     "T", new DateTime(2023, 8, 7),    810));
    assets.Add(new Asset("Computer", "Siemens", "Power W5",   "M", new DateTime(2020, 2, 12),  2995));
    assets.Add(new Asset("Phone",    "Nokia",   "3.1",        "M", new DateTime(2020, 8, 4),    450));
    assets.Add(new Asset("Tablet",   "Sony",    "SonyPad II", "S", new DateTime(2020, 9, 20),   700));
    assets.Add(new Asset("Computer", "Asus",    "Super",      "S", new DateTime(2010, 2, 1),   1900));
    assets.Add(new Asset("Phone",    "Sharp",   "Aquos 4",    "S", new DateTime(2021, 6, 18),   900));
    assets.Add(new Asset("Tablet",   "Huawei",  "WordPad 2",  "T", new DateTime(2021, 5, 1),    355));
    assets.Add(new Asset("Tablet",   "Asus",    "MatePad X",  "M", new DateTime(2022, 11, 5),   450));
    assets.Add(new Asset("Tablet",   "Sony",    "Padio III",  "M", new DateTime(2023, 1, 9),    595));
    assets.Add(new Asset("Phone",    "Asus",    "Zenfone 2",  "S", new DateTime(2022, 9, 28),   715));
    assets.Add(new Asset("Phone",    "Nokia",   "X20",        "S", new DateTime(2023, 3, 17),   550));
    assets.Add(new Asset("Computer", "Toshiba", "T40",        "T", new DateTime(2022, 4, 30),  1410));
    assets.Add(new Asset("Computer", "Fujitsu", "FJ-5000",    "T", new DateTime(2022, 12, 24), 3510));
}
