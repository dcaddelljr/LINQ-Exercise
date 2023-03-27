namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>()
            {
                "Mario Brothers",
                "Zelda",
                "Donkey Kong",
                "Punch Out"
            };

            var sortedList = games.OrderBy(game => game.Length);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
