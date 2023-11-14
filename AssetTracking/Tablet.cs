
namespace AssetTracking
{
    internal sealed class Tablet:Asset
    {
        public string Brand { get; }
        public string Model { get; }

        public Tablet(string b, string m, int p, DateOnly d):base(p, d)  =>  (Brand, Model) = (b, m);
    }
}
