using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface IClubRole
    {
        IEnumerable<ClubRole> GetAll(); 
         Task<ClubRole> GetByClubName(string clubRole);
         List<ClubRole> GetByCompetitionId(int id);
         Task Create(ClubRole clubRole);
         Task Edit(int clubRoleId);
         Task Delete(int clubRoleId); 
    }
}