
namespace AssetTracking
{
    internal sealed class Computer:Asset
    {
        public string Brand { get; }
        public string Model { get; }

        public Computer(string b, string m, int p, DateTime d):base("Computer", p, d)  =>  (Brand, Model) = (b, m);

        override public string ToString()  =>  $"{Type,-10}{Brand,-15}{Model,-15}{PurchaseDate.ToShortDateString(),15}{Price,6}";
    }
}
