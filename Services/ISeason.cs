using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface ISeason
    {
           Task Create(Seasons seasons); 
        IEnumerable<Seasons> GetAll();
    }
}