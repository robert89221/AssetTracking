// Asset tracking

using AssetTracking;
using System.Diagnostics;
using System.Reflection;


var assets = new List<Asset>();
PopulateInventory();


Console.WriteLine("Type        Brand       Model         Date           Price\n");

var query = from Asset item in assets
            orderby item.Type, item.PurchaseDate
            select item;

foreach (var item in query)
{
    var days = (item.PurchaseDate + new TimeSpan(3 * 365,0,0,0) - DateTime.Today).Days;

    if (days < 90)          Console.ForegroundColor = ConsoleColor.Red;
    else if (days < 180)    Console.ForegroundColor = ConsoleColor.Yellow;
    else                    Console.ForegroundColor = ConsoleColor.Green;
    
    Console.WriteLine(item);
}


void PopulateInventory()
{
    assets.Add(new Asset("Computer", "Lenovo", "L23", new DateTime(2021, 4, 11), 2000));
    assets.Add(new Asset("Phone", "Xiaomi", "X12", new DateTime(2022, 5, 6), 245));
    assets.Add(new Asset("Tablet", "Samsung", "Pad P4", new DateTime(2023, 8, 7), 810));
    assets.Add(new Asset("Computer", "Siemens", "Power W5", new DateTime(2020, 2, 12), 3000));
    assets.Add(new Asset("Phone", "Nokia", "3.1", new DateTime(2020, 8, 4), 450));
    assets.Add(new Asset("Tablet", "Sony", "SonyPad II", new DateTime(2020, 9, 20), 700));
    assets.Add(new Asset("Computer", "Asus", "Super", new DateTime(2010, 2, 1), 800));
    assets.Add(new Asset("Phone", "Sharp", "Aquos 4", new DateTime(2021, 6, 18), 900));
    assets.Add(new Asset("Tablet", "Huawei", "WordPad 2", new DateTime(2021, 5, 1), 552));
}
