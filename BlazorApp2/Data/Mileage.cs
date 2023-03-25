namespace BlazorApp2.Data
{
    public class Mileage
    {
        public DateTime Date { get; set; }
        public int Miles { get; set; }
        public decimal Meters { get => Decimal.Round(Miles * (decimal)1609.34,2); }
        public decimal Gallons { get; set; }
        public decimal Liters { get => Decimal.Round((decimal)Gallons * (decimal)3.78541,2); }
        public decimal MPG 
        { 
            get => Miles != 0 && Gallons != 0 ? Decimal.Round(Miles / Gallons,2):0; 
        }

        public decimal PricePerGallon { get; set; }
        public decimal Total { get; set; }

    }
}
