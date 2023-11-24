namespace OnlineBookstore.Repositories
{
    using OnlineBookstore.Data;
    using OnlineBookstore.Entities;
    using OnlineBookstore.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PublisherRepository : IPublisherRepository
    {
        private readonly OnlineBookstoreDbContext _context;

        public PublisherRepository(OnlineBookstoreDbContext context)
        {
            _context = context;
        }

        public void Add(Publisher publisher)
        {
            _context.Publisher.Add(publisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            _context.Publisher.Remove(publisher);
            _context.SaveChanges();
        }

        public void Edit(Publisher publisher)
        {
            _context.Publisher.Update(publisher);
            _context.SaveChanges();
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            var result = _context.Publisher.AsEnumerable();
            return result;
        }

        public Publisher GetPublisherByCountry(string country)
        {
            var result = _context.Publisher.FirstOrDefault(x => x.Country == country);
            return result;
        }

        public Publisher GetPublisherById(int id)
        {
            var result = _context.Publisher.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Publisher GetPublisherByName(string name)
        {
            var result = _context.Publisher.FirstOrDefault(x => x.Name == name);
            return result;
        }
    }
}
