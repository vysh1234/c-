using System;

namespace Demo_LatestLangFeautures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //implementing Records

            //person CFO = new person();
            //CFO.Fname = "mike";
            //CFO.Lname = "scot";

            Newperson CEO = new Newperson();
            CEO.Firstname = "sathya";
            CEO.LastName = "nalleda";

            Coordinates India = new Coordinates(120, 220);
            
            Console.WriteLine("Indian coordinates are :" + India.X + India.Y);
            

            

        }
    }
    public record person(string Fname,string LName);
    public record person1
    {
        public string First_Name { get; init; } =default!;
        public string LastName { get; init; } = default!;
    }
    public record Newperson
    {
        public string Firstname { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
