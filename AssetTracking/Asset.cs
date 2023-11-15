
namespace AssetTracking
{
    //  klass för att representera en kontorstillgång

    internal class Asset
    {
        public enum Office
        {
            Malmö,
            Tokyo,
            SãoPaulo
        }

        public string Type { get; }
        public string Brand { get; }
        public string Model { get; }
        public DateTime PurchaseDate { get; }
        public int Price { get; }
        public Office Location { get; }

        public Asset(string t, string b, string m, string l, DateTime d, int p)
        {
            Office o = 0;

            l = l.ToUpper().Trim();
            if      (l == "M")    o = Office.Malmö;
            else if (l == "T")    o = Office.Tokyo;
            else if (l == "S")    o = Office.SãoPaulo;
            else                  throw new Exception("Location must be M (Malmö), T (Tokyo) or S (São Paulo)");

            (Type, Brand, Model, Location, PurchaseDate, Price) = (t, b, m, o, d, p);
        }

        override public string ToString()
        {
            double localPrice = 0.0;
            string currency = "";

            //  beräkna värde i lokal valuta

            if      (Location == Office.Malmö)       (currency, localPrice) = ("SEK", Price * 10.5);
            else if (Location == Office.Tokyo)       (currency, localPrice) = ("YEN", Price * 150.66);
            else if (Location == Office.SãoPaulo)    (currency, localPrice) = ("BRL", Price * 4.86);

            return $"{Type,-12}{Brand,-12}{Model,-15}{Location.ToString(),-10}{PurchaseDate.ToShortDateString(),12}{Price,10}{localPrice,15:0.00}{currency,4}";
        }
    }
}
