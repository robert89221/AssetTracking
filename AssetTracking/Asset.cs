
namespace AssetTracking
{
    internal abstract class Asset
    {
        public int Price { get; }
        public DateOnly PurchaseDate { get; }

        public Asset(int p, DateOnly d)  =>  (Price, PurchaseDate) = (p, d);
    }
}
