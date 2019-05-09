using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface IClubPersonHistory
    {
          Task Create(ClubPersonHistory clubPersonHistory); 
        IEnumerable<ClubPersonHistory> GetAll();  
    }
}