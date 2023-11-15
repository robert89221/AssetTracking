
using System.ComponentModel.DataAnnotations;

namespace AssetTracking
{
    internal class Asset
    {
        public enum Office
        {
            Malmö,
            Tokyo,
            SãoPaulo
        }

        public string Type { get; protected set; }
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public DateTime PurchaseDate { get; protected set; }
        public int Price { get; protected set; }
        public Office Location;

        public Asset(string t, string b, string m, string l, DateTime d, int p)
        {
            Office o = 0;

            l = l.ToUpper();
            if (l == "M")         o = Office.Malmö;
            else if (l == "T")    o = Office.Tokyo;
            else if (l == "S")    o = Office.SãoPaulo;

            (Type, Brand, Model, Location, PurchaseDate, Price) = (t, b, m, o, d, p);
        }

        override public string ToString()
        {
            double localPrice = 0.0;
            string currency = "";

            if (Location == Office.Malmö)            (localPrice, currency) = (Price * 10.5, "SEK");
            else if (Location == Office.Tokyo)       (localPrice, currency) = (Price * 150.66, "YEN");
            else if (Location == Office.SãoPaulo)    (localPrice, currency) = (Price * 4.86, "BRL");

            return $"{Type,-12}{Brand,-12}{Model,-15}{Location.ToString(),-10}{PurchaseDate.ToShortDateString(),12}{Price,10}{localPrice,15:0.00}{currency,4}";
        }
    }
}
