using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Service;
using DAL.Data;
using DAL.Models;

namespace Business.Repository
{
    public class CardRepository : ICardService
    {
        private readonly AppDbContext _context;
        public CardRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(Card TEntity)
        {
            TEntity.CreateDate = DateTime.UtcNow.AddHours(4);


            await _context.Cards.AddAsync(TEntity);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Card> Get(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Card>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(int id, Card TEntity)
        {
            var data = await Get(id);

            data.Name = TEntity.Name;
            data.Age = TEntity.Age;
            data.Image = TEntity.Image;
            data.UpdateDate = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();
        }
    }
}
