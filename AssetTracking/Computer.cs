
namespace AssetTracking
{
    internal sealed class Computer:Asset
    {
        public string Brand { get; }
        public string Model { get; }

        public Computer(string b, string m, int p, DateOnly d):base(p, d)  =>  (Brand, Model) = (b, m);
    }
}
