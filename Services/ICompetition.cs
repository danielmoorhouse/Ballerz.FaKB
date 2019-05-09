using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface ICompetition
    {
        Competitions GetById(int id);
         IEnumerable<Competitions> GetAll(); 

           Task Create(Competitions competitions);
         Task Edit(int competitionsId);
         Task Delete(int competitionsId); 
    }
}