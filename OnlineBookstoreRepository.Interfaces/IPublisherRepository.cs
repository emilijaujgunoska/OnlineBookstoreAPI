using OnlineBookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.Interfaces
{
    public interface IPublisherRepository
    {
        void Add(Publisher publisher);

        void Edit(Publisher publisher);

        void Delete(Publisher publisher);

        Publisher GetPublisherById(int id);

        Publisher GetPublisherByName(string name);

        Publisher GetPublisherByCountry(string country);

        IEnumerable<Publisher> GetAllPublishers();
    }
}
