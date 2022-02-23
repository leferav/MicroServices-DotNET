using System.Threading;
using System.Collections.Generic;
using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
           
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }



        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementeAndGet(),
                FistName = "Leandro",
                LastName = "Avila",
                Address = "Minas Gerais - Araguari",
                Gender = "Mail"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person 
            {
                Id = IncrementeAndGet(),
                FistName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" + i,
                Gender = "Mail"
            };
        }

        private long IncrementeAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
