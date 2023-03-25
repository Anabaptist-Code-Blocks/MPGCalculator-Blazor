namespace BlazorApp2.Data
{
    public class MileageService :IMileageService
    {
        public List<Mileage> Mileages { get; set; } = new();
        public MileageService() { Mileages = GetMileages(); }
        public List<Mileage> GetMileages()
        {
            List<Mileage> mileages = new()
            {
                new Mileage() { Date = (DateTime.Today.AddDays(-7)),Gallons = 25, Miles=400,PricePerGallon=(decimal)4.50 },
                new Mileage() { Date = (DateTime.Today.AddDays(-14)), Gallons = (decimal)12.2, Miles = 222, PricePerGallon = (decimal)4.50 },
                new Mileage() { Date = (DateTime.Today.AddDays(-21)), Gallons = (decimal)24.4, Miles = 423, PricePerGallon = (decimal)4.50 },
                new Mileage() { Date = (DateTime.Today.AddDays(-28)), Gallons = (decimal)23.5, Miles = 388, PricePerGallon = (decimal)4.50 },
                new Mileage() { Date = (DateTime.Today.AddDays(-33)), Gallons = (decimal)18.8, Miles = 322, PricePerGallon = (decimal)4.50 },
                new Mileage() { Date = (DateTime.Today.AddDays(-40)),Gallons = (decimal)25.6, Miles=450,PricePerGallon=(decimal)4.50 },
                new Mileage() { Date = (DateTime.Today.AddDays(-47)),Gallons = 25, Miles=400,PricePerGallon=(decimal)4.50 }
            };
            foreach (var m in mileages)
            {
                m.Total = CalculateTotalGallons(m);
            }
            return mileages;
        }
        public decimal CalculateTotalGallons(Mileage mileage)
        {
            return mileage.Gallons * mileage.PricePerGallon;
        }
    }

    public interface IMileageService
    {
        List<Mileage> Mileages { get; set; }
        List<Mileage> GetMileages();
        decimal CalculateTotalGallons(Mileage mileage);
    }
}
