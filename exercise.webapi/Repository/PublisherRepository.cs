﻿using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class PublisherRepository : IPublisherRepository
    {

        private DataContext _db;

        public PublisherRepository(DataContext db) {  _db = db; }
        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author).ToListAsync();
        }

        public async Task<Publisher?> GetPublisherById(int id)
        {
            return await _db.Publishers.Include(b => b.Books).ThenInclude(a => a.Author).FirstOrDefaultAsync(p => p.Id == id);
            
        }
    }
}
