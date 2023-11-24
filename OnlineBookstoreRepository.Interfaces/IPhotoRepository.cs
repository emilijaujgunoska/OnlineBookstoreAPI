using OnlineBookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Repository.Interfaces
{
    public interface IPhotoRepository
    {
        void Add(Photo photo);

        void Edit(Photo photo);

        void Delete(Photo photo);

        Photo GetPhotoById(int id);

        IEnumerable<Photo> GetAllPhotos();

        IEnumerable<Photo> GetPhotosByDate(DateTime date);

        IEnumerable<Photo> GetAllMainPhotos(bool isMain);
    }
}
