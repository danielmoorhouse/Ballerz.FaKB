using System.Collections.Generic;
using Ballerz.Football.Knowledgebase;

namespace Ballerz.Football.Services
{
    public interface IContinent
    {
         IEnumerable<Continents> GetAll(); 
    }
}