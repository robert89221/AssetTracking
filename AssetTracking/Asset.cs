
namespace AssetTracking
{
    internal class Asset
    {
        public string Type { get; protected set; }
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public DateTime PurchaseDate { get; protected set; }
        public int Price { get; protected set; }

        public Asset(string t, string b, string m, DateTime d, int p)  =>  (Type, Brand, Model, PurchaseDate, Price) = (t, b, m, d, p);

        override public string ToString() => $"{Type,-12}{Brand,-12}{Model,-12}{PurchaseDate.ToShortDateString(),12}{Price,10}";
    }
}
