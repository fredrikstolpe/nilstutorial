
namespace Gurka.Data
{
    public class EntityFrameWorkUserRepository : IUserRepository
    {
        public Models.Person GetUser(int id)
        {
            var db = new GurkaDbContext();
            var person = db.Persons.Find(id);
            return person;
        }
    }
}