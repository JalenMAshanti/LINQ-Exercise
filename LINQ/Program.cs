namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"Animal Crossing",  "Legend Of Zelda", "Elden Ring", "Bioshock", "Mario Kart", "Super Smash Bros"};

            Console.WriteLine("Method Syntax----------------------");
            // With Method Syntax------------------------

            var orderBy = list.OrderBy(x => x.Length);
            foreach (var game in orderBy)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("Query Syntax----------------------");
            //With Query Syntax---------------------------

            var result = from game in list
                         orderby game.Length
                         select game;

            foreach (var item in result) 
            { 
                Console.WriteLine(item);
            }
                         
        }
    }
}
