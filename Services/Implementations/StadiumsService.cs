using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Data;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services.Implementations
{
    public class StadiumsService : IStadium
    {
        private readonly ApplicationDbContext _db;
        public StadiumsService(ApplicationDbContext db)
        {
            _db = db;
        }
       public async Task Create(Stadium stadiums)
        {
            _db.Add(stadiums);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int stadiumsId)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int stadiumsId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Stadium> GetAll()
        {
            return _db.Stadiums.ToList();
        }

        public Stadium GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Stadium> GetByStadiumName(string stadiumName)
        {
            throw new System.NotImplementedException();
        }

       public Stadium GetByClubId(int id)
        {
            var stadium = _db.Stadiums.Where(s => s.HomeTeamId == id).FirstOrDefault();
            return stadium;
        }
    }
}