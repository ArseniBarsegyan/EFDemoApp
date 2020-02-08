using EFDemo.Models;

using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;

namespace EFDemo.Repositories
{
    public class PandaRepository : IDisposable
    {
        private PandaContext _context;

        public PandaRepository(PandaContext context)
        {
            _context = context;
        }

        public void Add(Panda panda)
        {
            _context.Pandas.Add(panda);
            _context.SaveChanges();
        }

        public void Get(Guid id)
        {
            _context.Pandas.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Panda panda)
        {
            _context.Pandas.Attach(panda);
            _context.Entry(panda).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var panda = _context.Pandas.FirstOrDefault(x => x.Id == id);
            _context.Pandas.Remove(panda);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
