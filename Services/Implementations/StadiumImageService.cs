using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Football.Data;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services.Implementations
{
    public class StadiumImageService : IStadiumImage
    {
           private readonly ApplicationDbContext _db;
        public StadiumImageService(ApplicationDbContext db)
        {
            _db = db;
        }
          public async Task Create(StadiumImages stadiumImage)
        {
            _db.Add(stadiumImage);
            await _db.SaveChangesAsync();
        }

        public Task Delete(int stadiumImage)
        {
            throw new System.NotImplementedException();
        }

        public Task Edit(int stadiumImage)
        {
            throw new System.NotImplementedException();
        }

          public IEnumerable<StadiumImages> GetAll()
        {
            return _db.StadiumImages.ToList();
        }
    }
}