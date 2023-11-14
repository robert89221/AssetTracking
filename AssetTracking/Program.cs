// Asset tracking

using AssetTracking;


var assets = new Inventory();
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
    assets.AddItem(new Computer("Lenovo", "L23", 2000, new DateTime(2021, 2, 11)));
    assets.AddItem(new Phone("Xiaomi", "X12", 245, new DateTime(2022, 5, 6)));
    assets.AddItem(new Tablet("Samsung", "Pad P4", 810, new DateTime(2023, 8, 7)));
    assets.AddItem(new Computer("Siemens", "Power W5", 3000, new DateTime(2020, 2, 12)));
    assets.AddItem(new Phone("Nokia", "3.1", 450, new DateTime(2020, 8, 4)));
    assets.AddItem(new Tablet("Sony", "SonyPad II", 700, new DateTime(2020, 6, 20)));
    assets.AddItem(new Computer("Asus", "Super", 800, new DateTime(2010, 6, 1)));
    assets.AddItem(new Phone("Sharp", "Aquos 4", 900, new DateTime(2021, 6, 18)));
    assets.AddItem(new Tablet("Huawei", "WordPad 2", 552, new DateTime(2022, 12, 12)));
}
