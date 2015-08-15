using Gurka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gurka.Data
{
    public class MonkeyUserRepository : IUserRepository
    {
        public Models.Person GetUser(int id)
        {
            var person = new Person();
            person.FirstName = "Monkey";
            return person;
        }
    }
}