namespace Blazor.Data
{
    public class UnitService
    {
        private static readonly string[] Names = new[]
        {
        "John", "Hero", "Mike", "Bob", "Ron", "Katheine", "George" 
        };

        private static readonly string[] Surnames = new[]
        {
        "Shmidt", "Aknaev", "Lor", "Linaev", "Sogth", "Lason"
        };

        public List<Unit> GetForecastAsync(DateTime startDate)
        {
            return Enumerable.Range(1, 5).Select(index => new Unit
            {
                Name = Names[Random.Shared.Next(Names.Length)],
                Surname = Surnames[Random.Shared.Next(Surnames.Length)],
                Age = Random.Shared.Next(0, 100)
            }).ToList();
        }
    }
}