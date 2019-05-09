using System.Collections.Generic;
using System.Linq;
using Ballerz.Football.Data;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services.Implementations
{
    public class ContinentsService : IContinent
    {
         private readonly ApplicationDbContext _db;
        public ContinentsService(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Continents> GetAll()
        {
            return _db.Continents.ToList();
        }
    }
}