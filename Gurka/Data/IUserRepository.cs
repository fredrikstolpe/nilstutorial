using Gurka.Models;

namespace Gurka.Data
{
    public interface IUserRepository
    {
        Person GetUser(int id);
    }
}
