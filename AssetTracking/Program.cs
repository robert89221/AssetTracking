// Asset tracking

using AssetTracking;


var assets = new List<Asset>();
PopulateInventory();


var query = from Asset item in assets
            orderby item.Type, item.PurchaseDate
            select item;

foreach (var item in query)
{
    var days = (item.PurchaseDate + new TimeSpan(3 * 365,0,0,0) - DateTime.Today).Days;
    Console.ForegroundColor = days < 90 ? ConsoleColor.Red : ConsoleColor.Yellow;
    Console.WriteLine(item);
}


void PopulateInventory()
{
    assets.Add(new Asset("Computer", "Lenovo", "L23", new DateTime(2021, 2, 11), 2000));
    assets.Add(new Asset("Phone", "Xiaomi", "X12", new DateTime(2022, 5, 6), 245));
    assets.Add(new Asset("Tablet", "Samsung", "Pad P4", new DateTime(2023, 8, 7), 810));
    assets.Add(new Asset("Computer", "Siemens", "Power W5", new DateTime(2020, 2, 12), 3000));
    assets.Add(new Asset("Phone", "Nokia", "3.1", new DateTime(2020, 8, 4), 450));
    assets.Add(new Asset("Tablet", "Sony", "SonyPad II", new DateTime(2020, 6, 20), 700));
    assets.Add(new Asset("Computer", "Asus", "Super", new DateTime(2010, 6, 1), 800));
    assets.Add(new Asset("Phone", "Sharp", "Aquos 4", new DateTime(2021, 6, 18), 900));
    assets.Add(new Asset("Tablet", "Huawei", "WordPad 2", new DateTime(2022, 12, 12), 552));
}
