using LibraryManagement.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Data.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAll();

    }
    public class PersonRepository : IPersonRepository
    {
        private readonly LibraryContext context;
        public PersonRepository(LibraryContext context)
        {
            this.context = context;
        }
        public List<Person> GetAll()
        {
            return context.Persons.Where(x => !x.Deleted).ToList();
        }
    }
}
