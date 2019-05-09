using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface IStadium
    {
         Stadium GetById(int id);
         Stadium GetByClubId(int id);
         IEnumerable<Stadium> GetAll(); 
         Task<Stadium> GetByStadiumName(string stadiumName);
         Task Create(Stadium stadiums);
         Task Edit(int stadiumsId);
         Task Delete(int stadiumsId); 
    }
}