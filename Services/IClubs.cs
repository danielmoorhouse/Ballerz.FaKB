using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface IClubs 
    {
           Club GetById(int id);
         IEnumerable<Club> GetAll(); 
         Task<Club> GetByClubName(string clubName);
         List<Club> GetByCompetitionId(int id);
         Task Create(Club club);
         Task Edit(int clubId);
         Task Delete(int clubId); 
    }
}