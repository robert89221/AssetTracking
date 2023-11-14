
using System.Collections;

namespace AssetTracking
{
    internal sealed class Inventory:IEnumerable
    {
        private List<Asset> Items { get; }

        public Inventory()  =>  Items = new List<Asset>();

        public void AddItem(Asset a)  =>  Items.Add(a);
        
        public IEnumerator GetEnumerator()  =>  Items.GetEnumerator();
    }
}
