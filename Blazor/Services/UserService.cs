namespace Blazor.Data
{
    public class UserService
    {
        private static readonly string[] Names = new[]
        {
        "John", "Hero", "Mike", "Bob", "Ron", "Katheine", "George" 
        };

        private static readonly string[] Surnames = new[]
        {
        "Shmidt", "Aknaev", "Lor", "Linaev", "Sogth", "Lason"
        };

        public static List<User> GetUserList()
        {
            return Enumerable.Range(1, Random.Shared.Next(1, 7)).Select(index => new User
            {
                Name = Names[Random.Shared.Next(Names.Length)],
                Surname = Surnames[Random.Shared.Next(Surnames.Length)],
                Age = Random.Shared.Next(0, 100)
            }).ToList();
        }
    }
}