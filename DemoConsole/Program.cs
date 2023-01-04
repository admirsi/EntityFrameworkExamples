using DemoConsole.Entities;

namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            using (var db = new ActorDBContext())
            {
                // Seed
                db.Actors.AddRange(
                    new Actor { Name = "Bruce Lee", Age = 75, AcademyWiner = false },
                    new Actor { Name = "Maddona", Age = 55, AcademyWiner = true }
                    );
                var count = db.SaveChanges();

                // Fetch data & write it out
                Console.WriteLine($"{ count } records added");

                foreach (var Actor in db.Actors ) 
                {
                    Console.WriteLine($"Name - {Actor.Name},\t\t" +
                                      $"Age - {Actor.Age},\t\t" +
                                      $"Academy Winner - {Actor.AcademyWiner}, \t\t");
                }
                Console.ReadLine();
            }
        }
    }
}
