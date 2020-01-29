using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Data.DataManagers
{
    public class PersonDataManager : IPersonDataManager
    {
        private static readonly Lazy<PersonDataManager> lazy = new Lazy<PersonDataManager>(() => new PersonDataManager());

        public static PersonDataManager Instance { get { return lazy.Value; } }

        private Person[] _persons;
        private PersonDataManager()
        {
            _persons = new Person[]{
                new Person
                {
                    FullName = new Name
                    {
                        FirstName = "Grace",
                        LastName = "Hopper"
                    },
                    Address = new Address
                    {
                        City = "New York"
                    }
                },
                new Person
                {
                    FullName = new Name
                    {
                        FirstName = "Alan",
                        LastName = "Turing"
                    },
                    Address = new Address
                    {
                        City = "Bletchley",
                        Street = "Bletchley Park"
                    }
                },
                new Person
                {
                    FullName = new Name
                    {
                        FirstName = "Alan",
                        LastName = "Turing"
                    },
                    Address = new Address
                    {
                        City = "Cambridge",
                        Street = ""
                    }
                },
                new Person
                {
                    FullName = new Name
                    {
                        FirstName = "Joan",
                        LastName = "Clarke"
                    },
                    Address = new Address
                    {
                        City = "Bletchley",
                        Street = "Bletchley Park"
                    }
                },
                 new Person
                {
                    FullName = new Name
                    {
                        FirstName = "Joan",
                        LastName = "Clarke"
                    },
                    Address = new Address
                    {
                        City = "London",
                        Street = ""
                    }
                },
            };
        }

        public Task<IEnumerable<Person>> GetAllData()
        {
           var result = Task<IEnumerable<Person>>.Factory.StartNew(() => { return _persons; });
           return result;
        }

        public Task<int> SetData(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateData(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
