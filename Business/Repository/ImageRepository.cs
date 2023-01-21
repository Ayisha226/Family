using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Service;
using DAL.Models;

namespace Business.Repository
{
    public class ImageRepository : IImageService
    {
        public Task Create(Image entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Image> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Image>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Image TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
