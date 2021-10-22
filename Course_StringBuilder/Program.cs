using System;
using Course_StringBuilder.Entities;

namespace Course_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("HAVE A NICE TRIP!");
            Comment c2 = new Comment("WOW THAT'S AWESOME!");
            Post p1 = new Post(
                DateTime.Parse("21/10/2021 00:49:45"),
                "TRAVELING TO NEW ZEALAND",
                "I'M GOING TO VISIT THIS WONDERFUL COUNTRY!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("GOOD NIGHT");
            Comment c4 = new Comment("MAY THE FORCE BE WITH YOU");
            Post p2 = new Post(
                DateTime.Parse("22/10/2021 00:53:45"),
                "GOOD NIGHT GUYS",
                "SEE YOU TOMORROW",
              5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
