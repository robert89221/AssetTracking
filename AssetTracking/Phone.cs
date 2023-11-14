
namespace AssetTracking
{
    internal sealed class Phone:Asset
    {
        public string Brand { get; }
        public string Model { get; }

        public Phone(string b, string m, int p, DateOnly d):base(p, d)  =>  (Brand, Model) = (b, m);
    }
}
