using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            RecuitersRepo repo = new RecuitersRepo();
            var query = from r in repo.GetAllRecruiters()
                        where r.Age < 40
                        orderby r.Firstname ascending, r.Age descending
                        select new
                        {
                            name = $"{r.Firstname} {r.Lastname}",
                            email = r.Email
                        };

            var singleRecruiter = (from r in repo.GetAllRecruiters()
                                   where r.Age < 40
                                   orderby r.Firstname ascending, r.Age descending
                                   select r).SingleOrDefault();

            foreach (var r in query.ToList())
            {
                Console.WriteLine("> " + r.name);
            }


            var recroeters = repo.GetAllRecruiters().Where(r => r.Age < 40).SingleOrDefault<Recruiter>();
            var recrouters = repo.GetAllRecruiters().Select(r => r.Age < 40).ToList();



        }


    }

    static class StringExtensions
    {
        public static bool EindigtMet(this string value, string chars)
        {
            return value.EndsWith(chars);
        }
    }

    class RecuitersRepo
    {
        public IEnumerable<Recruiter> GetAllRecruiters()
        {
            return new List<Recruiter> {
                new Recruiter(){Email = "ben@elmos.be", Firstname = "Ben", Lastname = "Lissens", Age = 30, CanBringCoffee = false, Experience = Experience.Medior  },
                new Recruiter(){Email = "charlotte@elmos.com", Firstname = "Charlotte", Lastname = "Roelandt", Age = 34, CanBringCoffee = true, Experience = Experience.Senior},
                new Recruiter(){Email = "Ann@elmos.nl", Firstname = "Ann", Lastname = "Liekens", Age = 36, CanBringCoffee = false, Experience = Experience.Medior },
                new Recruiter(){Email = "Joris@elmos.be", Firstname = "Joris", Lastname = "Van Staay", Age = 42, CanBringCoffee = false, Experience = Experience.Senior}
            };
        }
    }


    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public string MakeCoffee() {
            return "I'm making Coffee";
        }
    }


    class Recruiter:Person
    {
        public bool CanBringCoffee { get; set; }
        public Experience Experience { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} ({Age} years old)";
        }
    }

    enum Experience
    {
        Junior,
        Medior,
        Senior,
        Charlotte
    }
}
