
namespace AssetTracking
{
    internal abstract class Asset
    {
        public int Price { get; }
        public DateTime PurchaseDate { get; }
        public string Type { get; }

        public Asset(string t, int p, DateTime d)  =>  (Type, Price, PurchaseDate) = (t, p, d);
    }
}
