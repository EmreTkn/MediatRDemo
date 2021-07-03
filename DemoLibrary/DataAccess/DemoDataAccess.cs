using DemoLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel
            { Id = 1, FirstName = "Emre", LastName = "Tekin" });
            people.Add(new PersonModel
            { Id = 2, FirstName = "Ceren", LastName = "Tekin" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }
        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel model = new() { FirstName = firstName, LastName = lastName };
            model.Id = people.Max(x => x.Id) + 1;
            people.Add(model);
            return model;
        }
    }
}
