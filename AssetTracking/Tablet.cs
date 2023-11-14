
namespace AssetTracking
{
    internal sealed class Tablet:Asset
    {
        public string Brand { get; }
        public string Model { get; }

        public Tablet(string b, string m, int p, DateTime d):base("Tablet", p, d)  =>  (Brand, Model) = (b, m);

        override public string ToString()  =>  $"{Type,-10}{Brand,-15}{Model,-15}{PurchaseDate.ToShortDateString(),15}{Price,6}";
    }
}
