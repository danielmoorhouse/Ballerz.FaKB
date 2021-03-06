using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Data;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services.Implementations
{
    public class CompetitionsService : ICompetition
    {
          private readonly ApplicationDbContext _db;
        public CompetitionsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Competitions competitions)
        {
             _db.Add(competitions);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int competitionsId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int competitionsId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Competitions> GetAll()
        {
            return _db.Competitions.ToList();
        }

        public Competitions GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}