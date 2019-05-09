using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Data;
using Ballerz.Football.Knowledgebase;
using Ballerz.Football.Services;

namespace Ballerz.Football.Services.Implementations
{
    public class SeasonsService : ISeason
    {
           private readonly ApplicationDbContext _db;
        public SeasonsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Seasons seasons)
        {
             _db.Add(seasons);
            await _db.SaveChangesAsync();
        }
        public IEnumerable<Seasons> GetAll()
        {
            return _db.Seasons.ToList();
        }
    }
}